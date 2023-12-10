namespace BookingSystemUI
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            loadingbar = new Panel();
            loading = new Panel();
            pictureBox1 = new PictureBox();
            loadingTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loadingbar
            // 
            loadingbar.BackColor = Color.FromArgb(46, 51, 73);
            loadingbar.Dock = DockStyle.Bottom;
            loadingbar.Location = new Point(0, 325);
            loadingbar.Name = "loadingbar";
            loadingbar.Size = new Size(700, 75);
            loadingbar.TabIndex = 0;
            // 
            // loading
            // 
            loading.BackColor = Color.White;
            loading.Controls.Add(pictureBox1);
            loading.Location = new Point(0, 325);
            loading.Name = "loading";
            loading.Size = new Size(99, 75);
            loading.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.Plane_gif;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // loadingTimer
            // 
            loadingTimer.Enabled = true;
            loadingTimer.Interval = 1;
            loadingTimer.Tick += loadingTimer_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BBB_Logo;
            pictureBox2.Location = new Point(245, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(700, 400);
            Controls.Add(pictureBox2);
            Controls.Add(loading);
            Controls.Add(loadingbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            loading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loadingbar;
        private Panel loading;
        private System.Windows.Forms.Timer loadingTimer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}