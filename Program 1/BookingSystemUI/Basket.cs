using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Security.Cryptography;

namespace BookingSystemUI
{
    public partial class Basket : Form
    {

        private MainMenu mainForm;
        private string selectedCountry;
        private string selectedOrigin;
        private int selectedOriginID;
        private int selectedCountryID;
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;


        public Basket(string selectedCountry, string selectedOrigin, int selectedOriginID, int selectedCountryID, MainMenu mainForm, DateTime selectedDepartureDate, string selectedReturnDate)
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

        private void MainBasket_Click(object sender, EventArgs e)
        {
           
        }

        private void Basket_Load(object sender, EventArgs e)
        {

        }


        // Authored by @elms64
        // -----------------------------------------------------------------------------------------------------
        // Send transaction for processing by server (program 2). Uses unique ID and checksum calculations. 
        // https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/compute-hash-values

        // Initiate HTTP Client
        private static readonly HttpClient httpClient = new HttpClient();
        
        // Allow storage of an array of key value pairs into bookingData variable
        private Dictionary<string, string> bookingData = new Dictionary<string, string>();

        // User clicks "Send Booking" when happy with the basket to send to the server (p2)
        private async void SendBookingButton_Click(object sender, EventArgs e)
        {
            // Populate bookingData variable with the relevant form data
            bookingData["SelectedCountry"] = selectedCountry;
            bookingData["SelectedOrigin"] = selectedOrigin;
            bookingData["SelectedOriginID"] = selectedOriginID.ToString();
            bookingData["SelectedCountryID"] = selectedCountryID.ToString();
            bookingData["SelectedDepartureDate"] = selectedDepartureDate.ToString();
            bookingData["SelectedReturnDate"] = selectedReturnDate;
            string checksum = CalculateChecksum(JsonSerializer.Serialize(bookingData));
            bookingData["Checksum"] = checksum;

            // Call SendBookingTransaction with the populated bookingData
            await SendBookingTransaction(bookingData);
        }

        // Calculate a Checksum value for the booking content
        private string CalculateChecksum(string data)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        // Method for sending the transaction as a JSON file via HTTP Put
        private async Task SendBookingTransaction(Dictionary<string, string> bookingData)
        {
            try
            {
                // Location of Program 2 (BookingProcessor)
                string serverURL = "http://your-api-endpoint.com/booking";

                // Authorisation headers, assigns a GUID for transaction identification and validation
                Guid guid = Guid.NewGuid();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer YourAccessToken");
                httpClient.DefaultRequestHeaders.Add("X-Transaction-ID", guid.ToString());
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Convert the booking transaction to a JSON and send a PUT request
                string jsonPayload = JsonSerializer.Serialize(bookingData);
                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(serverURL, content);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Booking transaction sent successfully!");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");

                    // If request was unsuccessful then it will be saved into batch transactions
                    SaveBatches svbtch = new SaveBatches();
                    svbtch.SaveBatchProcess(jsonPayload);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        // -----------------------------------------------------------------------------------------------------




    }
}
