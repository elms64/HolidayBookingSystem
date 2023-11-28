using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingSystemUI.Form1;


namespace BookingSystemUI
{
    public partial class BookingInit : Form
    {
        private MainMenu mainForm;
        private Hotel Hotel;

        private const string ConsoleAppUrl = "http://localhost:8080";

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
                //MessageBox.Show("Invalid Duration : Duration entered was too high.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Retrieve both the selected name and ID for comboBoxCountry
            KeyValuePair<string, int>? selectedCountryItem = comboBoxCountry.SelectedItem as KeyValuePair<string, int>?;
            string selectedCountry = selectedCountryItem?.Key;
            int selectedCountryID = selectedCountryItem?.Value ?? -1; // Default value if null

            // Retrieve both the selected name and ID for comboBoxOrigin
            KeyValuePair<string, int>? selectedOriginItem = comboBoxOrigin.SelectedItem as KeyValuePair<string, int>?;
            string selectedOrigin = selectedOriginItem?.Key;
            int selectedOriginID = selectedOriginItem?.Value ?? -1; // Default value if null

            DateTime selectedDepartureDate = dateTimePickerStart.Value;
            string selectedReturnDate = lblReturnDateUpdate.Text;

            // Create an instance of the Flight form and pass the values
            Flight flight = new Flight(selectedCountry, selectedDepartureDate, selectedReturnDate, selectedOrigin, selectedOriginID, selectedCountryID, mainForm);

            // Show the Flight form
            mainForm.ShowFormInMainPanel(flight);

            // Close the BookingInit form if needed
            this.Close();
        }

        private void lblReturnDateUpdate_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
