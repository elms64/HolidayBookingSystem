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
            panel1 = new Panel();
            btnLoadCountries = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            vScrollBar1 = new VScrollBar();
            countryListBox = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flightBox
            // 
            flightBox.FormattingEnabled = true;
            flightBox.Location = new Point(51, 76);
            flightBox.Margin = new Padding(2, 1, 2, 1);
            flightBox.Name = "flightBox";
            flightBox.Size = new Size(348, 23);
            flightBox.TabIndex = 0;
            flightBox.SelectedIndexChanged += flightBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 1;
            label1.Text = "Check available flights:";
            // 
            // refresh
            // 
            refresh.Location = new Point(316, 115);
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
            btnSendToProgram2.Location = new Point(55, 161);
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
            txtBoxMessage.Location = new Point(132, 161);
            txtBoxMessage.Multiline = true;
            txtBoxMessage.Name = "txtBoxMessage";
            txtBoxMessage.Size = new Size(239, 68);
            txtBoxMessage.TabIndex = 4;
            txtBoxMessage.Text = "txtBoxMessage";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(countryListBox);
            panel1.Controls.Add(btnLoadCountries);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxMessage);
            panel1.Controls.Add(flightBox);
            panel1.Controls.Add(btnSendToProgram2);
            panel1.Controls.Add(refresh);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 575);
            panel1.TabIndex = 5;
            // 
            // btnLoadCountries
            // 
            btnLoadCountries.Location = new Point(411, 220);
            btnLoadCountries.Name = "btnLoadCountries";
            btnLoadCountries.Size = new Size(75, 23);
            btnLoadCountries.TabIndex = 8;
            btnLoadCountries.Text = "btnLoadCountries";
            btnLoadCountries.UseVisualStyleBackColor = true;
            btnLoadCountries.Click += btnLoadCountries_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(3, 483);
            panel4.Name = "panel4";
            panel4.Size = new Size(542, 100);
            panel4.TabIndex = 7;
            panel4.Tag = "Listing";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(3, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(542, 100);
            panel3.TabIndex = 7;
            panel3.Tag = "Listing";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(2, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 100);
            panel2.TabIndex = 6;
            panel2.Tag = "Listing";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(422, 76);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 80);
            vScrollBar1.TabIndex = 5;
            // 
            // countryListBox
            // 
            countryListBox.FormattingEnabled = true;
            countryListBox.ItemHeight = 15;
            countryListBox.Location = new Point(243, 25);
            countryListBox.Name = "countryListBox";
            countryListBox.Size = new Size(120, 94);
            countryListBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 601);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox flightBox;
        private Label label1;
        private Button refresh;
        private Button btnSendToProgram2;
        private TextBox txtBoxMessage;
        private Panel panel1;
        private Panel panel2;
        private VScrollBar vScrollBar1;
        private Panel panel4;

        private Panel panel3;
        private Button btnLoadCountries;
        private ListBox countryListBox;
    }
}