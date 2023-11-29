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
        // Variables
        private const string ConsoleAppUrl = "http://localhost:8080";
        private int selectedOriginID;
        private int selectedCountryID;
        private string selectedCountry;
        private string selectedOrigin;
        private MainMenu mainForm;
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;



        public class Airport
        {
            public int AirportID { get; set; }
            public int CountryID { get; set; }
            public string AirportName { get; set; }
        }

        // Constructor
        // This receives the data from BookingInit.
        public Flight(string selectedCountry, DateTime selectedDepartureDate, string selectedReturnDate, string selectedOrigin, int selectedOriginID, int selectedCountryID, MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            flwPnlFlight.AutoScroll = true;



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

            MessageBox.Show($"Selected Country ID: {selectedCountryID}\n" +
                $"Selected Country: {selectedCountry}\n" +
                $"Selected Origin ID: {selectedOriginID}\n" +
                $"Selected Return Date: {selectedReturnDate}\n" +
                $"Selected Origin: {selectedOrigin}\n" +
                $"Selected Departure Date: {selectedDepartureDate.ToShortDateString()}"
            );


        }

        public class AirportData
        {
            public int AirportName { get; set; }
            public string AirportID { get; set; }
        }


        private async void Flight_Load(object sender, EventArgs e)
        {
            try
            {
                // Create a new HTTP client
                string targetURL = ConsoleAppUrl + "/Flights"; // Assuming there is an endpoint for flight data
                using (HttpClient client = new HttpClient())
                {
                    // Add headers to the client
                    client.DefaultRequestHeaders.Add("OriginCountryID", selectedCountryID.ToString());
                    client.DefaultRequestHeaders.Add("DestinationCountryID", selectedOriginID.ToString());

                    // Log the headers before sending the request
                    Console.WriteLine($"Sending request to: {targetURL}");
                    Console.WriteLine($"Headers: CountryID={selectedCountryID}, OriginID={selectedOriginID}");

                    HttpResponseMessage response = await client.GetAsync(targetURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string flightJsonResponse = await response.Content.ReadAsStringAsync();
                        var airports = JsonSerializer.Deserialize<List<AirportData>>(flightJsonResponse);
                        DisplayAirports(airports);

                        // Log the response data to the console for debugging
                        Console.WriteLine($"Received response data: {flightJsonResponse}");

                        // Deserialize the JSON response


                        // Create a new panel for each origin airport


                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
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

        private void DisplayAirports(List<AirportData> airports)
        {
            foreach (var airport in airports)
            {
                MessageBox.Show("Test");
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new Size(300, 60);

                panel.Tag = airport.AirportID;

                

                Label airportNameLabel = new Label();
                airportNameLabel.Text = "Name: " + airport.AirportName;
                airportNameLabel.Location = new Point(10, 10);

                Label airportIDLabel = new Label();
                airportIDLabel.Text = "ID : " + airport.AirportID;
                airportIDLabel.Location = new Point(10, 30);

               

                panel.Controls.Add(airportNameLabel);
                panel.Controls.Add(airportIDLabel);

                flwPnlFlight.Controls.Add(panel);


            }
        }
        private async Task SendRequest(string messageType, int value)
        {

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
