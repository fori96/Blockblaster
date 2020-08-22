using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BB
{
    class Player
    {
        const int _speed = 25;
        public PictureBox paddle;
        Label pointL, lifesL;
        public bool UpPress, DownPress; //gombok
        public int _point;
        public int point
        {
            get
            {
                return _point;
            }
            set
            {
                _point = value;
                pointL.Text = "Pont: " + point.ToString();
            }
        }
        public int _life = 3;
        public int life
        {
            get
            {
                return _life;
            }
            set
            {
                _life = value;
                lifesL.Text = "Élet: " + life.ToString();
            }
        }
        public Player(PictureBox player, Label point, Label lifecount)
        {
            this.paddle = player;
            this.pointL = point;
            this.lifesL = lifecount;
        }
        internal void Move()
        {
            bool? Fele = null;
            if (UpPress)
                Fele = true;
            if (DownPress)
            {
                if (Fele.HasValue)
                    Fele = null;
                else Fele = false;
            }
            DoMove(Fele);
        }
        private void DoMove(bool? Upper)
        {
            if (Upper.HasValue)
            {
                var speed = _speed;
                if (Upper.Value)
                    speed *= -1;
                paddle.Location = new Point(Math.Max(Gamefield.left,
                    Math.Min(Gamefield.right - paddle.Width, paddle.Location.X + speed)),
                    paddle.Location.Y);
            }
        }
    }
}
