namespace BookingSystemUI
{
    partial class BookingUI
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
            btnNext = new Button();
            lblOrigin = new Label();
            comboBoxOrigin = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnSajan = new Button();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(395, 171);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 0;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 153);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "WHEN LEAVE";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(76, 169);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(121, 23);
            comboBoxCountry.TabIndex = 3;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(97, 153);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(77, 15);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "WHERE U GO";
            // 
            // txtBoxHowLong
            // 
            txtBoxHowLong.Location = new Point(651, 171);
            txtBoxHowLong.Name = "txtBoxHowLong";
            txtBoxHowLong.Size = new Size(100, 23);
            txtBoxHowLong.TabIndex = 5;
            txtBoxHowLong.TextChanged += txtBoxHowLong_TextChanged;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(651, 153);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(83, 15);
            lblDuration.TabIndex = 6;
            lblDuration.Text = "WHEN BACK?!";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(847, 153);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(71, 15);
            lblReturnDate.TabIndex = 7;
            lblReturnDate.Text = "Return date ";
            // 
            // lblReturnDateUpdate
            // 
            lblReturnDateUpdate.AutoSize = true;
            lblReturnDateUpdate.Location = new Point(810, 177);
            lblReturnDateUpdate.Name = "lblReturnDateUpdate";
            lblReturnDateUpdate.Size = new Size(145, 15);
            lblReturnDateUpdate.TabIndex = 8;
            lblReturnDateUpdate.Text = "Updated Return Date Here";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(446, 358);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(109, 34);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new Point(258, 153);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(85, 15);
            lblOrigin.TabIndex = 11;
            lblOrigin.Text = "WHERE FROM!";
            // 
            // comboBoxOrigin
            // 
            comboBoxOrigin.FormattingEnabled = true;
            comboBoxOrigin.Location = new Point(237, 169);
            comboBoxOrigin.Name = "comboBoxOrigin";
            comboBoxOrigin.Size = new Size(121, 23);
            comboBoxOrigin.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 80);
            label2.Name = "label2";
            label2.Size = new Size(352, 15);
            label2.TabIndex = 12;
            label2.Text = "This replaces the need to enter the dates and locations every page";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 95);
            label3.Name = "label3";
            label3.Size = new Size(224, 15);
            label3.TabIndex = 13;
            label3.Text = "just pass the variables onto the next form";
            // 
            // btnSajan
            // 
            btnSajan.Location = new Point(46, 512);
            btnSajan.Name = "btnSajan";
            btnSajan.Size = new Size(75, 23);
            btnSajan.TabIndex = 14;
            btnSajan.Text = "Sajan";
            btnSajan.UseVisualStyleBackColor = true;
            btnSajan.Click += btnSajan_Click;
            // 
            // BookingInit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1018, 572);
            Controls.Add(btnSajan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblOrigin);
            Controls.Add(comboBoxOrigin);
            Controls.Add(btnNext);
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
        private Button btnNext;
        private Label lblOrigin;
        private ComboBox comboBoxOrigin;
        private Label label2;
        private Label label3;
        private Button btnSajan;
    }
}