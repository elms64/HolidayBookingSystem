namespace BookingSystemUI
{
    partial class NoticeFlight
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
            YesFlight = new Button();
            NoFlight = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // YesFlight
            // 
            YesFlight.Location = new Point(208, 354);
            YesFlight.Name = "YesFlight";
            YesFlight.Size = new Size(208, 97);
            YesFlight.TabIndex = 0;
            YesFlight.Text = "Yes";
            YesFlight.UseVisualStyleBackColor = true;
            YesFlight.Click += YesFlight_Click;
            // 
            // NoFlight
            // 
            NoFlight.Location = new Point(593, 354);
            NoFlight.Name = "NoFlight";
            NoFlight.Size = new Size(208, 97);
            NoFlight.TabIndex = 1;
            NoFlight.Text = "No";
            NoFlight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(367, 145);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 2;
            label1.Text = "Do you need to book a flight";
            // 
            // NoticeFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 611);
            Controls.Add(label1);
            Controls.Add(NoFlight);
            Controls.Add(YesFlight);
            Name = "NoticeFlight";
            Text = "NoticeFlight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button YesFlight;
        private Button NoFlight;
        private Label label1;
    }
}