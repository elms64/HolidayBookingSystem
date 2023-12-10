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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // InvoiceBasket
            // 
            InvoiceBasket.Location = new Point(547, 820);
            InvoiceBasket.Margin = new Padding(3, 4, 3, 4);
            InvoiceBasket.Name = "InvoiceBasket";
            InvoiceBasket.Size = new Size(86, 31);
            InvoiceBasket.TabIndex = 0;
            InvoiceBasket.Text = "Invoice";
            InvoiceBasket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(527, 12);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 1;
            label1.Text = "Basket";
            // 
            // panel1
            // 
            panel1.Location = new Point(89, 165);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 535);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(339, 165);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 535);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(593, 165);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 535);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(848, 165);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 535);
            panel4.TabIndex = 3;
            // 
            // MainBasket
            // 
            MainBasket.Location = new Point(1101, 820);
            MainBasket.Margin = new Padding(3, 4, 3, 4);
            MainBasket.Name = "MainBasket";
            MainBasket.Size = new Size(86, 31);
            MainBasket.TabIndex = 4;
            MainBasket.Text = "Main menu";
            MainBasket.UseVisualStyleBackColor = true;
            MainBasket.Click += MainBasket_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 141);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Flight info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 141);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Hotel info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(597, 141);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Car info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(848, 141);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 8;
            label5.Text = "Insurance info";
            // 
            // Basket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 867);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MainBasket);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(InvoiceBasket);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Basket";
            Text = "Basket";
            Load += Basket_Load;
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}