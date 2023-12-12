namespace BookingSystemUI
{
    partial class HotelUI
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
            hotelPanel = new Panel();
            btnNext = new Button();
            label2 = new Label();
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
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(976, 17);
            label3.TabIndex = 9;
            label3.Text = "Book a hotel here by searching for the neccessary information, however be sure to fill out all the boxes, since the program will not continue without all the information";
            // 
            // hotelPanel
            // 
            hotelPanel.Location = new Point(12, 230);
            hotelPanel.Name = "hotelPanel";
            hotelPanel.Size = new Size(980, 340);
            hotelPanel.TabIndex = 16;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(447, 576);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(103, 23);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
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
            // lblSelectedCountry
            // 
            lblSelectedCountry.AutoSize = true;
            lblSelectedCountry.Location = new Point(12, 86);
            lblSelectedCountry.Name = "lblSelectedCountry";
            lblSelectedCountry.Size = new Size(107, 15);
            lblSelectedCountry.TabIndex = 20;
            lblSelectedCountry.Text = "lblSelectedCountry";
            // 
            // lblSelectedOrigin
            // 
            lblSelectedOrigin.AutoSize = true;
            lblSelectedOrigin.Location = new Point(12, 101);
            lblSelectedOrigin.Name = "lblSelectedOrigin";
            lblSelectedOrigin.Size = new Size(97, 15);
            lblSelectedOrigin.TabIndex = 21;
            lblSelectedOrigin.Text = "lblSelectedOrigin";
            // 
            // lblSelectedDepartureDate
            // 
            lblSelectedDepartureDate.AutoSize = true;
            lblSelectedDepartureDate.Location = new Point(10, 116);
            lblSelectedDepartureDate.Name = "lblSelectedDepartureDate";
            lblSelectedDepartureDate.Size = new Size(140, 15);
            lblSelectedDepartureDate.TabIndex = 22;
            lblSelectedDepartureDate.Text = "lblSelectedDepartureDate";
            // 
            // lblSelectedReturnDate
            // 
            lblSelectedReturnDate.AutoSize = true;
            lblSelectedReturnDate.Location = new Point(10, 131);
            lblSelectedReturnDate.Name = "lblSelectedReturnDate";
            lblSelectedReturnDate.Size = new Size(123, 15);
            lblSelectedReturnDate.TabIndex = 23;
            lblSelectedReturnDate.Text = "lblSelectedReturnDate";
            // 
            // lblCountryID
            // 
            lblCountryID.AutoSize = true;
            lblCountryID.Location = new Point(192, 86);
            lblCountryID.Name = "lblCountryID";
            lblCountryID.Size = new Size(74, 15);
            lblCountryID.TabIndex = 24;
            lblCountryID.Text = "lblCountryID";
            // 
            // lblOriginID
            // 
            lblOriginID.AutoSize = true;
            lblOriginID.Location = new Point(192, 101);
            lblOriginID.Name = "lblOriginID";
            lblOriginID.Size = new Size(64, 15);
            lblOriginID.TabIndex = 25;
            lblOriginID.Text = "lblOriginID";
            // 
            // HotelUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(lblOriginID);
            Controls.Add(lblCountryID);
            Controls.Add(lblSelectedReturnDate);
            Controls.Add(lblSelectedDepartureDate);
            Controls.Add(lblSelectedOrigin);
            Controls.Add(lblSelectedCountry);
            Controls.Add(btnNext);
            Controls.Add(hotelPanel);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HotelUI";
            Text = "Hotel";
            Load += Hotel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel hotelPanel;
        private Button btnNext;
        private Label label2;
        private Label lblSelectedCountry;
        private Label lblSelectedOrigin;
        private Label lblSelectedDepartureDate;
        private Label lblSelectedReturnDate;
        private Label lblCountryID;
        private Label lblOriginID;
    }
}