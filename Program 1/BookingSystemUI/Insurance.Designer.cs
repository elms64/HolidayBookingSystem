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
            btnNext = new Button();
            label1 = new Label();
            InsuranceStart = new DateTimePicker();
            InsuranceEnd = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SeearchInsurance = new Button();
            FlightPanel = new Panel();
            label4 = new Label();
            InsuranceType = new ComboBox();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Location = new Point(576, 820);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(486, 12);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 1;
            label1.Text = "Insurance booking";
            // 
            // InsuranceStart
            // 
            InsuranceStart.Location = new Point(334, 175);
            InsuranceStart.Margin = new Padding(3, 4, 3, 4);
            InsuranceStart.Name = "InsuranceStart";
            InsuranceStart.Size = new Size(228, 27);
            InsuranceStart.TabIndex = 2;
            // 
            // InsuranceEnd
            // 
            InsuranceEnd.Location = new Point(642, 175);
            InsuranceEnd.Margin = new Padding(3, 4, 3, 4);
            InsuranceEnd.Name = "InsuranceEnd";
            InsuranceEnd.Size = new Size(228, 27);
            InsuranceEnd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 151);
            label2.Name = "label2";
            label2.Size = new Size(239, 20);
            label2.TabIndex = 4;
            label2.Text = "Select a date when insurance starts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 151);
            label3.Name = "label3";
            label3.Size = new Size(235, 20);
            label3.TabIndex = 5;
            label3.Text = "Select a date when insurance ends";
            // 
            // SeearchInsurance
            // 
            SeearchInsurance.Location = new Point(1041, 175);
            SeearchInsurance.Margin = new Padding(3, 4, 3, 4);
            SeearchInsurance.Name = "SeearchInsurance";
            SeearchInsurance.Size = new Size(123, 33);
            SeearchInsurance.TabIndex = 7;
            SeearchInsurance.Text = "Search insurance";
            SeearchInsurance.UseVisualStyleBackColor = true;
            SeearchInsurance.Click += SeearchInsurance_Click;
            // 
            // FlightPanel
            // 
            FlightPanel.Location = new Point(45, 301);
            FlightPanel.Margin = new Padding(3, 4, 3, 4);
            FlightPanel.Name = "FlightPanel";
            FlightPanel.Size = new Size(1120, 453);
            FlightPanel.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 151);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 13;
            label4.Text = "Select the type of insurance";
            // 
            // InsuranceType
            // 
            InsuranceType.FormattingEnabled = true;
            InsuranceType.Location = new Point(45, 179);
            InsuranceType.Margin = new Padding(3, 4, 3, 4);
            InsuranceType.Name = "InsuranceType";
            InsuranceType.Size = new Size(185, 28);
            InsuranceType.TabIndex = 14;
            InsuranceType.SelectedIndexChanged += InsuranceType_SelectedIndexChanged;
            // 
            // Insurance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 867);
            Controls.Add(InsuranceType);
            Controls.Add(label4);
            Controls.Add(FlightPanel);
            Controls.Add(SeearchInsurance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InsuranceEnd);
            Controls.Add(InsuranceStart);
            Controls.Add(label1);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Insurance";
            Text = "Insurance";
            Load += Insurance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Label label1;
        private DateTimePicker InsuranceStart;
        private DateTimePicker InsuranceEnd;
        private Label label2;
        private Label label3;
        private Button SeearchInsurance;
        private Panel FlightPanel;
        private Label label4;
        private ComboBox InsuranceType;
    }
}