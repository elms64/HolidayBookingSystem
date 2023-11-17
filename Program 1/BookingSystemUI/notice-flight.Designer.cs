namespace BookingSystemUI
{
    partial class notice
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
            label2 = new Label();
            SelectFlight = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(315, 30);
            label2.TabIndex = 9;
            label2.Text = "Do your need to book a flight?";
            label2.Click += label2_Click;
            // 
            // SelectFlight
            // 
            SelectFlight.Location = new Point(212, 87);
            SelectFlight.Name = "SelectFlight";
            SelectFlight.Size = new Size(103, 23);
            SelectFlight.TabIndex = 18;
            SelectFlight.Text = "NO";
            SelectFlight.UseVisualStyleBackColor = true;
            SelectFlight.Click += SelectFlight_Click;
            // 
            // button1
            // 
            button1.Location = new Point(30, 87);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 19;
            button1.Text = "YES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // notice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 128);
            Controls.Add(button1);
            Controls.Add(SelectFlight);
            Controls.Add(label2);
            Name = "notice";
            Text = "notice";
            Load += notice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button SelectFlight;
        private Button button1;
    }
}