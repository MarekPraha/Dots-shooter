using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBirdsLidl
{
    public class GameLogic
    {
        private List<Ball> balls = new List<Ball>();

        Random random = new Random();

        public int Width { get; set; }
        public int Height { get; set; }

        public GameLogic(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;

            Init();
        }
        public async void DrawUpdate(Graphics g)
        {
            List<Task> toDraw = new List<Task>();
            foreach (var item in balls)
            {
                toDraw.Add(item.Draw(g));
            }
            await Task.WhenAll(toDraw);
        }

        public void Move()
        {
            foreach (var item in balls)
            {
                item.Move();
            }
        }

        public void Reset()
        {
            balls.Clear();
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
                brush = Brushes.Black       
            });
        }
    }
}
