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
            hotelPanel = new Panel();
            btnNext = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(850, 23);
            textBox1.TabIndex = 26;
            textBox1.Text = "Select a hotel to be purchased by the customer and press next to continue";
            // 
            // HotelUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(textBox1);
            Controls.Add(btnNext);
            Controls.Add(hotelPanel);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HotelUI";
            Text = "Hotel";
            Load += Hotel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel hotelPanel;
        private Button btnNext;
        private Label label2;
        private TextBox textBox1;
    }
}