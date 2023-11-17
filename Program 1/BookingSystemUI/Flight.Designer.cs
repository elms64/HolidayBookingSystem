namespace BookingSystemUI
{
    partial class Flight
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SearchFlight = new Button();
            panel1 = new Panel();
            SelectFlight = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 102);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 1;
            label1.Text = "Search for departing airport";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(387, 9);
            label2.Name = "label2";
            label2.Size = new Size(214, 30);
            label2.TabIndex = 2;
            label2.Text = "Searching for flights";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 39);
            label3.Name = "label3";
            label3.Size = new Size(976, 17);
            label3.TabIndex = 3;
            label3.Text = "Book a flight here by searching for the neccessary information, however be sure to fill out all the boxes, since the program will not continue without all the information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 102);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 5;
            label4.Text = "Search for ariving airport";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(466, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 102);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 7;
            label5.Text = "Search for departing date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(697, 102);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 9;
            label6.Text = "Search for returning date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(699, 120);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // SearchFlight
            // 
            SearchFlight.Location = new Point(919, 120);
            SearchFlight.Name = "SearchFlight";
            SearchFlight.Size = new Size(103, 23);
            SearchFlight.TabIndex = 10;
            SearchFlight.Text = "Search flights";
            SearchFlight.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(32, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 337);
            panel1.TabIndex = 11;
            // 
            // SelectFlight
            // 
            SelectFlight.Location = new Point(453, 576);
            SelectFlight.Name = "SelectFlight";
            SelectFlight.Size = new Size(103, 23);
            SelectFlight.TabIndex = 12;
            SelectFlight.Text = "Select flights";
            SelectFlight.UseVisualStyleBackColor = true;
            // 
            // Flight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(SelectFlight);
            Controls.Add(panel1);
            Controls.Add(SearchFlight);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Flight";
            Text = "Flight";
            Load += Flight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Button SearchFlight;
        private Panel panel1;
        private Button SelectFlight;
    }
}