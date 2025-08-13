using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotsShooter
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

        public bool IsAlive { get; set; } = true;

        public bool Type { get; set; } = true;

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

        public async Task Move()
        {
            this.X += this.VectorX;
            this.Y += this.VectorY;

            //no clipping into walls
            if (
                this.X + this.VectorX < 0 + this.Size ||
                this.X + this.VectorX > this.GameLogic.Width - this.Size
                )
            {
                this.VectorX = -this.VectorX;
            }          
            if (
                this.Y + this.VectorY < 0 + this.Size ||
                this.Y + this.VectorY > this.GameLogic.Height - this.Size
                )
            {
                this.VectorY = -this.VectorY;
            }
        }

        public RectangleF GetBoundingBox()
        {
            if (IsAlive)
            {
                return new RectangleF((float)this.X, (float)this.Y, this.Size, this.Size);
            }
            return RectangleF.Empty;
            
           
        }
    }
}
