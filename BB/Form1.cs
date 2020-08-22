using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace BB
{
    public partial class Form1 : Form
    {
        bool reset = true;
        Player _player;
        Ball _ball;
        int blocksnumber = 30;
        List<Panel> blocks = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        public void InitGame()
        {
            _player = new Player(player, score, life);
            _ball = new Ball(ball, _player);
            InitBlocks();
        }

        public void InitBlocks()
        {
            for (int i =0; i < blocksnumber; i++)
            {
                Panel add = new Panel()
                {
                    Height = 20,
                    Width = 80,
                    Location = new Point((i%10)*80,(int)Math.Floor((decimal)i/10)*40+25),
                    BackColor = System.Drawing.Color.Red,
                    BorderStyle = BorderStyle.FixedSingle,
                    Visible = true,
                };
                blocks.Add(add);
            }

            foreach (Panel b in blocks)
                this.Controls.Add(b);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (reset)
            {
                ask.Visible = false;
                yes.Visible = false;
                no.Visible = false;
                win.Visible = false;
                _player.Move();
                _ball.Move();
                foreach(Panel b in blocks)
                    if (b.Bounds.IntersectsWith(ball.Bounds))
                    {
                        b.Visible = false;
                        blocks.Remove(b);
                        this.Controls.Remove(b);

                        if ((ball.Right > b.Right) || (ball.Left < b.Left))
                            _ball.hor *= -1;
                        if ((ball.Top < b.Top) || (ball.Bottom > b.Bottom))
                            _ball.ver *= -1;
                        _ball.Score();

                        break;
                    }
            }
            if (_player.life == 0)
            {
                reset = false;
                this.BackgroundImage = null;
                ask.Visible = true;
                yes.Visible = true;
                no.Visible = true;
                _player.life = 3;
                _player.point = 0;
            }
            if (_player._point == 30)
            {
                win.Visible = true;
                Task.Delay(2000);
                reset = false;
                this.BackgroundImage = null;
                ask.Visible = true;
                yes.Visible = true;
                no.Visible = true;
                _player.life = 3;
                _player.point = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Gomb(e, true);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Gomb(e, false);
        }
        private void Gomb(KeyEventArgs e, bool Down)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _player.UpPress = Down;
                    break;
                case Keys.Right:
                    _player.DownPress = Down;
                    break;
            }
        }

        private void yes_Click(object sender, EventArgs e)
        {
            reset = true;
        }

        private void no_Click(object sender, EventArgs e)
        {
            reset = false;
            this.Close();
        }
    }
}
