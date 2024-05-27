namespace The_cat_is_running
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Background2 = new System.Windows.Forms.PictureBox();
            this.Cat = new System.Windows.Forms.PictureBox();
            this.TimerBackground = new System.Windows.Forms.Timer(this.components);
            this.Background1 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.TimerDog = new System.Windows.Forms.Timer(this.components);
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.TimerСonflict = new System.Windows.Forms.Timer(this.components);
            this.LabelLose = new System.Windows.Forms.Label();
            this.ButtonRestart = new System.Windows.Forms.Button();
            this.FishCoin = new System.Windows.Forms.PictureBox();
            this.TimerFishCoin = new System.Windows.Forms.Timer(this.components);
            this.LableCountFishCoin = new System.Windows.Forms.Label();
            this.TimerCountFishCoin = new System.Windows.Forms.Timer(this.components);
            this.TimerAcceleration = new System.Windows.Forms.Timer(this.components);
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelWin = new System.Windows.Forms.Label();
            this.LabelVelocity = new System.Windows.Forms.Label();
            this.TimerVelocity = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FishCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // Background2
            // 
            this.Background2.Image = ((System.Drawing.Image)(resources.GetObject("Background2.Image")));
            this.Background2.Location = new System.Drawing.Point(0, -1024);
            this.Background2.Name = "Background2";
            this.Background2.Size = new System.Drawing.Size(1444, 1024);
            this.Background2.TabIndex = 0;
            this.Background2.TabStop = false;
            // 
            // Cat
            // 
            this.Cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.Cat.Image = ((System.Drawing.Image)(resources.GetObject("Cat.Image")));
            this.Cat.Location = new System.Drawing.Point(747, 845);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(115, 179);
            this.Cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cat.TabIndex = 1;
            this.Cat.TabStop = false;
            // 
            // TimerBackground
            // 
            this.TimerBackground.Enabled = true;
            this.TimerBackground.Interval = 10;
            this.TimerBackground.Tick += new System.EventHandler(this.TimerBackground_Tick);
            // 
            // Background1
            // 
            this.Background1.Image = ((System.Drawing.Image)(resources.GetObject("Background1.Image")));
            this.Background1.Location = new System.Drawing.Point(0, 0);
            this.Background1.Name = "Background1";
            this.Background1.Size = new System.Drawing.Size(1444, 1024);
            this.Background1.TabIndex = 2;
            this.Background1.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(575, -230);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(126, 185);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog1.TabIndex = 3;
            this.Dog1.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(745, -430);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(126, 185);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog2.TabIndex = 4;
            this.Dog2.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(910, -630);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(126, 185);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog3.TabIndex = 5;
            this.Dog3.TabStop = false;
            // 
            // TimerDog
            // 
            this.TimerDog.Enabled = true;
            this.TimerDog.Interval = 10;
            this.TimerDog.Tick += new System.EventHandler(this.TimerDog_Tick);
            // 
            // Dog4
            // 
            this.Dog4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(745, -840);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(126, 185);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog4.TabIndex = 6;
            this.Dog4.TabStop = false;
            // 
            // TimerСonflict
            // 
            this.TimerСonflict.Enabled = true;
            this.TimerСonflict.Interval = 10;
            this.TimerСonflict.Tick += new System.EventHandler(this.TimerСonflict_Tick);
            // 
            // LabelLose
            // 
            this.LabelLose.AutoSize = true;
            this.LabelLose.BackColor = System.Drawing.Color.Red;
            this.LabelLose.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelLose.ImageKey = "(отсутствует)";
            this.LabelLose.Location = new System.Drawing.Point(620, 384);
            this.LabelLose.Name = "LabelLose";
            this.LabelLose.Size = new System.Drawing.Size(228, 61);
            this.LabelLose.TabIndex = 8;
            this.LabelLose.Text = "You Lose";
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRestart.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRestart.Location = new System.Drawing.Point(662, 472);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(147, 44);
            this.ButtonRestart.TabIndex = 8;
            this.ButtonRestart.Text = "Restart";
            this.ButtonRestart.UseVisualStyleBackColor = false;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // FishCoin
            // 
            this.FishCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.FishCoin.Image = ((System.Drawing.Image)(resources.GetObject("FishCoin.Image")));
            this.FishCoin.Location = new System.Drawing.Point(772, -500);
            this.FishCoin.Name = "FishCoin";
            this.FishCoin.Size = new System.Drawing.Size(61, 55);
            this.FishCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FishCoin.TabIndex = 9;
            this.FishCoin.TabStop = false;
            // 
            // TimerFishCoin
            // 
            this.TimerFishCoin.Enabled = true;
            this.TimerFishCoin.Interval = 10;
            this.TimerFishCoin.Tick += new System.EventHandler(this.TimerFishCoin_Tick);
            // 
            // LableCountFishCoin
            // 
            this.LableCountFishCoin.AutoSize = true;
            this.LableCountFishCoin.BackColor = System.Drawing.Color.Red;
            this.LableCountFishCoin.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableCountFishCoin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LableCountFishCoin.ImageKey = "(отсутствует)";
            this.LableCountFishCoin.Location = new System.Drawing.Point(12, 37);
            this.LableCountFishCoin.Name = "LableCountFishCoin";
            this.LableCountFishCoin.Size = new System.Drawing.Size(112, 37);
            this.LableCountFishCoin.TabIndex = 10;
            this.LableCountFishCoin.Text = "Coin: 0";
            // 
            // TimerCountFishCoin
            // 
            this.TimerCountFishCoin.Enabled = true;
            this.TimerCountFishCoin.Interval = 10;
            this.TimerCountFishCoin.Tick += new System.EventHandler(this.TimerCountFishCoin_Tick);
            // 
            // TimerAcceleration
            // 
            this.TimerAcceleration.Enabled = true;
            this.TimerAcceleration.Interval = 15000;
            this.TimerAcceleration.Tick += new System.EventHandler(this.Acceleration_Tick);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(662, 384);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(147, 44);
            this.ButtonStart.TabIndex = 11;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelWin
            // 
            this.LabelWin.AutoSize = true;
            this.LabelWin.BackColor = System.Drawing.Color.Red;
            this.LabelWin.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelWin.ImageKey = "(отсутствует)";
            this.LabelWin.Location = new System.Drawing.Point(630, 384);
            this.LabelWin.Name = "LabelWin";
            this.LabelWin.Size = new System.Drawing.Size(218, 61);
            this.LabelWin.TabIndex = 12;
            this.LabelWin.Text = "You Win";
            // 
            // LabelVelocity
            // 
            this.LabelVelocity.AutoSize = true;
            this.LabelVelocity.BackColor = System.Drawing.Color.Red;
            this.LabelVelocity.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVelocity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelVelocity.ImageKey = "(отсутствует)";
            this.LabelVelocity.Location = new System.Drawing.Point(12, 88);
            this.LabelVelocity.Name = "LabelVelocity";
            this.LabelVelocity.Size = new System.Drawing.Size(160, 37);
            this.LabelVelocity.TabIndex = 13;
            this.LabelVelocity.Text = "Velocity: 4";
            // 
            // TimerVelocity
            // 
            this.TimerVelocity.Enabled = true;
            this.TimerVelocity.Interval = 10;
            this.TimerVelocity.Tick += new System.EventHandler(this.TimerVelocity_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 1024);
            this.Controls.Add(this.LabelVelocity);
            this.Controls.Add(this.LabelWin);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LableCountFishCoin);
            this.Controls.Add(this.FishCoin);
            this.Controls.Add(this.ButtonRestart);
            this.Controls.Add(this.LabelLose);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.Background2);
            this.Controls.Add(this.Background1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FishCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Background2;
        private System.Windows.Forms.PictureBox Cat;
        private System.Windows.Forms.Timer TimerBackground;
        private System.Windows.Forms.PictureBox Background1;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.Timer TimerDog;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.Timer TimerСonflict;
        private System.Windows.Forms.Label LabelLose;
        private System.Windows.Forms.Button ButtonRestart;
        private System.Windows.Forms.PictureBox FishCoin;
        private System.Windows.Forms.Timer TimerFishCoin;
        private System.Windows.Forms.Label LableCountFishCoin;
        private System.Windows.Forms.Timer TimerCountFishCoin;
        private System.Windows.Forms.Timer TimerAcceleration;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelWin;
        private System.Windows.Forms.Label LabelVelocity;
        private System.Windows.Forms.Timer TimerVelocity;
    }
}

