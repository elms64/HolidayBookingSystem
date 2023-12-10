namespace BookingSystemUI.UI
{
    partial class SelectFlightUI
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
            panel1 = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(95, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 302);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(416, 105);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 3;
            label2.Text = "Select Airports";
            // 
            // SelectFlightUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectFlightUI";
            Text = "SelectFlightUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
    }
}