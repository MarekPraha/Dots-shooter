namespace DotsShooter
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            resetButton = new Button();
            startButton = new Button();
            stopButton = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            friendlyFirecheckBox = new CheckBox();
            DelBallAfterCollisionCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(962, 529);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            pictureBox1.Resize += pictureBox1_Resize;
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            resetButton.Location = new Point(174, 539);
            resetButton.Margin = new Padding(2, 2, 2, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(78, 20);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            startButton.Location = new Point(8, 539);
            startButton.Margin = new Padding(2, 2, 2, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(78, 20);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            stopButton.Location = new Point(91, 539);
            stopButton.Margin = new Padding(2, 2, 2, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(78, 20);
            stopButton.TabIndex = 3;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // friendlyFirecheckBox
            // 
            friendlyFirecheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            friendlyFirecheckBox.AutoSize = true;
            friendlyFirecheckBox.Checked = true;
            friendlyFirecheckBox.CheckState = CheckState.Checked;
            friendlyFirecheckBox.Location = new Point(884, 540);
            friendlyFirecheckBox.Margin = new Padding(2, 2, 2, 2);
            friendlyFirecheckBox.Name = "friendlyFirecheckBox";
            friendlyFirecheckBox.Size = new Size(87, 19);
            friendlyFirecheckBox.TabIndex = 4;
            friendlyFirecheckBox.Text = "FriendlyFire";
            friendlyFirecheckBox.UseVisualStyleBackColor = true;
            friendlyFirecheckBox.CheckedChanged += friendlyFirecheckBox_CheckedChanged;
            // 
            // DelBallAfterCollisionCheckBox
            // 
            DelBallAfterCollisionCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DelBallAfterCollisionCheckBox.AutoSize = true;
            DelBallAfterCollisionCheckBox.Checked = true;
            DelBallAfterCollisionCheckBox.CheckState = CheckState.Checked;
            DelBallAfterCollisionCheckBox.Location = new Point(717, 540);
            DelBallAfterCollisionCheckBox.Margin = new Padding(2, 2, 2, 2);
            DelBallAfterCollisionCheckBox.Name = "DelBallAfterCollisionCheckBox";
            DelBallAfterCollisionCheckBox.Size = new Size(160, 19);
            DelBallAfterCollisionCheckBox.TabIndex = 5;
            DelBallAfterCollisionCheckBox.Text = "Delete balls after collision";
            DelBallAfterCollisionCheckBox.UseVisualStyleBackColor = true;
            DelBallAfterCollisionCheckBox.CheckedChanged += DelBallAfterColisionCheckBox_CheckedChanged;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 567);
            Controls.Add(DelBallAfterCollisionCheckBox);
            Controls.Add(friendlyFirecheckBox);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(resetButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Game";
            Text = "DotsShooter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button resetButton;
        private Button startButton;
        private Button stopButton;
        private System.Windows.Forms.Timer timer2;
        private CheckBox friendlyFirecheckBox;
        private CheckBox DelBallAfterCollisionCheckBox;
    }
}