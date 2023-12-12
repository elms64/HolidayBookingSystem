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
            insurancePanel = new Panel();
            textBox1 = new TextBox();
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
            label1.Location = new Point(412, 83);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 1;
            label1.Text = "Insurance booking";
            // 
            // insurancePanel
            // 
            insurancePanel.Location = new Point(39, 226);
            insurancePanel.Name = "insurancePanel";
            insurancePanel.Size = new Size(980, 340);
            insurancePanel.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(850, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "Select an Insurance to be purchased by the customer and press next to continue";
            // 
            // InsuranceUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(textBox1);
            Controls.Add(insurancePanel);
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
        private Panel insurancePanel;
        private TextBox textBox1;
    }
}