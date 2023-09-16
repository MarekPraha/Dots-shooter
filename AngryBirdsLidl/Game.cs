namespace AngryBirdsLidl
{
    public partial class Game : Form
    {
        private GameLogic gameLogic;

        private int mouseX;
        private int mouseY;
        public Game()
        {
            InitializeComponent();
            this.gameLogic = new GameLogic(this.pictureBox1.Width, this.pictureBox1.Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.gameLogic.DrawUpdate(e.Graphics);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.gameLogic.Reset();
            this.pictureBox1.Invalidate();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.pictureBox1.Refresh();
            this.gameLogic.Move();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int MouseXEnd = e.X;
            int MouseYEnd = e.Y;

            int vectorX = MouseXEnd - mouseX;
            int vectorY = MouseYEnd - mouseY;

            int limit = 20;

            if (vectorX > limit)
            {
                vectorX = limit;
            }
            if (vectorY > limit)
            {
                vectorY = limit;
            }
            if (vectorX < -limit)
            {
                vectorX = -limit;
            }
            if (vectorY < -limit)
            {
                vectorY = -limit;
            }


            gameLogic.AddPlayBall(mouseX, mouseY, vectorX, vectorY);

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            this.gameLogic.Width = this.pictureBox1.Width;
            this.gameLogic.Height = this.pictureBox1.Height;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Refresh();
        }

        private void friendlyFirecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gameLogic.friendlyFire = this.friendlyFirecheckBox.Checked;
        }

        private void DelBallAfterColisionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gameLogic.deleteAfterCollision = this.DelBallAfterCollisionCheckBox.Checked;
        }
    }
}