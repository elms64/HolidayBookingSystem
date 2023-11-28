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
            btnBookingInit = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(669, 5);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Scuffed holidays";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.Location = new Point(234, 40);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1050, 650);
            MainPanel.TabIndex = 1;
            // 
            // Exit
            // 
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.ForeColor = Color.FromArgb(0, 126, 249);
            Exit.Location = new Point(0, 598);
            Exit.Name = "Exit";
            Exit.Size = new Size(197, 72);
            Exit.TabIndex = 2;
            Exit.Text = "Quit application";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Startbooking
            // 
            Startbooking.FlatAppearance.BorderSize = 0;
            Startbooking.FlatStyle = FlatStyle.Flat;
            Startbooking.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Startbooking.ForeColor = Color.FromArgb(0, 126, 249);
            Startbooking.Location = new Point(0, 130);
            Startbooking.Name = "Startbooking";
            Startbooking.Size = new Size(197, 72);
            Startbooking.TabIndex = 0;
            Startbooking.Text = "Flight booking";
            Startbooking.UseVisualStyleBackColor = true;
            Startbooking.Click += Startbooking_Click;
            // 
            // HotelBooking
            // 
            HotelBooking.FlatAppearance.BorderSize = 0;
            HotelBooking.FlatStyle = FlatStyle.Flat;
            HotelBooking.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HotelBooking.ForeColor = Color.FromArgb(0, 126, 249);
            HotelBooking.Location = new Point(0, 208);
            HotelBooking.Name = "HotelBooking";
            HotelBooking.Size = new Size(197, 72);
            HotelBooking.TabIndex = 3;
            HotelBooking.Text = "Hotel booking";
            HotelBooking.UseVisualStyleBackColor = true;
            HotelBooking.Click += HotelBooking_Click;
            // 
            // CarBooking
            // 
            CarBooking.FlatAppearance.BorderSize = 0;
            CarBooking.FlatStyle = FlatStyle.Flat;
            CarBooking.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CarBooking.ForeColor = Color.FromArgb(0, 126, 249);
            CarBooking.Location = new Point(0, 286);
            CarBooking.Name = "CarBooking";
            CarBooking.Size = new Size(197, 72);
            CarBooking.TabIndex = 4;
            CarBooking.Text = "Car rental";
            CarBooking.UseVisualStyleBackColor = true;
            CarBooking.Click += CarBooking_Click;
            // 
            // InsuranceBooking
            // 
            InsuranceBooking.FlatAppearance.BorderSize = 0;
            InsuranceBooking.FlatStyle = FlatStyle.Flat;
            InsuranceBooking.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            InsuranceBooking.ForeColor = Color.FromArgb(0, 126, 249);
            InsuranceBooking.Location = new Point(0, 364);
            InsuranceBooking.Name = "InsuranceBooking";
            InsuranceBooking.Size = new Size(197, 72);
            InsuranceBooking.TabIndex = 5;
            InsuranceBooking.Text = "Insurance";
            InsuranceBooking.UseVisualStyleBackColor = true;
            InsuranceBooking.Click += InsuranceBooking_Click;
            // 
            // Basket
            // 
            Basket.FlatAppearance.BorderSize = 0;
            Basket.FlatStyle = FlatStyle.Flat;
            Basket.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Basket.ForeColor = Color.FromArgb(0, 126, 249);
            Basket.Location = new Point(0, 442);
            Basket.Name = "Basket";
            Basket.Size = new Size(197, 72);
            Basket.TabIndex = 6;
            Basket.Text = "Basket";
            Basket.UseVisualStyleBackColor = true;
            Basket.Click += Basket_Click;
            // 
            // Mainbutton
            // 
            Mainbutton.FlatAppearance.BorderSize = 0;
            Mainbutton.FlatStyle = FlatStyle.Flat;
            Mainbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Mainbutton.ForeColor = Color.FromArgb(0, 126, 249);
            Mainbutton.Location = new Point(0, 520);
            Mainbutton.Name = "Mainbutton";
            Mainbutton.Size = new Size(197, 72);
            Mainbutton.TabIndex = 7;
            Mainbutton.Text = "Main menu";
            Mainbutton.UseVisualStyleBackColor = true;
            Mainbutton.Click += Mainbutton_Click;
            // 
            // btnBookingInit
            // 
            btnBookingInit.FlatAppearance.BorderSize = 0;
            btnBookingInit.FlatStyle = FlatStyle.Flat;
            btnBookingInit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookingInit.ForeColor = Color.FromArgb(0, 126, 249);
            btnBookingInit.Location = new Point(0, 52);
            btnBookingInit.Name = "btnBookingInit";
            btnBookingInit.Size = new Size(197, 72);
            btnBookingInit.TabIndex = 8;
            btnBookingInit.Text = "Booking Init";
            btnBookingInit.UseVisualStyleBackColor = true;
            btnBookingInit.Click += btnBookingInit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnBookingInit);
            panel1.Controls.Add(Mainbutton);
            panel1.Controls.Add(Startbooking);
            panel1.Controls.Add(Basket);
            panel1.Controls.Add(HotelBooking);
            panel1.Controls.Add(InsuranceBooking);
            panel1.Controls.Add(CarBooking);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 750);
            panel1.TabIndex = 9;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1318, 750);
            Controls.Add(MainPanel);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
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
        private Button btnBookingInit;
        private Panel panel1;
    }
}