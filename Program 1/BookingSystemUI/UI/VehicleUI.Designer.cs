namespace BookingSystemUI
{
    partial class VehicleUI
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
            vehiclePanel = new Panel();
            SearchCar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(455, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Car renting";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(476, 601);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 37);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // CarType
            // 
            CarType.FormattingEnabled = true;
            CarType.Location = new Point(36, 148);
            CarType.Name = "CarType";
            CarType.Size = new Size(163, 23);
            CarType.TabIndex = 2;
            CarType.SelectedIndexChanged += CarType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 130);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 3;
            label2.Text = "Search the car that is required";
            // 
            // PickUpDate
            // 
            PickUpDate.Location = new Point(254, 148);
            PickUpDate.Name = "PickUpDate";
            PickUpDate.Size = new Size(200, 23);
            PickUpDate.TabIndex = 4;
            PickUpDate.ValueChanged += PickUpDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 130);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 5;
            label3.Text = "Select the date of pickup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 130);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 6;
            label4.Text = "Select the date of dropoff";
            // 
            // DropOffDate
            // 
            DropOffDate.Location = new Point(518, 148);
            DropOffDate.Name = "DropOffDate";
            DropOffDate.Size = new Size(200, 23);
            DropOffDate.TabIndex = 7;
            DropOffDate.ValueChanged += DropOffDate_ValueChanged;
            // 
            // vehiclePanel
            // 
            vehiclePanel.Location = new Point(36, 212);
            vehiclePanel.Name = "vehiclePanel";
            vehiclePanel.Size = new Size(980, 340);
            vehiclePanel.TabIndex = 12;
            // 
            // SearchCar
            // 
            SearchCar.Location = new Point(913, 147);
            SearchCar.Name = "SearchCar";
            SearchCar.Size = new Size(103, 23);
            SearchCar.TabIndex = 13;
            SearchCar.Text = "Search cars";
            SearchCar.UseVisualStyleBackColor = true;
            SearchCar.Click += SearchCar_Click;
            // 
            // VehicleUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1050, 650);
            Controls.Add(SearchCar);
            Controls.Add(vehiclePanel);
            Controls.Add(DropOffDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PickUpDate);
            Controls.Add(label2);
            Controls.Add(CarType);
            Controls.Add(btnNext);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VehicleUI";
            Text = "Vehicle";
            Load += Vehicle_Load;
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
        private Panel vehiclePanel;
        private Button SearchCar;
    }
}