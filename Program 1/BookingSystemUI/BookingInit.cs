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
            string message = "SEND_COUNTRY";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new StringContent(message, Encoding.UTF8, "application/json");
                    Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                    // Use Task.WhenAny to wait for the response or a delay
                    Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3))); // Adjust the timeout duration as needed

                    if (completedTask == responseTask)
                    {
                        // Response received within the timeout
                        HttpResponseMessage response = await responseTask;
                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            var countries = JsonSerializer.Deserialize<List<CountryData>>(jsonResponse);

                            // Clear existing items in the comboBoxCountry
                            comboBoxCountry.Items.Clear();

                            // Add countries to comboBoxCountry
                            foreach (var country in countries)
                            {
                                comboBoxCountry.Items.Add(country.CountryName);
                                // Assuming CountryData has a property named CountryName
                            }

                            // Sort the items alphabetically
                            comboBoxCountry.Sorted = true;
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
                if (duration > 0 && duration <= 10000) // Adjust the upper limit as needed
                {
                    DateTime returnDate = departureDate.AddDays(duration);
                    lblReturnDateUpdate.Text = returnDate.ToShortDateString();
                }
                else
                {
                    // Revert the value to a default (e.g., 7)
                    txtBoxHowLong.Text = "";
                    lblReturnDateUpdate.Text = "Duration must be between 1 and 1000 days.";
                }
            }
            else
            {
                // Revert the value to a default (e.g., 7)
                txtBoxHowLong.Text = "";
                lblReturnDateUpdate.Text = "Invalid duration";
                //MessageBox.Show("Invalid Duration : Duration entered was too high.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            Flight flight = new Flight();
            mainForm.ShowFormInMainPanel(flight);

        }
    }

}
