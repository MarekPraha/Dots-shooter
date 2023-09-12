using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBirdsLidl
{
    public class Ball
    {
        public double X { get; set; }
        public double Y { get; set; }

        public int Size { get; set; } = 20;

        public double VectorY { get; set; }
        public double VectorX { get; set; }

        public Brush brush { get; set; }
        public GameLogic GameLogic { get; set; }


        public Ball(GameLogic gameLogic)
        {
            this.GameLogic = gameLogic;
        }

        public async Task Draw(Graphics g)
        {
            g.FillEllipse(brush,
                          (float)this.X - (this.Size / 2),
                          (float)this.Y - (this.Size / 2),
                          this.Size,
                          this.Size);
        }

        public void Move()
        {
            this.X += this.VectorX;
            this.Y += this.VectorY;

                if (this.X < 0)
                {
                    this.VectorX = -this.VectorX;
                }
                if (this.Y < 0)
                {
                    this.VectorY = -this.VectorY;
                }
                if (this.X > this.GameLogic.Width)
                {
                    this.VectorX = -this.VectorX;
                }
                if (this.Y > this.GameLogic.Height)
                {
                    this.VectorY = -this.VectorY;
                }
        }
    }
}
