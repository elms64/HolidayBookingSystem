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
using BookingSystemUI.Model;
using BookingSystemUI.UI.UIUtils;

namespace BookingSystemUI
{
    public partial class Basket : Form
    {

        private MainMenu mainForm;
        private Booking booking;

        private string selectedCountry;
        private string selectedOrigin;
        private int selectedOriginID;
        private int selectedCountryID;
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;


        public Basket(Booking booking, MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.booking = booking;

            //MessageBox.Show("Test"); //Testbox


            String labelText = $"Flight ID: {booking.Flight.FlightID}, \n" +
                $"From Country: {booking.FlightDetails.ArrivalCountry.Name},\n" +
                $"To Country: {booking.FlightDetails.DepartureCountry.Name},\n";
            Label label = Utils.createLabelWithLabelText(labelText);
            Panel panel = Utils.createPanel(0, flightPanelInfo, label);

            String labelText1 = $"Hotel ID: {booking.Hotel.HotelID}, " +
              $"Name: {booking.Hotel.HotelName},\n " +
              $"Address: {booking.Hotel.AddressLine1},\n" +
              $" City: {booking.Hotel.City},\n" +
              $" Postcode: {booking.Hotel.Postcode},\n" +
              $" Phone No:{booking.Hotel.PhoneNumber}";

            Label label1 = Utils.createLabelWithLabelText(labelText1);
            Panel panel1 = Utils.createPanel(0, hotelPanelInfo, label1);

            String labelText2 = $"Vehicle ID: {booking.Vehicle.VehicleID},\n " +
              $"Vehicle Type: {booking.Vehicle.VehicleType},\n " +
              $"Price Per Day: {booking.Vehicle.PricePerDay},\n";
            Label label2 = Utils.createLabelWithLabelText(labelText2);
            Panel panel2 = Utils.createPanel(0, vehiclePanelInfo, label2);

            String labelText3 = $"Insurance ID: {booking.Insurance.InsuranceID},\n " +
              $"Insurance Type: {booking.Insurance.InsuranceType},\n " +
              $"Pay Per Day: {booking.Insurance.PricePerDay},\n";
            Label label3 = Utils.createLabelWithLabelText(labelText3);
            Panel panel3 = Utils.createPanel(0, insurancePanelInfo, label3);



            /*
            // Assign the values to the class members
            this.selectedCountry = selectedCountry;
            this.selectedOrigin = selectedOrigin;
            this.selectedOriginID = selectedOriginID;
            this.selectedCountryID = selectedCountryID;
            this.selectedDepartureDate = selectedDepartureDate;
            this.selectedReturnDate = selectedReturnDate;

            MessageBox.Show($"btnNext_Click:\nselectedCountry: {selectedCountry}\nselectedOrigin: {selectedOrigin}\nselectedOriginID: {selectedOriginID}\nselectedCountryID: {selectedCountryID}");
            */
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
                    svbtch.SaveBatchProcess(jsonPayload, guid);
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
