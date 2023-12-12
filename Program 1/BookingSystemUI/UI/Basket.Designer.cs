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
            flightPanelInfo = new Panel();
            hotelPanelInfo = new Panel();
            vehiclePanelInfo = new Panel();
            insurancePanelInfo = new Panel();
            MainBasket = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // InvoiceBasket
            // 
            InvoiceBasket.Location = new Point(479, 615);
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
            // flightPanelInfo
            // 
            flightPanelInfo.Location = new Point(78, 124);
            flightPanelInfo.Name = "flightPanelInfo";
            flightPanelInfo.Size = new Size(421, 179);
            flightPanelInfo.TabIndex = 2;
            // 
            // hotelPanelInfo
            // 
            hotelPanelInfo.Location = new Point(79, 375);
            hotelPanelInfo.Name = "hotelPanelInfo";
            hotelPanelInfo.Size = new Size(421, 179);
            hotelPanelInfo.TabIndex = 3;
            // 
            // vehiclePanelInfo
            // 
            vehiclePanelInfo.Location = new Point(547, 124);
            vehiclePanelInfo.Name = "vehiclePanelInfo";
            vehiclePanelInfo.Size = new Size(421, 179);
            vehiclePanelInfo.TabIndex = 3;
            // 
            // insurancePanelInfo
            // 
            insurancePanelInfo.Location = new Point(547, 375);
            insurancePanelInfo.Name = "insurancePanelInfo";
            insurancePanelInfo.Size = new Size(421, 179);
            insurancePanelInfo.TabIndex = 3;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 106);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Flight info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 337);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Hotel info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 106);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Car info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 337);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 8;
            label5.Text = "Insurance info";
            // 
            // Basket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MainBasket);
            Controls.Add(insurancePanelInfo);
            Controls.Add(vehiclePanelInfo);
            Controls.Add(hotelPanelInfo);
            Controls.Add(flightPanelInfo);
            Controls.Add(label1);
            Controls.Add(InvoiceBasket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Basket";
            Text = "Basket";
            Load += Basket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InvoiceBasket;
        private Label label1;
        private Panel flightPanelInfo;
        private Panel hotelPanelInfo;
        private Panel vehiclePanelInfo;
        private Panel insurancePanelInfo;
        private Button MainBasket;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}