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
            btnNext = new Button();
            label2 = new Label();
            SearchHotel = new Button();
            comboBox1 = new ComboBox();
            lblSelectedCountry = new Label();
            lblSelectedOrigin = new Label();
            lblSelectedDepartureDate = new Label();
            lblSelectedReturnDate = new Label();
            lblCountryID = new Label();
            lblOriginID = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 52);
            label3.Name = "label3";
            label3.Size = new Size(1280, 23);
            label3.TabIndex = 9;
            label3.Text = "Book a hotel here by searching for the neccessary information, however be sure to fill out all the boxes, since the program will not continue without all the information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 233);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 7;
            label1.Text = "Desrtination or hotel";
            // 
            // panel1
            // 
            panel1.Location = new Point(14, 307);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 453);
            panel1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(782, 209);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 15;
            label6.Text = "Check out";
            // 
            // CheckOutDate
            // 
            CheckOutDate.Location = new Point(782, 259);
            CheckOutDate.Margin = new Padding(3, 4, 3, 4);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new Size(228, 27);
            CheckOutDate.TabIndex = 14;
            CheckOutDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 209);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 13;
            label5.Text = "Check in";
            // 
            // CheckInDate
            // 
            CheckInDate.Location = new Point(511, 259);
            CheckInDate.Margin = new Padding(3, 4, 3, 4);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Size = new Size(228, 27);
            CheckInDate.TabIndex = 12;
            CheckInDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(511, 768);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(118, 31);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(398, 12);
            label2.Name = "label2";
            label2.Size = new Size(262, 37);
            label2.TabIndex = 8;
            label2.Text = "Searching for hotel";
            // 
            // SearchHotel
            // 
            SearchHotel.Location = new Point(1022, 259);
            SearchHotel.Margin = new Padding(3, 4, 3, 4);
            SearchHotel.Name = "SearchHotel";
            SearchHotel.Size = new Size(118, 31);
            SearchHotel.TabIndex = 18;
            SearchHotel.Text = "Search hotels";
            SearchHotel.UseVisualStyleBackColor = true;
            SearchHotel.Click += SearchHotel_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 261);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 28);
            comboBox1.TabIndex = 19;
            // 
            // lblSelectedCountry
            // 
            lblSelectedCountry.AutoSize = true;
            lblSelectedCountry.Location = new Point(14, 115);
            lblSelectedCountry.Name = "lblSelectedCountry";
            lblSelectedCountry.Size = new Size(134, 20);
            lblSelectedCountry.TabIndex = 20;
            lblSelectedCountry.Text = "lblSelectedCountry";
            // 
            // lblSelectedOrigin
            // 
            lblSelectedOrigin.AutoSize = true;
            lblSelectedOrigin.Location = new Point(14, 135);
            lblSelectedOrigin.Name = "lblSelectedOrigin";
            lblSelectedOrigin.Size = new Size(124, 20);
            lblSelectedOrigin.TabIndex = 21;
            lblSelectedOrigin.Text = "lblSelectedOrigin";
            // 
            // lblSelectedDepartureDate
            // 
            lblSelectedDepartureDate.AutoSize = true;
            lblSelectedDepartureDate.Location = new Point(12, 155);
            lblSelectedDepartureDate.Name = "lblSelectedDepartureDate";
            lblSelectedDepartureDate.Size = new Size(182, 20);
            lblSelectedDepartureDate.TabIndex = 22;
            lblSelectedDepartureDate.Text = "lblSelectedDepartureDate";
            // 
            // lblSelectedReturnDate
            // 
            lblSelectedReturnDate.AutoSize = true;
            lblSelectedReturnDate.Location = new Point(12, 175);
            lblSelectedReturnDate.Name = "lblSelectedReturnDate";
            lblSelectedReturnDate.Size = new Size(158, 20);
            lblSelectedReturnDate.TabIndex = 23;
            lblSelectedReturnDate.Text = "lblSelectedReturnDate";
            // 
            // lblCountryID
            // 
            lblCountryID.AutoSize = true;
            lblCountryID.Location = new Point(219, 115);
            lblCountryID.Name = "lblCountryID";
            lblCountryID.Size = new Size(92, 20);
            lblCountryID.TabIndex = 24;
            lblCountryID.Text = "lblCountryID";
            // 
            // lblOriginID
            // 
            lblOriginID.AutoSize = true;
            lblOriginID.Location = new Point(219, 135);
            lblOriginID.Name = "lblOriginID";
            lblOriginID.Size = new Size(82, 20);
            lblOriginID.TabIndex = 25;
            lblOriginID.Text = "lblOriginID";
            // 
            // Hotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1182, 815);
            Controls.Add(lblOriginID);
            Controls.Add(lblCountryID);
            Controls.Add(lblSelectedReturnDate);
            Controls.Add(lblSelectedDepartureDate);
            Controls.Add(lblSelectedOrigin);
            Controls.Add(lblSelectedCountry);
            Controls.Add(comboBox1);
            Controls.Add(SearchHotel);
            Controls.Add(btnNext);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(CheckOutDate);
            Controls.Add(label5);
            Controls.Add(CheckInDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnNext;
        private Label label2;
        private Button SearchHotel;
        private ComboBox comboBox1;
        private Label lblSelectedCountry;
        private Label lblSelectedOrigin;
        private Label lblSelectedDepartureDate;
        private Label lblSelectedReturnDate;
        private Label lblCountryID;
        private Label lblOriginID;
    }
}