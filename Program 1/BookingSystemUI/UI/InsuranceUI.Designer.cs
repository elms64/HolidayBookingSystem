namespace BookingSystemUI
{
    partial class InsuranceUI
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
            insurancePanel = new Panel();
            label4 = new Label();
            InsuranceType = new ComboBox();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Location = new Point(504, 615);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(425, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 1;
            label1.Text = "Insurance booking";
            // 
            // InsuranceStart
            // 
            InsuranceStart.Location = new Point(292, 131);
            InsuranceStart.Name = "InsuranceStart";
            InsuranceStart.Size = new Size(200, 23);
            InsuranceStart.TabIndex = 2;
            // 
            // InsuranceEnd
            // 
            InsuranceEnd.Location = new Point(562, 131);
            InsuranceEnd.Name = "InsuranceEnd";
            InsuranceEnd.Size = new Size(200, 23);
            InsuranceEnd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 113);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 4;
            label2.Text = "Select a date when insurance starts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 113);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 5;
            label3.Text = "Select a date when insurance ends";
            // 
            // SeearchInsurance
            // 
            SeearchInsurance.Location = new Point(911, 131);
            SeearchInsurance.Name = "SeearchInsurance";
            SeearchInsurance.Size = new Size(108, 25);
            SeearchInsurance.TabIndex = 7;
            SeearchInsurance.Text = "Search insurance";
            SeearchInsurance.UseVisualStyleBackColor = true;
            SeearchInsurance.Click += SeearchInsurance_Click;
            // 
            // insurancePanel
            // 
            insurancePanel.Location = new Point(39, 226);
            insurancePanel.Name = "insurancePanel";
            insurancePanel.Size = new Size(980, 340);
            insurancePanel.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 113);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 13;
            label4.Text = "Select the type of insurance";
            // 
            // InsuranceType
            // 
            InsuranceType.FormattingEnabled = true;
            InsuranceType.Location = new Point(39, 134);
            InsuranceType.Name = "InsuranceType";
            InsuranceType.Size = new Size(162, 23);
            InsuranceType.TabIndex = 14;
            InsuranceType.SelectedIndexChanged += InsuranceType_SelectedIndexChanged;
            // 
            // InsuranceUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(InsuranceType);
            Controls.Add(label4);
            Controls.Add(insurancePanel);
            Controls.Add(SeearchInsurance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InsuranceEnd);
            Controls.Add(InsuranceStart);
            Controls.Add(label1);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InsuranceUI";
            Text = "Insurance";
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
        private Panel insurancePanel;
        private Label label4;
        private ComboBox InsuranceType;
    }
}