namespace BookingSystemUI
{
    partial class Hotel
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
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            CheckOutDate = new DateTimePicker();
            label5 = new Label();
            CheckInDate = new DateTimePicker();
            SelectFlight = new Button();
            label2 = new Label();
            SearchHotel = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            LBCountry = new Label();
            label7 = new Label();
            LBDepartureDate = new Label();
            label9 = new Label();
            LBReturnDate = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(976, 17);
            label3.TabIndex = 9;
            label3.Text = "Book a hotel here by searching for the neccessary information, however be sure to fill out all the boxes, since the program will not continue without all the information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 175);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 7;
            label1.Text = "Desrtination or hotel";
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 340);
            panel1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(684, 157);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 15;
            label6.Text = "Check out";
            // 
            // CheckOutDate
            // 
            CheckOutDate.Location = new Point(684, 194);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new Size(200, 23);
            CheckOutDate.TabIndex = 14;
            CheckOutDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 157);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 13;
            label5.Text = "Check in";
            // 
            // CheckInDate
            // 
            CheckInDate.Location = new Point(447, 194);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Size = new Size(200, 23);
            CheckInDate.TabIndex = 12;
            CheckInDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // SelectFlight
            // 
            SelectFlight.Location = new Point(447, 576);
            SelectFlight.Name = "SelectFlight";
            SelectFlight.Size = new Size(103, 23);
            SelectFlight.TabIndex = 17;
            SelectFlight.Text = "Select hotels";
            SelectFlight.UseVisualStyleBackColor = true;
            SelectFlight.Click += SelectFlight_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(348, 9);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 8;
            label2.Text = "Searching for hotel";
            // 
            // SearchHotel
            // 
            SearchHotel.Location = new Point(894, 194);
            SearchHotel.Name = "SearchHotel";
            SearchHotel.Size = new Size(103, 23);
            SearchHotel.TabIndex = 18;
            SearchHotel.Text = "Search hotels";
            SearchHotel.UseVisualStyleBackColor = true;
            SearchHotel.Click += SearchHotel_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 20;
            label4.Text = "Selected country:";
            // 
            // LBCountry
            // 
            LBCountry.AutoSize = true;
            LBCountry.Location = new Point(113, 86);
            LBCountry.Name = "LBCountry";
            LBCountry.Size = new Size(93, 15);
            LBCountry.TabIndex = 21;
            LBCountry.Text = "selectedCountry";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 86);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 22;
            label7.Text = "Departure Date";
            // 
            // LBDepartureDate
            // 
            LBDepartureDate.AutoSize = true;
            LBDepartureDate.Location = new Point(506, 86);
            LBDepartureDate.Name = "LBDepartureDate";
            LBDepartureDate.Size = new Size(126, 15);
            LBDepartureDate.TabIndex = 23;
            LBDepartureDate.Text = "selectedDepartureDate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(804, 86);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 24;
            label9.Text = "Return Date";
            // 
            // LBReturnDate
            // 
            LBReturnDate.AutoSize = true;
            LBReturnDate.Location = new Point(879, 86);
            LBReturnDate.Name = "LBReturnDate";
            LBReturnDate.Size = new Size(109, 15);
            LBReturnDate.TabIndex = 25;
            LBReturnDate.Text = "selectedReturnDate";
            // 
            // Hotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(LBReturnDate);
            Controls.Add(label9);
            Controls.Add(LBDepartureDate);
            Controls.Add(label7);
            Controls.Add(LBCountry);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(SearchHotel);
            Controls.Add(SelectFlight);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(CheckOutDate);
            Controls.Add(label5);
            Controls.Add(CheckInDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hotel";
            Text = "Hotel";
            Load += Hotel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private DateTimePicker CheckOutDate;
        private Label label5;
        private DateTimePicker CheckInDate;
        private Button SelectFlight;
        private Label label2;
        private Button SearchHotel;
        private ComboBox comboBox1;
        private Label label4;
        private Label LBCountry;
        private Label label7;
        private Label LBDepartureDate;
        private Label label9;
        private Label LBReturnDate;
    }
}