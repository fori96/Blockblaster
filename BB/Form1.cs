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
        bool reset = false;
        Player _player;
        Ball _ball;
        int blocksnumber = 40;
        int level = 1;
        List<Panel> blocks = new List<Panel>();
        FileHandler FileHandler = new FileHandler();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView = new System.Windows.Forms.DataGridView {
                Location = new Point(75, 180),
                Size = new Size(400,200),
                BackgroundColor = Color.White,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            this.scoreboard_panel.Controls.Add(this.dataGridView);
            InitGame();
        }

        public void InitGame()
        {
            _player = new Player(player, score_label, life_label);
            _ball = new Ball(ball, _player);
            level_label.Text = "Szint : " + level.ToString();
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
                        add.BackColor = Color.White;
                        break;
                    case 10:
                        add.BackColor = Color.Transparent;
                        add.BorderStyle = BorderStyle.None;
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
                menu_panel.Visible = false;
                _player.Move();
                _ball.Move();
               
                foreach(Panel b in blocks)
                    if (b.Bounds.IntersectsWith(ball.Bounds))
                    {
                        if (b.BackColor == Color.Red)
                        {
                            b.Visible = false;
                            blocks.Remove(b);
                            this.Controls.Remove(b);
                        }
                        else
                        {
                            if (b.BackColor == Color.Orange)
                                b.BackColor = Color.Red;
                            else if (b.BackColor == Color.Yellow)
                                b.BackColor = Color.Orange;
                            else if (b.BackColor == Color.Green)
                                b.BackColor = Color.Yellow;
                            else if (b.BackColor == Color.Purple)
                                b.BackColor = Color.Green;
                            else if (b.BackColor == Color.Blue)
                                b.BackColor = Color.Blue;
                            else if (b.BackColor == Color.Gray)
                                b.BackColor = Color.Purple;
                            else if (b.BackColor == Color.Black)
                                b.BackColor = Color.Gray;
                            else if (b.BackColor == Color.White)
                                b.BackColor = Color.Black;                        
                            else if (b.BackColor == Color.Transparent)
                            {
                                b.BackColor = Color.White;
                                b.BorderStyle = BorderStyle.FixedSingle;
                            }
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

            if(_player.point != 0 && _player.point % (40 * level) == 0)
            {
                level += 1;
                InitBlocks(level);
                level_label.Text = "Szint : " + level.ToString();
            }
            if (_player.point == 2200)
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

        void EndTitle(bool lose)
        {            
            end_panel.Visible = true;
            end_panel.BringToFront();
            if (lose)
            {
                result.Text = "Vesztettél";
            }
            Task.Delay(2000);
            reset = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            InitGame();
            _player.life = 3;
            _player.point = 0;
            InitBlocks(level);
            reset = true;
            end_panel.Visible = false;
            scoreboard_panel.Visible = false;
            readme_panel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scoreboard_label_Click(object sender, EventArgs e)
        {
            readme_panel.Visible = false;
            scoreboard_panel.Visible = true;
            scoreboard_panel.BringToFront();

            List<GameData> list = FileHandler.JsonReading();
            list.Sort((a,b) => b.Score.CompareTo(a.Score));

            dataGridView.DataSource = list;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            FileHandler.JsonWritting(playername.Text,_player.point,DateTime.Now);            
            end_panel.Visible = false;
            end_panel.SendToBack();
            menu_panel.Visible = true;
        }

        private void credit_label_Click(object sender, EventArgs e)
        {
            scoreboard_panel.Visible = false;
            readme_panel.Visible = true;
            desc_label.Text = FileHandler.ReadDescription();
        }
    }
}
