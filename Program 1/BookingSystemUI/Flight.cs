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

        public Flight(string selectedCountry, DateTime selectedDepartureDate, string selectedReturnDate, string selectedOrigin, int selectedOriginID)
        {
            InitializeComponent();

            this.selectedOriginID = selectedOriginID;
            lblSelectedCountryUpdate.Text = selectedCountry;
            lblSelectedDepartureDateUpdate.Text = selectedDepartureDate.ToShortDateString();
            lblSelectedReturnDateUpdate.Text = selectedReturnDate;
            lblOriginCountryUpdate.Text = selectedOrigin;
            lblOriginIdDEBUG.Text = selectedOriginID.ToString();


        }

        private async void Flight_Load(object sender, EventArgs e)
        {
            
            string message = "REQUEST_FLIGHTS_BY_COUNTRYID : " + this.selectedOriginID;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new StringContent(message, Encoding.UTF8, "application/json");
                    Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                    // Use Task.WhenAny to wait for the response or a delay
                    Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3))); // Adjust the timeout duration as 

                    if (completedTask == responseTask)
                    {
                        // Response received within the timeout
                        HttpResponseMessage response = await responseTask;
                        if (response.IsSuccessStatusCode)
                        {
                            // Load to front end.
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
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Task Canceled Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
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
