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
        private string selectedOrigin;

        private MainMenu mainForm;
      
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;




        //This receives the data from BookingInit.
        public Flight(string selectedCountry, DateTime selectedDepartureDate, string selectedReturnDate, string selectedOrigin, int selectedOriginID, int selectedCountryID, MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
           

            // updates the labels with given variables, mostly for debugging / outputting data to the user.
            this.selectedCountryID = selectedCountryID;
            this.selectedCountry = selectedCountry;
            this.selectedOriginID = selectedOriginID;
            this.selectedReturnDate = selectedReturnDate;
            lblSelectedCountryUpdate.Text = selectedCountry;
            lblOriginCountryUpdate.Text = selectedOrigin;
            lblSelectedDepartureDateUpdate.Text = selectedDepartureDate.ToShortDateString();
            lblSelectedReturnDateUpdate.Text = selectedReturnDate;
            lblOriginCountryUpdate.Text = selectedOrigin;
            lblOriginIdDEBUG.Text = selectedOriginID.ToString();
            
            this.selectedDepartureDate = selectedDepartureDate; // Assign the value

        }

        private async void Flight_Load(object sender, EventArgs e)
        {
            // When the form loads, run SendRequest, passing in the variables selectedOriginID and selectedCountryID
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
            //pass the message and the selectedCountry/OriginID
            string message = $"{messageType}:{value}";

            try
            {
                // Create a new HTTPclient
                using (HttpClient client = new HttpClient())
                {
                    // Add headers to the client, not 100% necessary, but for a polished finish they should probably be present in all of them
                    client.DefaultRequestHeaders.Add("CountryID", selectedCountryID.ToString());
                    client.DefaultRequestHeaders.Add("OriginID", selectedOriginID.ToString());

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Retrieve both the selected name and ID for comboBoxCountry


            // Retrieve both the selected name and ID for comboBoxOrigin




            // Create an instance of the Flight form and pass the values
            string selectedOriginPass = lblOriginCountryUpdate.Text;
            Hotel hotel = new Hotel(selectedCountry, selectedOriginPass, selectedOriginID, selectedCountryID, mainForm, selectedDepartureDate, selectedReturnDate);

            MessageBox.Show($"btnNext_Click:\nselectedCountry: {selectedCountry}\nselectedOrigin: {selectedOrigin}\nselectedOriginID: {selectedOriginID}\nselectedCountryID: {selectedCountryID}");

            // Show the Flight form
            mainForm.ShowFormInMainPanel(hotel);

            // Close the BookingInit form if needed
            this.Close();


        }
    }
}
