namespace BookingSystemUI
{
    partial class MainMenu
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
            MainPanel = new Panel();
            Exit = new Button();
            Startbooking = new Button();
            HotelBooking = new Button();
            CarBooking = new Button();
            InsuranceBooking = new Button();
            Basket = new Button();
            Mainbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(493, 5);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Scuffed holidays";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.Location = new Point(142, 40);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1050, 650);
            MainPanel.TabIndex = 1;
            // 
            // Exit
            // 
            Exit.Location = new Point(12, 574);
            Exit.Name = "Exit";
            Exit.Size = new Size(116, 83);
            Exit.TabIndex = 2;
            Exit.Text = "Quit application";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Startbooking
            // 
            Startbooking.Location = new Point(12, 40);
            Startbooking.Name = "Startbooking";
            Startbooking.Size = new Size(116, 83);
            Startbooking.TabIndex = 0;
            Startbooking.Text = "Flight booking";
            Startbooking.UseVisualStyleBackColor = true;
            Startbooking.Click += Startbooking_Click;
            // 
            // HotelBooking
            // 
            HotelBooking.Location = new Point(12, 129);
            HotelBooking.Name = "HotelBooking";
            HotelBooking.Size = new Size(116, 83);
            HotelBooking.TabIndex = 3;
            HotelBooking.Text = "Hotel booking";
            HotelBooking.UseVisualStyleBackColor = true;
            HotelBooking.Click += HotelBooking_Click;
            // 
            // CarBooking
            // 
            CarBooking.Location = new Point(12, 218);
            CarBooking.Name = "CarBooking";
            CarBooking.Size = new Size(116, 83);
            CarBooking.TabIndex = 4;
            CarBooking.Text = "Car rental";
            CarBooking.UseVisualStyleBackColor = true;
            CarBooking.Click += CarBooking_Click;
            // 
            // InsuranceBooking
            // 
            InsuranceBooking.Location = new Point(12, 307);
            InsuranceBooking.Name = "InsuranceBooking";
            InsuranceBooking.Size = new Size(116, 83);
            InsuranceBooking.TabIndex = 5;
            InsuranceBooking.Text = "Insurance";
            InsuranceBooking.UseVisualStyleBackColor = true;
            InsuranceBooking.Click += InsuranceBooking_Click;
            // 
            // Basket
            // 
            Basket.Location = new Point(12, 396);
            Basket.Name = "Basket";
            Basket.Size = new Size(116, 83);
            Basket.TabIndex = 6;
            Basket.Text = "Basket";
            Basket.UseVisualStyleBackColor = true;
            Basket.Click += Basket_Click;
            // 
            // Mainbutton
            // 
            Mainbutton.Location = new Point(12, 485);
            Mainbutton.Name = "Mainbutton";
            Mainbutton.Size = new Size(116, 83);
            Mainbutton.TabIndex = 7;
            Mainbutton.Text = "Main menu";
            Mainbutton.UseVisualStyleBackColor = true;
            Mainbutton.Click += Mainbutton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(Mainbutton);
            Controls.Add(Basket);
            Controls.Add(InsuranceBooking);
            Controls.Add(Exit);
            Controls.Add(CarBooking);
            Controls.Add(HotelBooking);
            Controls.Add(MainPanel);
            Controls.Add(label1);
            Controls.Add(Startbooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel MainPanel;
        private Button Exit;
        private Button Startbooking;
        private Button HotelBooking;
        private Button CarBooking;
        private Button InsuranceBooking;
        private Button Basket;
        private Button Mainbutton;
    }
}