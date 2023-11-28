﻿namespace BookingSystemUI
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            MainPanel = new Panel();
            Exit = new Button();
            viewOrder = new Button();
            Mainbutton = new Button();
            btnBookingInit = new Button();
            sidebar = new FlowLayoutPanel();
            menuButton = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(669, 21);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Scuffed holidays";
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top;
            MainPanel.Location = new Point(256, 81);
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
            Exit.Image = Properties.Resources.Exit;
            Exit.ImageAlign = ContentAlignment.MiddleLeft;
            Exit.Location = new Point(3, 315);
            Exit.Name = "Exit";
            Exit.Padding = new Padding(15, 0, 0, 0);
            Exit.Size = new Size(225, 72);
            Exit.TabIndex = 2;
            Exit.Text = "    Quit App";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // viewOrder
            // 
            viewOrder.FlatAppearance.BorderSize = 0;
            viewOrder.FlatStyle = FlatStyle.Flat;
            viewOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewOrder.ForeColor = Color.FromArgb(0, 126, 249);
            viewOrder.Image = Properties.Resources.invoice;
            viewOrder.ImageAlign = ContentAlignment.MiddleLeft;
            viewOrder.Location = new Point(3, 159);
            viewOrder.Name = "viewOrder";
            viewOrder.Padding = new Padding(15, 0, 0, 0);
            viewOrder.Size = new Size(225, 72);
            viewOrder.TabIndex = 6;
            viewOrder.Text = "         View Order";
            viewOrder.UseVisualStyleBackColor = true;
            viewOrder.Click += Basket_Click;
            // 
            // Mainbutton
            // 
            Mainbutton.FlatAppearance.BorderSize = 0;
            Mainbutton.FlatStyle = FlatStyle.Flat;
            Mainbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Mainbutton.ForeColor = Color.FromArgb(0, 126, 249);
            Mainbutton.Image = Properties.Resources.home;
            Mainbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Mainbutton.Location = new Point(3, 237);
            Mainbutton.Name = "Mainbutton";
            Mainbutton.Padding = new Padding(15, 0, 0, 0);
            Mainbutton.Size = new Size(225, 72);
            Mainbutton.TabIndex = 7;
            Mainbutton.Text = "          Main Menu";
            Mainbutton.UseVisualStyleBackColor = true;
            Mainbutton.Click += Mainbutton_Click;
            // 
            // btnBookingInit
            // 
            btnBookingInit.FlatAppearance.BorderSize = 0;
            btnBookingInit.FlatStyle = FlatStyle.Flat;
            btnBookingInit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookingInit.ForeColor = Color.FromArgb(0, 126, 249);
            btnBookingInit.Image = Properties.Resources.Plane;
            btnBookingInit.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookingInit.Location = new Point(3, 81);
            btnBookingInit.Name = "btnBookingInit";
            btnBookingInit.Padding = new Padding(15, 0, 0, 0);
            btnBookingInit.Size = new Size(225, 72);
            btnBookingInit.TabIndex = 8;
            btnBookingInit.Text = "          Booking Init";
            btnBookingInit.UseVisualStyleBackColor = true;
            btnBookingInit.Click += btnBookingInit_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(24, 30, 54);
            sidebar.Controls.Add(menuButton);
            sidebar.Controls.Add(btnBookingInit);
            sidebar.Controls.Add(viewOrder);
            sidebar.Controls.Add(Mainbutton);
            sidebar.Controls.Add(Exit);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(228, 750);
            sidebar.MinimumSize = new Size(78, 750);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(228, 750);
            sidebar.TabIndex = 10;
            // 
            // menuButton
            // 
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuButton.ForeColor = Color.FromArgb(0, 126, 249);
            menuButton.Image = Properties.Resources.list;
            menuButton.ImageAlign = ContentAlignment.MiddleLeft;
            menuButton.Location = new Point(3, 3);
            menuButton.Name = "menuButton";
            menuButton.Padding = new Padding(15, 0, 0, 0);
            menuButton.Size = new Size(225, 72);
            menuButton.TabIndex = 5;
            menuButton.Text = "  Menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1329, 750);
            Controls.Add(sidebar);
            Controls.Add(MainPanel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel MainPanel;
        private Button Exit;
        private Button viewOrder;
        private Button Mainbutton;
        private Button btnBookingInit;
        private FlowLayoutPanel sidebar;
        private Button menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}