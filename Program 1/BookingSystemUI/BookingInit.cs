using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace BookingSystemUI
{
    public partial class BookingInit : Form
    {
        private MainMenu mainForm;
        private Hotel Hotel;
        private const string ConsoleAppUrl = "http://localhost:8080";
        private string selectedCountry;
        private int selectedCountryID;
        private string selectedOrigin;
        private int selectedOriginID;

        public class Country
        {
            public int CountryID { get; set; }
            public string CountryName { get; set; }
        }

        public BookingInit(MainMenu mainForm)
        {
            InitializeComponent();
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            txtBoxHowLong.TextChanged += txtBoxHowLong_TextChanged;
            this.mainForm = mainForm;
        }

        private async void BookingInit_Load(object sender, EventArgs e)
        {
            // Load countries into where to and where from combo boxes
            try
            {

                string targetURL = ConsoleAppUrl + "/Country";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        var countries = JsonSerializer.Deserialize<List<Country>>(responseData);
                        foreach (var country in countries)
                        {
                            comboBoxCountry.Items.Add($"{country.CountryID}: {country.CountryName}");
                            comboBoxOrigin.Items.Add($"{country.CountryID}: {country.CountryName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
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
            // Retrieve both the selected country and origin
            string selectedCountryItem = comboBoxCountry.SelectedItem as string;
            ParseCountry(selectedCountryItem, out selectedCountryID, out selectedCountry);

            string selectedOriginItem = comboBoxOrigin.SelectedItem as string;
            ParseCountry(selectedOriginItem, out selectedOriginID, out selectedOrigin);

            DateTime selectedDepartureDate = dateTimePickerStart.Value;
            string selectedReturnDate = lblReturnDateUpdate.Text;

            MessageBox.Show($"Selected Country ID: {selectedCountryID}\n" +
                          $"Selected Country: {selectedCountry}\n" +
                          $"Selected Origin ID: {selectedOriginID}\n" +
                          $"Selected Return Date: {selectedReturnDate}\n" +
                          $"Selected Origin: {selectedOrigin}\n" +
                          $"Selected Departure Date: {selectedDepartureDate.ToShortDateString()}");

            // Create an instance of the Flight form and pass the values
            Flight flight = new Flight(selectedCountry, selectedDepartureDate, selectedReturnDate, selectedOrigin, selectedOriginID, selectedCountryID, mainForm);

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
