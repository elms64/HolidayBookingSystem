namespace BookingSystemUI
{
    partial class Insurance
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
            InsuranceBooking = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // InsuranceBooking
            // 
            InsuranceBooking.Location = new Point(475, 615);
            InsuranceBooking.Name = "InsuranceBooking";
            InsuranceBooking.Size = new Size(75, 23);
            InsuranceBooking.TabIndex = 0;
            InsuranceBooking.Text = "Confirm insurance";
            InsuranceBooking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 1;
            label1.Text = "Insurance booking";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(406, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(406, 290);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 170);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 4;
            label2.Text = "Select a date when insurance starts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 272);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 5;
            label3.Text = "Select a date when insurance ends";
            // 
            // Insurance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(InsuranceBooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Insurance";
            Text = "Insurance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InsuranceBooking;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
    }
}