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

        public BookingInit(MainMenu mainForm)
        {
            InitializeComponent();
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            txtBoxHowLong.TextChanged += txtBoxHowLong_TextChanged;
            this.mainForm = mainForm;
        }

        private async void BookingInit_Load(object sender, EventArgs e)
        {
            // this is the content being sent to program 2, in plaintext.
            string message = "SEND_COUNTRY";


            try
            {
                // create a new HttpClient called client, which is configured and then sent off.
                using (HttpClient client = new HttpClient())
                {
                    //create a variable called data, this includes the message, and a couple other guff bits which you don't need to touch
                    var data = new StringContent(message, Encoding.UTF8, "application/json");

                    // This is where data is actually sent
                    Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                    // Use Task.WhenAny to wait for the response or a delay
                    Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3))); // Adjust the timeout duration as needed

                    // if it gets a response, run this block of code, put whatever in here, should probably be formatting data
                    // like done in this example, population of comboBoxCountry and comboBoxOrigin
                    if (completedTask == responseTask)
                    {
                        // Response received within the timeout
                        HttpResponseMessage response = await responseTask;
                        
                        // If the response is a successStatusCode, run this code
                        if (response.IsSuccessStatusCode)
                        {
                            // the following two lines, convert the json response into a list called countries.
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            var countries = JsonSerializer.Deserialize<List<CountryData>>(jsonResponse);

                            // Clear existing items in the comboBoxCountry
                            comboBoxCountry.Items.Clear();

                            // Add countries to comboBoxCountry, for each item in countries, it will add a new listing
                            foreach (var country in countries)
                            {
                                comboBoxCountry.Items.Add(new KeyValuePair<string, int>(country.CountryName, country.CountryID));
                                comboBoxOrigin.Items.Add(new KeyValuePair<string, int>(country.CountryName, country.CountryID));
                                // Assuming CountryData has a property named CountryName
                            }

                            // Sort the items alphabetically
                            comboBoxCountry.Sorted = true;
                            comboBoxOrigin.Sorted = true;
                        }
                        else
                        {
                            Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        }
                    }
                    else
                    {
                        // Timeout occurred, show a message
                        MessageBox.Show("No response received within the specified time.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
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
