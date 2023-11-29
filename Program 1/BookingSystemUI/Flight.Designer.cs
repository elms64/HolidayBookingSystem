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
            label2 = new Label();
            label3 = new Label();
            btnNext = new Button();
            lblSelectedCountry = new Label();
            lblSelectedCountryUpdate = new Label();
            lblSelectedDepartureDateUpdate = new Label();
            lblSelectedReturnDateUpdate = new Label();
            lblSelectDepartureAirport = new Label();
            lblOriginCountryUpdate = new Label();
            lblOriginIdDEBUG = new Label();
            flwPnlFlight = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(390, 72);
            label2.Name = "label2";
            label2.Size = new Size(214, 30);
            label2.TabIndex = 2;
            label2.Text = "Searching for flights";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 102);
            label3.Name = "label3";
            label3.Size = new Size(976, 17);
            label3.TabIndex = 3;
            label3.Text = "Book a flight here by searching for the neccessary information, however be sure to fill out all the boxes, since the program will not continue without all the information";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(444, 557);
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
            lblSelectedCountry.Location = new Point(32, 6);
            lblSelectedCountry.Name = "lblSelectedCountry";
            lblSelectedCountry.Size = new Size(106, 15);
            lblSelectedCountry.TabIndex = 17;
            lblSelectedCountry.Text = "Selected Country : ";
            // 
            // lblSelectedCountryUpdate
            // 
            lblSelectedCountryUpdate.AutoSize = true;
            lblSelectedCountryUpdate.Location = new Point(180, 6);
            lblSelectedCountryUpdate.Name = "lblSelectedCountryUpdate";
            lblSelectedCountryUpdate.Size = new Size(145, 15);
            lblSelectedCountryUpdate.TabIndex = 18;
            lblSelectedCountryUpdate.Text = "lblSelectedCountryUpdate";
            // 
            // lblSelectedDepartureDateUpdate
            // 
            lblSelectedDepartureDateUpdate.AutoSize = true;
            lblSelectedDepartureDateUpdate.Location = new Point(180, 21);
            lblSelectedDepartureDateUpdate.Name = "lblSelectedDepartureDateUpdate";
            lblSelectedDepartureDateUpdate.Size = new Size(178, 15);
            lblSelectedDepartureDateUpdate.TabIndex = 19;
            lblSelectedDepartureDateUpdate.Text = "lblSelectedDepartureDateUpdate";
            // 
            // lblSelectedReturnDateUpdate
            // 
            lblSelectedReturnDateUpdate.AutoSize = true;
            lblSelectedReturnDateUpdate.Location = new Point(180, 36);
            lblSelectedReturnDateUpdate.Name = "lblSelectedReturnDateUpdate";
            lblSelectedReturnDateUpdate.Size = new Size(161, 15);
            lblSelectedReturnDateUpdate.TabIndex = 20;
            lblSelectedReturnDateUpdate.Text = "lblSelectedReturnDateUpdate";
            // 
            // lblSelectDepartureAirport
            // 
            lblSelectDepartureAirport.AutoSize = true;
            lblSelectDepartureAirport.Location = new Point(180, 142);
            lblSelectDepartureAirport.Name = "lblSelectDepartureAirport";
            lblSelectDepartureAirport.Size = new Size(140, 15);
            lblSelectDepartureAirport.TabIndex = 21;
            lblSelectDepartureAirport.Text = "lblSelectDepartureAirport";
            // 
            // lblOriginCountryUpdate
            // 
            lblOriginCountryUpdate.AutoSize = true;
            lblOriginCountryUpdate.Location = new Point(180, 51);
            lblOriginCountryUpdate.Name = "lblOriginCountryUpdate";
            lblOriginCountryUpdate.Size = new Size(134, 15);
            lblOriginCountryUpdate.TabIndex = 22;
            lblOriginCountryUpdate.Text = "lblOriginCountryUpdate";
            // 
            // lblOriginIdDEBUG
            // 
            lblOriginIdDEBUG.AutoSize = true;
            lblOriginIdDEBUG.Location = new Point(180, 157);
            lblOriginIdDEBUG.Name = "lblOriginIdDEBUG";
            lblOriginIdDEBUG.Size = new Size(100, 15);
            lblOriginIdDEBUG.TabIndex = 23;
            lblOriginIdDEBUG.Text = "lblOriginIdDEBUG";
            // 
            // flwPnlFlight
            // 
            flwPnlFlight.Location = new Point(80, 224);
            flwPnlFlight.Name = "flwPnlFlight";
            flwPnlFlight.Size = new Size(877, 315);
            flwPnlFlight.TabIndex = 24;
            // 
            // Flight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 611);
            Controls.Add(flwPnlFlight);
            Controls.Add(lblOriginIdDEBUG);
            Controls.Add(lblOriginCountryUpdate);
            Controls.Add(lblSelectDepartureAirport);
            Controls.Add(lblSelectedReturnDateUpdate);
            Controls.Add(lblSelectedDepartureDateUpdate);
            Controls.Add(lblSelectedCountryUpdate);
            Controls.Add(lblSelectedCountry);
            Controls.Add(btnNext);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Flight";
            Text = "Flight";
            Load += Flight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button btnNext;
        private Label lblSelectedCountry;
        private Label lblSelectedCountryUpdate;
        private Label lblSelectedDepartureDateUpdate;
        private Label lblSelectedReturnDateUpdate;
        private Label lblSelectDepartureAirport;
        private Label lblOriginCountryUpdate;
        private Label lblOriginIdDEBUG;
        private FlowLayoutPanel flwPnlFlight;
    }
}