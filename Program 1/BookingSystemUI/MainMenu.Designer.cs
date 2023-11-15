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
            panel1 = new Panel();
            Exit = new Button();
            Vieworder = new Button();
            Startbooking = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(492, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Scuffed holidays";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(Vieworder);
            panel1.Controls.Add(Startbooking);
            panel1.Location = new Point(42, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 600);
            panel1.TabIndex = 1;
            // 
            // Exit
            // 
            Exit.Location = new Point(460, 320);
            Exit.Name = "Exit";
            Exit.Size = new Size(184, 99);
            Exit.TabIndex = 2;
            Exit.Text = "Quit application";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Vieworder
            // 
            Vieworder.Location = new Point(460, 215);
            Vieworder.Name = "Vieworder";
            Vieworder.Size = new Size(184, 99);
            Vieworder.TabIndex = 1;
            Vieworder.Text = "View orders";
            Vieworder.UseVisualStyleBackColor = true;
            Vieworder.Click += Vieworder_Click;
            // 
            // Startbooking
            // 
            Startbooking.Location = new Point(460, 110);
            Startbooking.Name = "Startbooking";
            Startbooking.Size = new Size(184, 99);
            Startbooking.TabIndex = 0;
            Startbooking.Text = "Start order";
            Startbooking.UseVisualStyleBackColor = true;
            Startbooking.Click += Startbooking_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button Exit;
        private Button Vieworder;
        private Button Startbooking;
    }
}