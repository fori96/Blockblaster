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
        int level = 1;
        List<Panel> blocks = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        public void InitGame()
        {
            _player = new Player(player, score_label, life_label);
            _ball = new Ball(ball, _player);
            InitBlocks(level);
        }

        public void InitBlocks(int lvl)
        {
            for (int i = 0; i < blocksnumber; i++)
            {
                Panel add = new Panel()
                {
                    Height = 20,
                    Width = 80,
                    Location = new Point((i % 10) * 80, (int)Math.Floor((decimal)i / 10) * 40 + 25),
                    //(lvl == 1) ? System.Drawing.Color.Red : System.Drawing.Color.Yellow,
                    BorderStyle = BorderStyle.FixedSingle,
                    Visible = true,
                };
                switch (lvl)
                {
                    case 1:
                        add.BackColor = Color.Red;
                        break;
                    case 2:
                        add.BackColor = Color.Orange;
                        break;
                    case 3:
                        add.BackColor = Color.Yellow;
                        break;
                    case 4:
                        add.BackColor = Color.Green;
                        break;
                    case 5:
                        add.BackColor = Color.Blue;
                        break;
                    case 6:
                        add.BackColor = Color.Purple;
                        break;
                    case 7:
                        add.BackColor = Color.Gray;
                        break;
                    case 8:
                        add.BackColor = Color.Black;
                        break;
                    case 9:
                        add.BackColor = Color.Wheat;
                        break;
                    case 10:
                        add.BackColor = Color.Transparent;
                        break;
                }
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
                result.Visible = false;
                _player.Move();
                _ball.Move();
               
                foreach(Panel b in blocks)
                    if (b.Bounds.IntersectsWith(ball.Bounds))
                    {
                        if (b.BackColor == Color.Yellow)
                            b.BackColor = Color.Red;
                        else
                        {
                            b.Visible = false;
                            blocks.Remove(b);
                            this.Controls.Remove(b);
                        }                            

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
                EndTitle(true);
            }

            if(_player.point % (30 * level) == 0)
            {
                level += 1;
                InitBlocks(level);
                level_label.Text = "Szint : " + level.ToString();
            }
            if (_player.point == 1650)
                EndTitle(false);
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

        void EndTitle(bool lose)
        {
            if (!lose)
            {
                result.Visible = true;
                Task.Delay(2000);
            }
            else
            {
                result.Visible = true;
                result.Text = "Vesztettél";
                Task.Delay(2000);
            }
            reset = false;
            ask.Visible = true;
            yes.Visible = true;
            no.Visible = true;
            InitBlocks(2);
            _player.life = 3;
            _player.point = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
}
}
