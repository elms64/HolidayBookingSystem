namespace BookingSystemUI
{
    partial class VehicleUI
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
            btnNext = new Button();
            vehiclePanel = new Panel();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(439, 32);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Car renting";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(476, 601);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 37);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // vehiclePanel
            // 
            vehiclePanel.Location = new Point(36, 212);
            vehiclePanel.Name = "vehiclePanel";
            vehiclePanel.Size = new Size(980, 340);
            vehiclePanel.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(850, 23);
            textBox1.TabIndex = 14;
            textBox1.Text = "Select car to be purchased by the customer and press next to continue";
            // 
            // VehicleUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(textBox1);
            Controls.Add(vehiclePanel);
            Controls.Add(btnNext);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VehicleUI";
            Text = "Vehicle";
            Load += Vehicle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNext;
        private Panel vehiclePanel;
        private TextBox textBox1;
    }
}