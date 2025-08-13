using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotsShooter
{
    public class GameLogic
    {
        private List<Ball> balls = new List<Ball>();

        private Random random = new Random();

        public int Width { get; set; }
        public int Height { get; set; }

        public bool friendlyFire { get; set; } = true;

        public bool deleteAfterCollision { get; set; } = true;

        public GameLogic(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;

            Init();
        }
        public async void DrawUpdate(Graphics g)
        {
            //taks to speed up drawing
            List<Task> toDraw = new List<Task>();
            foreach (var item in balls)
            {
                toDraw.Add(item.Draw(g));
            }
            Task.WhenAll(toDraw);
        }

        public async void Move()
        {
            Task.Run(() => CheckColisions());

            List<Task> toMove = new List<Task>();
            List<Ball> toDelte = new List<Ball>();
            foreach (var item in balls)
            {
                if (deleteAfterCollision&&!item.IsAlive)
                {
                    toDelte.Add(item);
                    continue;
                }

                if (item.IsAlive)
                {
                    toMove.Add(item.Move()); 
                }
            }
            foreach (var item in toDelte)
            {
                balls.Remove(item);
            }
            Task.WhenAll(toMove);
        }

        public void Reset()
        {
            this.balls.Clear();
            Init();
        }


        private void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                this.balls.Add(new Ball(this)
                {
                    X = this.Width - i-40,
                    Y = (i * this.Height/9)-20,
                    VectorX = random.NextDouble() * (-5 - 5) + 10,
                    brush = Brushes.Red,
                });
            }
        }


        public void AddPlayBall(int x, int y, int vectorX, int vectorY)
        {
            this.balls.Add(new Ball(this)
            {
                X = x,
                Y = y,
                VectorX = vectorX,
                VectorY = vectorY,
                brush = Brushes.Black,
                Type = false
            });
        }

        private async Task CheckColisions()
        {
            foreach (var BallToCheck in balls)
            {
                RectangleF ball1 = BallToCheck.GetBoundingBox();
                foreach (var BallToCheckAgainst in balls)
                {
                    if (BallToCheck == BallToCheckAgainst)
                    {
                        continue;
                    }
                    if (!BallToCheckAgainst.Type && !this.friendlyFire)
                    {
                        continue;
                    }
                    RectangleF ball2 = BallToCheckAgainst.GetBoundingBox();

                    if (ball1.IntersectsWith(ball2))
                    {
                        BallToCheck.IsAlive = false;
                        BallToCheckAgainst.IsAlive = false;
                    }
                }
            }
        }
    }
}
