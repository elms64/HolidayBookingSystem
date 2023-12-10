using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystemUI
{
    public partial class InsuranceUI : Form
    {
        private const string ConsoleAppUrl = "http://localhost:8080";


        private MainMenu mainForm;
        private string selectedCountry;
        private string selectedOrigin;
        private int selectedOriginID;
        private int selectedCountryID;
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;

        public InsuranceUI(string selectedCountry, string selectedOrigin, int selectedOriginID, int selectedCountryID, MainMenu mainForm, DateTime selectedDepartureDate, string selectedReturnDate)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Assign the values to the class members
            this.selectedCountry = selectedCountry;
            this.selectedOrigin = selectedOrigin;
            this.selectedOriginID = selectedOriginID;
            this.selectedCountryID = selectedCountryID;
            this.selectedDepartureDate = selectedDepartureDate;
            this.selectedReturnDate = selectedReturnDate;

            MessageBox.Show($"btnNext_Click:\nselectedCountry: {selectedCountry}\nselectedOrigin: {selectedOrigin}\nselectedOriginID: {selectedOriginID}\nselectedCountryID: {selectedCountryID}");
        }
        private async void Insurance_Load(object sender, EventArgs e)
        {
            try
            {
                await Send_Insurance("SEND_INSURANCE");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private async Task Send_Insurance(string messageType)
        {
            //pass the message and the selectedCountry/OriginID
            string message = messageType;

            try
            {
                // Create a new HTTPclient
                using (HttpClient client = new HttpClient())
                {

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

        private void SeearchInsurance_Click(object sender, EventArgs e)
        {

        }

        private void InsuranceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private async void btnNext_Click(object sender, EventArgs e)
        {

            try

            {   //This wont work because the insurance hasnt been selected yet. Will have to test
                //what has been selected, like how it does in form1.cs.

                int selectedInsuranceID = 69;

                // Actually this is just here so it can be tested. Remove this int when you have a proper
                // system to detect what has been chosen.
                await Send_Selected_Insurance("Insurance_SELECTED_ID", selectedInsuranceID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }



            Basket basket = new Basket(selectedCountry, selectedOrigin, selectedOriginID, selectedCountryID, mainForm, selectedDepartureDate, selectedReturnDate);

            // Show the Flight form
            mainForm.ShowFormInMainPanel(basket);

            // Close the BookingInit form if needed
            this.Close();
        }

        private async Task Send_Selected_Insurance(string messageType, int value)
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
    }
}
