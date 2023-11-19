namespace BookingSystemUI
{
    partial class ViewOrders
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
            MainMenuOrder = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SearchButton = new Button();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // MainMenuOrder
            // 
            MainMenuOrder.Location = new Point(888, 549);
            MainMenuOrder.Name = "MainMenuOrder";
            MainMenuOrder.Size = new Size(88, 34);
            MainMenuOrder.TabIndex = 0;
            MainMenuOrder.Text = "Main menu";
            MainMenuOrder.UseVisualStyleBackColor = true;
            MainMenuOrder.Click += MainMenuOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(397, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 1;
            label1.Text = "Search for orders";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 102);
            label2.Name = "label2";
            label2.Size = new Size(200, 15);
            label2.TabIndex = 3;
            label2.Text = "Search for customers phone number";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(397, 149);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(88, 34);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(509, 149);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(88, 34);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete record";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(DeleteButton);
            Controls.Add(SearchButton);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(MainMenuOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            Text = "ViewOrders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button MainMenuOrder;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button SearchButton;
        private Button DeleteButton;
    }
}