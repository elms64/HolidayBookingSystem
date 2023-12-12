namespace BookingSystemUI.UI
{
    partial class FlightUI
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
            flightPanel = new Panel();
            label2 = new Label();
            nxtBtn = new Button();
            SuspendLayout();
            // 
            // flightPanel
            // 
            flightPanel.Location = new Point(95, 244);
            flightPanel.Name = "flightPanel";
            flightPanel.Size = new Size(898, 302);
            flightPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(436, 119);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 3;
            label2.Text = "Select Flights";
            label2.Click += label2_Click;
            // 
            // nxtBtn
            // 
            nxtBtn.Location = new Point(484, 565);
            nxtBtn.Name = "nxtBtn";
            nxtBtn.Size = new Size(75, 23);
            nxtBtn.TabIndex = 4;
            nxtBtn.Text = "Next";
            nxtBtn.UseVisualStyleBackColor = true;
            nxtBtn.Click += nxtBtn_Click;
            // 
            // FlightUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(nxtBtn);
            Controls.Add(label2);
            Controls.Add(flightPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightUI";
            Text = "SelectFlightUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel flightPanel;
        private Label label2;
        private Button nxtBtn;
    }
}