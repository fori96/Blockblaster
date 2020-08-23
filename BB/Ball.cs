using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BB
{
    class Ball
    {
        private PictureBox aball;
        Random r = new Random();
        Player p1;
        public int hor, ver;

        public Ball(PictureBox aball, Player p1)
        {
            this.aball = aball;
            this.p1 = p1;
            hor = 40;
            ver = 35;
            resetlabda();
        }
        internal void Move()
        {
            var jobb = Gamefield.right - aball.Width;
            aball.Location = new Point(aball.Location.X + hor,
                Math.Max(Gamefield.top, Math.Min(jobb, aball.Location.Y + ver)));
            if (aball.Location.X >= jobb || aball.Location.X <= Gamefield.left)
                hor *= -1;
            if (aball.Location.Y <= Gamefield.top)
                ver *= -1;
            if (aball.Location.Y >= Gamefield.bot)
            {
                resetlabda();
                p1.life -= 1;
            }
            if (p1.paddle.Bounds.IntersectsWith(aball.Bounds))
            {
                //if (p1.paddle.Bounds.Top == aball.Bounds.Bottom)
                //    hor *= -1;
                //if (p1.paddle.Bounds.Left == aball.Bounds.Right || p1.paddle.Bounds.Right == aball.Bounds.Left)
                //    ver = ver * -1;

                if ((aball.Right > p1.paddle.Bounds.Right) || (aball.Left < p1.paddle.Bounds.Left))
                    hor *= -1;
                if ((aball.Top < p1.paddle.Bounds.Top) || (aball.Bottom > p1.paddle.Bounds.Bottom))
                    ver *= -1;
            }
        }
        public void Score()
        {
            p1.point++;
            if (p1.point % 5 == 0)
            {
                ver += 1;
                hor += 1;
            }
        }
        private void resetlabda()
        {
            aball.Location = new Point((Gamefield.left + Gamefield.right) / 2,
                (Gamefield.top + Gamefield.bot) / 2);
            do
            {
                hor = r.Next(-3, 3);
                ver = r.Next(-3, 3);
            } while (Math.Abs(hor) + Math.Abs(ver) <= 3 || Math.Abs(hor) <= 1);
        }
    }
}
