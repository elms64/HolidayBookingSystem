namespace BookingSystemUI
{
    partial class AirportUI
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
            label2 = new Label();
            btnNext = new Button();
            lblSelectedCountry = new Label();
            lblSelectedCountryUpdate = new Label();
            lblSelectedDepartureDateUpdate = new Label();
            lblSelectedReturnDateUpdate = new Label();
            lblOriginCountryUpdate = new Label();
            departureAirportsPanel = new Panel();
            lbshowdeparture = new Label();
            lbshowarrival = new Label();
            arrivalAirportsPanel = new Panel();
            textBox1 = new TextBox();
            departureBox = new TextBox();
            arrivalBox = new TextBox();
            lblAirportContainer = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(390, 72);
            label2.Name = "label2";
            label2.Size = new Size(232, 30);
            label2.TabIndex = 2;
            label2.Text = "Searching for Airports";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(492, 576);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(103, 23);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblSelectedCountry
            // 
            lblSelectedCountry.AutoSize = true;
            lblSelectedCountry.BackColor = SystemColors.Window;
            lblSelectedCountry.Location = new Point(102, 137);
            lblSelectedCountry.Name = "lblSelectedCountry";
            lblSelectedCountry.Size = new Size(44, 15);
            lblSelectedCountry.TabIndex = 17;
            lblSelectedCountry.Text = "From : ";
            // 
            // lblSelectedCountryUpdate
            // 
            lblSelectedCountryUpdate.AutoSize = true;
            lblSelectedCountryUpdate.BackColor = SystemColors.Window;
            lblSelectedCountryUpdate.Location = new Point(152, 137);
            lblSelectedCountryUpdate.Name = "lblSelectedCountryUpdate";
            lblSelectedCountryUpdate.Size = new Size(35, 15);
            lblSelectedCountryUpdate.TabIndex = 18;
            lblSelectedCountryUpdate.Text = "From";
            // 
            // lblSelectedDepartureDateUpdate
            // 
            lblSelectedDepartureDateUpdate.AutoSize = true;
            lblSelectedDepartureDateUpdate.BackColor = SystemColors.Window;
            lblSelectedDepartureDateUpdate.Location = new Point(152, 152);
            lblSelectedDepartureDateUpdate.Name = "lblSelectedDepartureDateUpdate";
            lblSelectedDepartureDateUpdate.Size = new Size(100, 15);
            lblSelectedDepartureDateUpdate.TabIndex = 19;
            lblSelectedDepartureDateUpdate.Text = "Date of Departure";
            // 
            // lblSelectedReturnDateUpdate
            // 
            lblSelectedReturnDateUpdate.AutoSize = true;
            lblSelectedReturnDateUpdate.BackColor = SystemColors.Window;
            lblSelectedReturnDateUpdate.Location = new Point(152, 190);
            lblSelectedReturnDateUpdate.Name = "lblSelectedReturnDateUpdate";
            lblSelectedReturnDateUpdate.Size = new Size(83, 15);
            lblSelectedReturnDateUpdate.TabIndex = 20;
            lblSelectedReturnDateUpdate.Text = "Date of Return";
            // 
            // lblOriginCountryUpdate
            // 
            lblOriginCountryUpdate.AutoSize = true;
            lblOriginCountryUpdate.BackColor = SystemColors.Window;
            lblOriginCountryUpdate.Location = new Point(152, 175);
            lblOriginCountryUpdate.Name = "lblOriginCountryUpdate";
            lblOriginCountryUpdate.Size = new Size(19, 15);
            lblOriginCountryUpdate.TabIndex = 22;
            lblOriginCountryUpdate.Text = "To";
            // 
            // departureAirportsPanel
            // 
            departureAirportsPanel.BackColor = SystemColors.ActiveCaption;
            departureAirportsPanel.Location = new Point(95, 244);
            departureAirportsPanel.Name = "departureAirportsPanel";
            departureAirportsPanel.Size = new Size(898, 302);
            departureAirportsPanel.TabIndex = 24;
            // 
            // lbshowdeparture
            // 
            lbshowdeparture.AutoSize = true;
            lbshowdeparture.BackColor = SystemColors.Window;
            lbshowdeparture.Location = new Point(544, 142);
            lbshowdeparture.Name = "lbshowdeparture";
            lbshowdeparture.Size = new Size(99, 15);
            lbshowdeparture.TabIndex = 26;
            lbshowdeparture.Text = "Departure Airport";
            // 
            // lbshowarrival
            // 
            lbshowarrival.AutoSize = true;
            lbshowarrival.BackColor = SystemColors.Window;
            lbshowarrival.Location = new Point(544, 183);
            lbshowarrival.Name = "lbshowarrival";
            lbshowarrival.Size = new Size(107, 15);
            lbshowarrival.TabIndex = 27;
            lbshowarrival.Text = "Destination Airport";
            // 
            // arrivalAirportsPanel
            // 
            arrivalAirportsPanel.BackColor = SystemColors.ActiveCaption;
            arrivalAirportsPanel.Location = new Point(95, 244);
            arrivalAirportsPanel.Name = "arrivalAirportsPanel";
            arrivalAirportsPanel.Size = new Size(898, 302);
            arrivalAirportsPanel.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(102, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(831, 16);
            textBox1.TabIndex = 28;
            textBox1.Text = "Select an airport for flights and destination. Then click next to continue.";
            // 
            // departureBox
            // 
            departureBox.BackColor = SystemColors.Window;
            departureBox.BorderStyle = BorderStyle.None;
            departureBox.Location = new Point(657, 142);
            departureBox.Name = "departureBox";
            departureBox.Size = new Size(176, 16);
            departureBox.TabIndex = 29;
            departureBox.TextChanged += departureBox_TextChanged;
            // 
            // arrivalBox
            // 
            arrivalBox.BackColor = SystemColors.Window;
            arrivalBox.BorderStyle = BorderStyle.None;
            arrivalBox.Location = new Point(657, 182);
            arrivalBox.Name = "arrivalBox";
            arrivalBox.Size = new Size(176, 16);
            arrivalBox.TabIndex = 30;
            // 
            // lblAirportContainer
            // 
            lblAirportContainer.BackColor = SystemColors.Window;
            lblAirportContainer.BorderStyle = BorderStyle.FixedSingle;
            lblAirportContainer.Location = new Point(95, 128);
            lblAirportContainer.Name = "lblAirportContainer";
            lblAirportContainer.Size = new Size(850, 113);
            lblAirportContainer.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Location = new Point(102, 175);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 32;
            label1.Text = "To :";
            // 
            // AirportUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(label1);
            Controls.Add(arrivalBox);
            Controls.Add(departureBox);
            Controls.Add(textBox1);
            Controls.Add(arrivalAirportsPanel);
            Controls.Add(lbshowarrival);
            Controls.Add(lbshowdeparture);
            Controls.Add(departureAirportsPanel);
            Controls.Add(lblOriginCountryUpdate);
            Controls.Add(lblSelectedReturnDateUpdate);
            Controls.Add(lblSelectedDepartureDateUpdate);
            Controls.Add(lblSelectedCountryUpdate);
            Controls.Add(lblSelectedCountry);
            Controls.Add(btnNext);
            Controls.Add(label2);
            Controls.Add(lblAirportContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AirportUI";
            Text = "Flight";
            Load += Airport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnNext;
        private Label lblSelectedCountry;
        private Label lblSelectedCountryUpdate;
        private Label lblSelectedDepartureDateUpdate;
        private Label lblSelectedReturnDateUpdate;
        private Label lblOriginCountryUpdate;
        private FlowLayoutPanel flwPnlFlight;
        private Panel departureAirportsPanel;
        private Label lbshowdeparture;
        private Label lbshowarrival;
        private Panel arrivalAirportsPanel;
        private TextBox textBox1;
        private TextBox departureBox;
        private TextBox arrivalBox;
        private Label lblAirportContainer;
        private Label label1;
    }
}