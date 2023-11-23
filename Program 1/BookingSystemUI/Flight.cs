using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingSystemUI.Form1;

namespace BookingSystemUI
{
    public partial class Flight : Form
    {




        private const string ConsoleAppUrl = "http://localhost:8080";
        private int selectedOriginID;
        private int selectedCountryID;
        private string selectedCountry;


        public Flight(string selectedCountry, DateTime selectedDepartureDate, string selectedReturnDate, string selectedOrigin, int selectedOriginID, int selectedCountryID)
        {
            InitializeComponent();

            this.selectedCountryID = selectedCountryID;
            this.selectedCountry = selectedCountry;
            this.selectedOriginID = selectedOriginID;
            lblSelectedCountryUpdate.Text = selectedCountry;
            lblSelectedDepartureDateUpdate.Text = selectedDepartureDate.ToShortDateString();
            lblSelectedReturnDateUpdate.Text = selectedReturnDate;
            lblOriginCountryUpdate.Text = selectedOrigin;
            lblOriginIdDEBUG.Text = selectedOriginID.ToString();
        }

        private async void Flight_Load(object sender, EventArgs e)
        {
            try
            {
                await SendRequest("SELECTED_ORIGINID", this.selectedOriginID);
                await SendRequest("SELECTED_COUNTRYID", this.selectedCountryID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private async Task SendRequest(string messageType, int value)
        {
            string message = $"{messageType}:{value}";

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
                            // Load the received flight data to the front end.
                            var responseData = await response.Content.ReadAsStringAsync();
                            // TODO: Deserialize and process the responseData
                        }
                        else
                        {
                            Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        }
                    }
                    else
                    {
                        // Timeout occurred, show a message
                        MessageBox.Show($"No response received within the specified time for message: {message}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                Console.WriteLine($"HTTP Request Error Details: {ex}");
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
                Console.WriteLine($"Task Canceled Error Details: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine($"Error Details: {ex}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectFlight_Click(object sender, EventArgs e)
        {

        }
    }
}
