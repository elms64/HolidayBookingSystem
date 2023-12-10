namespace BookingSystemUI
{
    partial class MainMenu2
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
            StartBooking = new Button();
            ViewOrders = new Button();
            ExitApp = new Button();
            SuspendLayout();
            // 
            // StartBooking
            // 
            StartBooking.FlatAppearance.BorderSize = 0;
            StartBooking.FlatStyle = FlatStyle.Flat;
            StartBooking.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            StartBooking.ForeColor = Color.FromArgb(0, 126, 249);
            StartBooking.Location = new Point(420, 164);
            StartBooking.Name = "StartBooking";
            StartBooking.Size = new Size(315, 131);
            StartBooking.TabIndex = 0;
            StartBooking.Text = "Start booking";
            StartBooking.UseVisualStyleBackColor = true;
            StartBooking.Click += StartBooking_Click;
            // 
            // ViewOrders
            // 
            ViewOrders.FlatAppearance.BorderSize = 0;
            ViewOrders.FlatStyle = FlatStyle.Flat;
            ViewOrders.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ViewOrders.ForeColor = Color.FromArgb(0, 126, 249);
            ViewOrders.Location = new Point(420, 301);
            ViewOrders.Name = "ViewOrders";
            ViewOrders.Size = new Size(315, 131);
            ViewOrders.TabIndex = 1;
            ViewOrders.Text = "View orders";
            ViewOrders.UseVisualStyleBackColor = true;
            ViewOrders.Click += ViewOrders_Click;
            // 
            // ExitApp
            // 
            ExitApp.FlatAppearance.BorderSize = 0;
            ExitApp.FlatStyle = FlatStyle.Flat;
            ExitApp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExitApp.ForeColor = Color.FromArgb(0, 126, 249);
            ExitApp.Location = new Point(420, 438);
            ExitApp.Name = "ExitApp";
            ExitApp.Size = new Size(315, 131);
            ExitApp.TabIndex = 2;
            ExitApp.Text = "Quit application";
            ExitApp.UseVisualStyleBackColor = true;
            ExitApp.Click += ExitApp_Click;
            // 
            // MainMenu2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1200, 750);
            Controls.Add(ExitApp);
            Controls.Add(ViewOrders);
            Controls.Add(StartBooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu2";
            Text = "MainMenu2";
            ResumeLayout(false);
        }

        #endregion

        private Button StartBooking;
        private Button ViewOrders;
        private Button ExitApp;
    }
}