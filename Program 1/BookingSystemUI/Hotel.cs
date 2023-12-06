using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingSystemUI.Form1;

namespace BookingSystemUI
{

    public partial class Hotel : Form
    {
        private const string ConsoleAppUrl = "http://localhost:8080";

        private MainMenu mainForm;


        private string selectedCountry;
        private string selectedOrigin;
        private int selectedOriginID;
        private int selectedCountryID;
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;
        

        public Hotel(string selectedCountry, string selectedOrigin, int selectedOriginID, int selectedCountryID, MainMenu mainForm, DateTime selectedDepartureDate, string selectedReturnDate)
        {
           
            InitializeComponent();
            this.selectedCountry = selectedCountry;
            this.selectedOrigin = selectedOrigin;
            this.selectedOriginID = selectedOriginID;
            this.selectedCountryID = selectedCountryID;
            this.selectedDepartureDate = selectedDepartureDate;
            this.selectedReturnDate = selectedReturnDate;
            MessageBox.Show(selectedOrigin); // Check if this shows the correct value
            this.mainForm = mainForm;  // Ensure that mainForm is assigned here.

        }

        private async void Hotel_Load(object sender, EventArgs e)
        {
            lblSelectedCountry.Text = selectedCountry;
            lblSelectedOrigin.Text = selectedOrigin;
            lblCountryID.Text = selectedCountryID.ToString();
            lblOriginID.Text = selectedOriginID.ToString();
            lblSelectedReturnDate.Text = selectedReturnDate;
            lblSelectedDepartureDate.Text = selectedDepartureDate.ToString();

            // Add code for GET request. No need to send CountryID or anything - has been remembered from flight form.
            // Populate hotel data.
            

           

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void HotelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchHotel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CarRental carRental = new CarRental(selectedCountry, selectedOrigin, selectedOriginID, selectedCountryID, mainForm, selectedDepartureDate, selectedReturnDate);

            // Show the Flight form
            mainForm.ShowFormInMainPanel(carRental);

            // Close the BookingInit form if needed
            this.Close();
        }
    }
}
