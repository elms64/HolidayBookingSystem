﻿namespace BookingSystemUI
{
    partial class notice_hotel
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
            button1 = new Button();
            SelectFlight = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 86);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 22;
            button1.Text = "YES";
            button1.UseVisualStyleBackColor = true;
            // 
            // SelectFlight
            // 
            SelectFlight.Location = new Point(230, 86);
            SelectFlight.Name = "SelectFlight";
            SelectFlight.Size = new Size(103, 23);
            SelectFlight.TabIndex = 21;
            SelectFlight.Text = "NO";
            SelectFlight.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 20);
            label2.Name = "label2";
            label2.Size = new Size(313, 30);
            label2.TabIndex = 20;
            label2.Text = "Do your need to book a hotel?";
            label2.Click += label2_Click;
            // 
            // notice_hotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 128);
            Controls.Add(button1);
            Controls.Add(SelectFlight);
            Controls.Add(label2);
            Name = "notice_hotel";
            Text = "notice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button SelectFlight;
        private Label label2;
    }
}