namespace BookingSystemUI
{
    partial class CarRental
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
            btnNext = new Button();
            CarType = new ComboBox();
            label2 = new Label();
            PickUpDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            DropOffDate = new DateTimePicker();
            CarRentalPanel = new Panel();
            SearchCar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(520, 12);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 0;
            label1.Text = "Car renting";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(544, 801);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(98, 49);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // CarType
            // 
            CarType.FormattingEnabled = true;
            CarType.Location = new Point(41, 197);
            CarType.Margin = new Padding(3, 4, 3, 4);
            CarType.Name = "CarType";
            CarType.Size = new Size(186, 28);
            CarType.TabIndex = 2;
            CarType.SelectedIndexChanged += CarType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 173);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 3;
            label2.Text = "Search the car that is required";
            // 
            // PickUpDate
            // 
            PickUpDate.Location = new Point(290, 197);
            PickUpDate.Margin = new Padding(3, 4, 3, 4);
            PickUpDate.Name = "PickUpDate";
            PickUpDate.Size = new Size(228, 27);
            PickUpDate.TabIndex = 4;
            PickUpDate.ValueChanged += PickUpDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 173);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 5;
            label3.Text = "Select the date of pickup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(592, 173);
            label4.Name = "label4";
            label4.Size = new Size(181, 20);
            label4.TabIndex = 6;
            label4.Text = "Select the date of dropoff";
            // 
            // DropOffDate
            // 
            DropOffDate.Location = new Point(592, 197);
            DropOffDate.Margin = new Padding(3, 4, 3, 4);
            DropOffDate.Name = "DropOffDate";
            DropOffDate.Size = new Size(228, 27);
            DropOffDate.TabIndex = 7;
            DropOffDate.ValueChanged += DropOffDate_ValueChanged;
            // 
            // CarRentalPanel
            // 
            CarRentalPanel.Location = new Point(41, 283);
            CarRentalPanel.Margin = new Padding(3, 4, 3, 4);
            CarRentalPanel.Name = "CarRentalPanel";
            CarRentalPanel.Size = new Size(1120, 453);
            CarRentalPanel.TabIndex = 12;
            // 
            // SearchCar
            // 
            SearchCar.Location = new Point(1043, 196);
            SearchCar.Margin = new Padding(3, 4, 3, 4);
            SearchCar.Name = "SearchCar";
            SearchCar.Size = new Size(118, 31);
            SearchCar.TabIndex = 13;
            SearchCar.Text = "Search cars";
            SearchCar.UseVisualStyleBackColor = true;
            SearchCar.Click += SearchCar_Click;
            // 
            // CarRental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 867);
            Controls.Add(SearchCar);
            Controls.Add(CarRentalPanel);
            Controls.Add(DropOffDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PickUpDate);
            Controls.Add(label2);
            Controls.Add(CarType);
            Controls.Add(btnNext);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CarRental";
            Text = "CarRental";
            Load += CarRental_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNext;
        private ComboBox CarType;
        private Label label2;
        private DateTimePicker PickUpDate;
        private Label label3;
        private Label label4;
        private DateTimePicker DropOffDate;
        private Panel CarRentalPanel;
        private Button SearchCar;
    }
}