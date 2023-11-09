namespace BookingSystemUI
{
    partial class Form1
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
            flightBox = new ComboBox();
            label1 = new Label();
            refresh = new Button();
            SuspendLayout();
            // 
            // flightBox
            // 
            flightBox.FormattingEnabled = true;
            flightBox.Location = new Point(454, 287);
            flightBox.Name = "flightBox";
            flightBox.Size = new Size(642, 40);
            flightBox.TabIndex = 0;
            flightBox.SelectedIndexChanged += flightBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 231);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 1;
            label1.Text = "Check available flights:";
            // 
            // refresh
            // 
            refresh.Location = new Point(946, 371);
            refresh.Name = "refresh";
            refresh.Size = new Size(150, 46);
            refresh.TabIndex = 2;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1551, 721);
            Controls.Add(refresh);
            Controls.Add(label1);
            Controls.Add(flightBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox flightBox;
        private Label label1;
        private Button refresh;
    }
}