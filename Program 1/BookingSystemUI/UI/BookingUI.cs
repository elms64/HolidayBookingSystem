
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using BookingSystemUI.Model;
using BookingSystemUI.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookingSystemUI
{
    public partial class BookingUI : Form
    {
        private MainMenu mainForm;
        private HotelUI Hotel;
        private IBookingService bookingService;


        public BookingUI(MainMenu mainForm)
        {
            InitializeComponent();
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            txtBoxHowLong.TextChanged += txtBoxHowLong_TextChanged;
            this.mainForm = mainForm;
            bookingService = new BookingServiceImpl();
        }

        private async void BookingInit_Load(object sender, EventArgs e)
        {
            // Get a list of countries from the booking service
            Task<List<Country>> countriesTask = Task.Run(bookingService.GetCountries);
            await countriesTask;
            List<Country> countries = countriesTask.Result;

            if (countries == null)
            {
                MessageBox.Show("countires is null");
            }

            comboBoxCountry.DataSource = countries.Where(country => country.Name.Equals("United Kingdom of Great Britain and Northern Ireland")).ToList();
            comboBoxCountry.DisplayMember = "Name";


            // Get a list of countries from the booking service
            Task<List<Country>> countriesTask2 = Task.Run(bookingService.GetCountries);
            await countriesTask2;
            List<Country> countries2 = countriesTask2.Result;

            if (countries2 == null)
            {
                MessageBox.Show("countires is null");
            }


            comboBoxOrigin.DataSource = countries2.Where(country => country.Name.Equals("Spain")).ToList();
            comboBoxOrigin.DisplayMember = "Name";


        }
          

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateReturnDate();
        }

        private void txtBoxHowLong_TextChanged(object sender, EventArgs e)
        {
            UpdateReturnDate();
        }

        private void UpdateReturnDate()
        {
            DateTime departureDate = dateTimePickerStart.Value;

            if (int.TryParse(txtBoxHowLong.Text, out int duration))
            {
                if (duration > 0 && duration <= 300) // Adjust the upper limit as needed
                {
                    DateTime returnDate = departureDate.AddDays(duration);
                    lblReturnDateUpdate.Text = returnDate.ToShortDateString();
                }
                else
                {
                    // Revert the value to a default (e.g., 7)
                    txtBoxHowLong.Text = "0";
                    lblReturnDateUpdate.Text = "Duration must be between 1 and 300 days.";
                }
            }
            else
            {
                // Revert the value to a default (e.g., 7)
                txtBoxHowLong.Text = "0";
                lblReturnDateUpdate.Text = "Invalid duration";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (comboBoxCountry.SelectedItem == null)
            {
                MessageBox.Show("Please select a country to travel from");
            }
            // Retrieve both the selected country and origin
            Country selectedToCountry = (Country) comboBoxCountry.SelectedItem;
            Country selectedOriginCountry = (Country) comboBoxOrigin.SelectedItem;

            if (comboBoxOrigin.SelectedItem == null)
            {
                MessageBox.Show("Please select a country to travel to");
            }

            Country selectedFromCountry = comboBoxOrigin.SelectedItem as Country;
         

            DateTime selectedDepartureDate = dateTimePickerStart.Value;
            string selectedReturnDate = lblReturnDateUpdate.Text;

            MessageBox.Show($"Selected Country ID: {selectedToCountry.ID}\n" +
                          $"Selected Country: {selectedToCountry.Name}\n" +
                          $"Selected Origin ID: {selectedOriginCountry.ID}\n" +
                          $"Selected Return Date: {selectedReturnDate}\n" +
                          $"Selected Origin: {selectedOriginCountry.Name}\n" +
                          $"Selected Departure Date: {selectedDepartureDate.ToShortDateString()}");


            Booking booking = new Booking();
            FlightDetails flightDetails = new FlightDetails();
            flightDetails.DepartureDateTime = selectedDepartureDate;
            flightDetails.DepartureCountry=selectedFromCountry;
            flightDetails.ArrivalCountry=selectedToCountry;

            booking.FlightDetails=flightDetails;

            // Create an instance of the Flight form and pass the values
            AirportUI flight = new AirportUI(booking, mainForm);

            // Show the Flight form
            mainForm.ShowFormInMainPanel(flight);

            // Close the BookingInit form if needed
            this.Close();
        }

        private void ParseCountry(string countryString, out int id, out string name)
        {
            id = -1;
            name = null;

            if (countryString != null)
            {
                string[] parts = countryString.Split(':');
                if (parts.Length == 2 && int.TryParse(parts[0], out id))
                {
                    name = parts[1].Trim();
                }
            }
        }

        private void btnSajan_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
