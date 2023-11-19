namespace BookingSystemUI
{
    partial class CarRental
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
            label1 = new Label();
            RentCar = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(455, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Car renting";
            // 
            // RentCar
            // 
            RentCar.Location = new Point(476, 598);
            RentCar.Name = "RentCar";
            RentCar.Size = new Size(86, 40);
            RentCar.TabIndex = 1;
            RentCar.Text = "Confirm booking";
            RentCar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 130);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 3;
            label2.Text = "Search the car that is required";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(254, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 130);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 5;
            label3.Text = "Select the date of pickup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 130);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 6;
            label4.Text = "Select the date of dropoff";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(518, 148);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // CarRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(RentCar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarRental";
            Text = "CarRental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button RentCar;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
    }
}