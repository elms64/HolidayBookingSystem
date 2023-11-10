namespace BookingSystemUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flightBox = new ComboBox();
            label1 = new Label();
            refresh = new Button();
            btnSendToProgram2 = new Button();
            txtBoxMessage = new TextBox();
            SuspendLayout();
            // 
            // flightBox
            // 
            flightBox.FormattingEnabled = true;
            flightBox.Location = new Point(244, 135);
            flightBox.Margin = new Padding(2, 1, 2, 1);
            flightBox.Name = "flightBox";
            flightBox.Size = new Size(348, 23);
            flightBox.TabIndex = 0;
            flightBox.SelectedIndexChanged += flightBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 108);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 1;
            label1.Text = "Check available flights:";
            // 
            // refresh
            // 
            refresh.Location = new Point(509, 174);
            refresh.Margin = new Padding(2, 1, 2, 1);
            refresh.Name = "refresh";
            refresh.Size = new Size(81, 22);
            refresh.TabIndex = 2;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // btnSendToProgram2
            // 
            btnSendToProgram2.Location = new Point(132, 296);
            btnSendToProgram2.Margin = new Padding(2, 1, 2, 1);
            btnSendToProgram2.Name = "btnSendToProgram2";
            btnSendToProgram2.Size = new Size(72, 68);
            btnSendToProgram2.TabIndex = 3;
            btnSendToProgram2.Text = "btnSendToProgram2";
            btnSendToProgram2.UseVisualStyleBackColor = true;
            btnSendToProgram2.Click += btnSendToProgram2_Click;
            // 
            // txtBoxMessage
            // 
            txtBoxMessage.Location = new Point(209, 296);
            txtBoxMessage.Multiline = true;
            txtBoxMessage.Name = "txtBoxMessage";
            txtBoxMessage.Size = new Size(239, 68);
            txtBoxMessage.TabIndex = 4;
            txtBoxMessage.Text = "txtBoxMessage";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 456);
            Controls.Add(txtBoxMessage);
            Controls.Add(btnSendToProgram2);
            Controls.Add(refresh);
            Controls.Add(label1);
            Controls.Add(flightBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox flightBox;
        private Label label1;
        private Button refresh;
        private Button btnSendToProgram2;
        private TextBox txtBoxMessage;
    }
}