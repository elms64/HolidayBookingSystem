namespace BookingSystemUI
{
    partial class Basket
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
            InvoiceBasket = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            MainBasket = new Button();
            SuspendLayout();
            // 
            // InvoiceBasket
            // 
            InvoiceBasket.Location = new Point(463, 615);
            InvoiceBasket.Name = "InvoiceBasket";
            InvoiceBasket.Size = new Size(75, 23);
            InvoiceBasket.TabIndex = 0;
            InvoiceBasket.Text = "Invoice";
            InvoiceBasket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(461, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 1;
            label1.Text = "Basket";
            // 
            // panel1
            // 
            panel1.Location = new Point(91, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 401);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(297, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 401);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(503, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 401);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(709, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 401);
            panel4.TabIndex = 3;
            // 
            // MainBasket
            // 
            MainBasket.Location = new Point(963, 615);
            MainBasket.Name = "MainBasket";
            MainBasket.Size = new Size(75, 23);
            MainBasket.TabIndex = 4;
            MainBasket.Text = "Main menu";
            MainBasket.UseVisualStyleBackColor = true;
            MainBasket.Click += MainBasket_Click;
            // 
            // Basket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(MainBasket);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(InvoiceBasket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Basket";
            Text = "Basket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InvoiceBasket;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button MainBasket;
    }
}