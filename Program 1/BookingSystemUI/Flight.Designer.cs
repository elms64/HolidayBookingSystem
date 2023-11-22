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
            DepartureAirport = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ArrivingAirport = new TextBox();
            DepartingDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            ReturnDate = new DateTimePicker();
            SearchFlight = new Button();
            FlightPanel = new Panel();
            SelectFlight = new Button();
            SuspendLayout();
            // 
            // DepartureAirport
            // 
            DepartureAirport.Location = new Point(32, 120);
            DepartureAirport.Name = "DepartureAirport";
            DepartureAirport.Size = new Size(180, 23);
            DepartureAirport.TabIndex = 0;
            DepartureAirport.TextChanged += DepartureAirport_TextChanged;
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
            label2.Click += label2_Click;
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
            // ArrivingAirport
            // 
            ArrivingAirport.Location = new Point(246, 120);
            ArrivingAirport.Name = "ArrivingAirport";
            ArrivingAirport.Size = new Size(180, 23);
            ArrivingAirport.TabIndex = 4;
            ArrivingAirport.TextChanged += ArrivingAirport_TextChanged;
            // 
            // DepartingDate
            // 
            DepartingDate.Location = new Point(466, 120);
            DepartingDate.Name = "DepartingDate";
            DepartingDate.Size = new Size(200, 23);
            DepartingDate.TabIndex = 6;
            DepartingDate.ValueChanged += DepartingDate_ValueChanged;
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
            // ReturnDate
            // 
            ReturnDate.Location = new Point(699, 120);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(200, 23);
            ReturnDate.TabIndex = 8;
            // 
            // SearchFlight
            // 
            SearchFlight.Location = new Point(919, 120);
            SearchFlight.Name = "SearchFlight";
            SearchFlight.Size = new Size(103, 23);
            SearchFlight.TabIndex = 10;
            SearchFlight.Text = "Search flights";
            SearchFlight.UseVisualStyleBackColor = true;
            SearchFlight.Click += SearchFlight_Click;
            // 
            // FlightPanel
            // 
            FlightPanel.Location = new Point(32, 224);
            FlightPanel.Name = "FlightPanel";
            FlightPanel.Size = new Size(980, 340);
            FlightPanel.TabIndex = 11;
            // 
            // SelectFlight
            // 
            SelectFlight.Location = new Point(453, 576);
            SelectFlight.Name = "SelectFlight";
            SelectFlight.Size = new Size(103, 23);
            SelectFlight.TabIndex = 12;
            SelectFlight.Text = "Select flights";
            SelectFlight.UseVisualStyleBackColor = true;
            SelectFlight.Click += SelectFlight_Click;
            // 
            // Flight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(SelectFlight);
            Controls.Add(FlightPanel);
            Controls.Add(SearchFlight);
            Controls.Add(label6);
            Controls.Add(ReturnDate);
            Controls.Add(label5);
            Controls.Add(DepartingDate);
            Controls.Add(label4);
            Controls.Add(ArrivingAirport);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DepartureAirport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Flight";
            Text = "Flight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DepartureAirport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ArrivingAirport;
        private DateTimePicker DepartingDate;
        private Label label5;
        private Label label6;
        private DateTimePicker ReturnDate;
        private Button SearchFlight;
        private Panel FlightPanel;
        private Button SelectFlight;
    }
}