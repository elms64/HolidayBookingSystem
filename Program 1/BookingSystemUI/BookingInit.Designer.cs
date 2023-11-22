namespace BookingSystemUI
{
    partial class BookingInit
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
            dateTimePickerStart = new DateTimePicker();
            label1 = new Label();
            comboBoxCountry = new ComboBox();
            lblCountry = new Label();
            txtBoxHowLong = new TextBox();
            lblDuration = new Label();
            lblReturnDate = new Label();
            lblReturnDateUpdate = new Label();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(293, 171);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 0;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 153);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "WHEN LEAVE";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(119, 171);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(121, 23);
            comboBoxCountry.TabIndex = 3;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(142, 153);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(77, 15);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "WHERE U GO";
            // 
            // txtBoxHowLong
            // 
            txtBoxHowLong.Location = new Point(549, 171);
            txtBoxHowLong.Name = "txtBoxHowLong";
            txtBoxHowLong.Size = new Size(100, 23);
            txtBoxHowLong.TabIndex = 5;
            txtBoxHowLong.TextChanged += txtBoxHowLong_TextChanged;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(561, 153);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(79, 15);
            lblDuration.TabIndex = 6;
            lblDuration.Text = "HOW LONG?!";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(745, 153);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(71, 15);
            lblReturnDate.TabIndex = 7;
            lblReturnDate.Text = "Return date ";
            // 
            // lblReturnDateUpdate
            // 
            lblReturnDateUpdate.AutoSize = true;
            lblReturnDateUpdate.Location = new Point(708, 177);
            lblReturnDateUpdate.Name = "lblReturnDateUpdate";
            lblReturnDateUpdate.Size = new Size(145, 15);
            lblReturnDateUpdate.TabIndex = 8;
            lblReturnDateUpdate.Text = "Updated Return Date Here";
            // 
            // BookingInit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1018, 572);
            Controls.Add(lblReturnDateUpdate);
            Controls.Add(lblReturnDate);
            Controls.Add(lblDuration);
            Controls.Add(txtBoxHowLong);
            Controls.Add(lblCountry);
            Controls.Add(comboBoxCountry);
            Controls.Add(label1);
            Controls.Add(dateTimePickerStart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingInit";
            Text = "BookingInit";
            Load += BookingInit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private Label label1;
        private ComboBox comboBoxCountry;
        private Label lblCountry;
        private TextBox txtBoxHowLong;
        private Label lblDuration;
        private Label lblReturnDate;
        private Label lblReturnDateUpdate;
    }
}