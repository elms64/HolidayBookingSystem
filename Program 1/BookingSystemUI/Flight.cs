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
        private string departureAirport = "";
        private string arrivalAirport = "";
        private string departureDate = "";
        private string returnDate = "";


        private const string ConsoleAppUrl = "http://localhost:8080";


        public Flight()
        {
            InitializeComponent();
        }

        private async void Flight_Load(object sender, EventArgs e)
        {
            string message = "SEND_FLIGHTS";

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectFlight_Click(object sender, EventArgs e)
        {

        }

        private void DepartureAirport_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            departureAirport = DepartureAirport.Text;
            arrivalAirport = ArrivingAirport.Text;
            departureDate = DepartingDate.Value.ToString("yyyy-MM-dd");
            returnDate = ReturnDate.Value.ToString("yyyy-MM-dd");
        }

        private void ArrivingAirport_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartingDate_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
