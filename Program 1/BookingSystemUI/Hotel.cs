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

            //Populate hotel data.

            try
            {
                await SendRequest("SEARCH_HOTEL_BY_COUNTRY", this.selectedCountryID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        private async Task SendRequest(string messageType, int value)
        {
            //pass the message and the selectedCountry/OriginID
            string message = $"{messageType}:{value}";

            try
            {
                // Create a new HTTPclient
                using (HttpClient client = new HttpClient())
                {
                    // Add headers to the client, not 100% necessary, but for a polished finish they should probably be present in all of them
                    client.DefaultRequestHeaders.Add("CountryID", selectedCountryID.ToString());

                    // Data variable has the message passed in.
                    var data = new StringContent(message, Encoding.UTF8, "application/json");

                    // Data is actually sent here.
                    Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                    // Use Task.WhenAny to wait for the response or a delay
                    Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3))); // Adjust the timeout duration as needed


                    if (completedTask == responseTask)
                    {
                        // Response received within the timeout
                        HttpResponseMessage response = await responseTask;

                        // If the response is successful
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
