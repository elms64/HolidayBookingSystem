namespace BookingSystemUI
{
    partial class Hotel
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SelectFlight = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 175);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 11;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(976, 17);
            label3.TabIndex = 9;
            label3.Text = "Book a hotel here by searching for the neccessary information, however be sure to fill out all the boxes, since the program will not continue without all the information";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(348, 9);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 8;
            label2.Text = "Searching for hotel";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 7;
            label1.Text = "Desrtination or hotel";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 23);
            textBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 340);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(679, 95);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 15;
            label6.Text = "Check out";
            label6.Click += label6_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(679, 132);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 14;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 95);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 13;
            label5.Text = "Check in";
            label5.Click += label5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(442, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // SelectFlight
            // 
            SelectFlight.Location = new Point(447, 556);
            SelectFlight.Name = "SelectFlight";
            SelectFlight.Size = new Size(103, 23);
            SelectFlight.TabIndex = 17;
            SelectFlight.Text = "Select hotels";
            SelectFlight.UseVisualStyleBackColor = true;
            // 
            // Hotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(SelectFlight);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Hotel";
            Text = "Hotel";
            Load += Hotel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button SelectFlight;
    }
}