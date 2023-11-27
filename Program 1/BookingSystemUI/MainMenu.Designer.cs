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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(563, 7);
            label1.Name = "label1";
            label1.Size = new Size(250, 40);
            label1.TabIndex = 0;
            label1.Text = "Scuffed holidays";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.Location = new Point(162, 53);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1200, 867);
            MainPanel.TabIndex = 1;
            // 
            // Exit
            // 
            Exit.Location = new Point(14, 864);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(133, 111);
            Exit.TabIndex = 2;
            Exit.Text = "Quit application";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Startbooking
            // 
            Startbooking.Location = new Point(14, 152);
            Startbooking.Margin = new Padding(3, 4, 3, 4);
            Startbooking.Name = "Startbooking";
            Startbooking.Size = new Size(133, 111);
            Startbooking.TabIndex = 0;
            Startbooking.Text = "Flight booking";
            Startbooking.UseVisualStyleBackColor = true;
            Startbooking.Click += Startbooking_Click;
            // 
            // HotelBooking
            // 
            HotelBooking.Location = new Point(14, 271);
            HotelBooking.Margin = new Padding(3, 4, 3, 4);
            HotelBooking.Name = "HotelBooking";
            HotelBooking.Size = new Size(133, 111);
            HotelBooking.TabIndex = 3;
            HotelBooking.Text = "Hotel booking";
            HotelBooking.UseVisualStyleBackColor = true;
            HotelBooking.Click += HotelBooking_Click;
            // 
            // CarBooking
            // 
            CarBooking.Location = new Point(14, 389);
            CarBooking.Margin = new Padding(3, 4, 3, 4);
            CarBooking.Name = "CarBooking";
            CarBooking.Size = new Size(133, 111);
            CarBooking.TabIndex = 4;
            CarBooking.Text = "Car rental";
            CarBooking.UseVisualStyleBackColor = true;
            CarBooking.Click += CarBooking_Click;
            // 
            // InsuranceBooking
            // 
            InsuranceBooking.Location = new Point(14, 508);
            InsuranceBooking.Margin = new Padding(3, 4, 3, 4);
            InsuranceBooking.Name = "InsuranceBooking";
            InsuranceBooking.Size = new Size(133, 111);
            InsuranceBooking.TabIndex = 5;
            InsuranceBooking.Text = "Insurance";
            InsuranceBooking.UseVisualStyleBackColor = true;
            InsuranceBooking.Click += InsuranceBooking_Click;
            // 
            // Basket
            // 
            Basket.Location = new Point(14, 627);
            Basket.Margin = new Padding(3, 4, 3, 4);
            Basket.Name = "Basket";
            Basket.Size = new Size(133, 111);
            Basket.TabIndex = 6;
            Basket.Text = "Basket";
            Basket.UseVisualStyleBackColor = true;
            Basket.Click += Basket_Click;
            // 
            // Mainbutton
            // 
            Mainbutton.Location = new Point(14, 745);
            Mainbutton.Margin = new Padding(3, 4, 3, 4);
            Mainbutton.Name = "Mainbutton";
            Mainbutton.Size = new Size(133, 111);
            Mainbutton.TabIndex = 7;
            Mainbutton.Text = "Main menu";
            Mainbutton.UseVisualStyleBackColor = true;
            Mainbutton.Click += Mainbutton_Click;
            // 
            // btnBookingInit
            // 
            btnBookingInit.Location = new Point(14, 33);
            btnBookingInit.Margin = new Padding(3, 4, 3, 4);
            btnBookingInit.Name = "btnBookingInit";
            btnBookingInit.Size = new Size(133, 111);
            btnBookingInit.TabIndex = 8;
            btnBookingInit.Text = "Booking Init";
            btnBookingInit.UseVisualStyleBackColor = true;
            btnBookingInit.Click += btnBookingInit_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1371, 1000);
            Controls.Add(btnBookingInit);
            Controls.Add(Mainbutton);
            Controls.Add(Basket);
            Controls.Add(InsuranceBooking);
            Controls.Add(Exit);
            Controls.Add(CarBooking);
            Controls.Add(HotelBooking);
            Controls.Add(MainPanel);
            Controls.Add(label1);
            Controls.Add(Startbooking);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
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
    }
}