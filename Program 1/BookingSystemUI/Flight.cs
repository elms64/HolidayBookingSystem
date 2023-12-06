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
    private

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
            pnlFlight.AutoScroll = true;



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

        public class AirportInfo
        {
            public List<Airport> OriginAirports { get; set; }
            public List<Airport> DestinationAirports { get; set; }
        }





        private async void Flight_Load(object sender, EventArgs e)
        {
            try
            {
                // Create a new HTTP client
                string targetURL = ConsoleAppUrl + "/Airport";
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
                        string flightAirportJsonResponse = await response.Content.ReadAsStringAsync();

                        // Log the response data to the console for debugging
                        Console.WriteLine($"Received response data: {flightAirportJsonResponse}");

                        // Deserialize the JSON response
                        var airportInfo = JsonSerializer.Deserialize<AirportInfo>(flightAirportJsonResponse);

                        // Clear existing controls in pnlFlight if needed
                        pnlFlight.Controls.Clear();

                        int yOffset = 0;

                        // Create a new panel for each origin airport
                        foreach (var originAirport in airportInfo.OriginAirports)
                        {
                            MessageBox.Show("test");

                            // Create a new panel
                            Panel panel = new Panel();
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            panel.Size = new Size(850, 100);

                            // Create a label to display airport information
                            Label label = new Label();
                            label.Text = $"AirportID: {originAirport.AirportID}, CountryID: {originAirport.CountryID}, AirportName: {originAirport.AirportName}";
                            label.AutoSize = true;

                            // Set the location of the panel
                            panel.Location = new Point(0, yOffset);

                            // Add the label to the panel
                            panel.Controls.Add(label);

                            // Add the panel to pnlFlight
                            pnlFlight.Controls.Add(panel);

                            // Increment the y-coordinate for the next panel
                            yOffset += panel.Height;
                        }

                        // Make pnlFlight scrollable
                        pnlFlight.AutoScroll = true;
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

        // Maybe make a new button or something for select airport, store as variables. 
        // Next you need to send us the dates, selected airport IDs. 
        // Then we'll send you flights.

        // Looking at the code above, add /Flight instead of /Airport

        // Name the headers : 
        // selectedDepartureAirportID
        // selectedArrivalAirportID
        // selectedDepartureDate
        // selectedArrivalDate


        private void DisplayAirports(string json)
        {
            try
            {
                List<AirportData> airports = JsonSerializer.Deserialize<List<AirportData>>(json);

                flwPnlFlight.Controls.Clear();

                if (airports != null && airports.Any())
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
                else
                {
                    MessageBox.Show("No airport data received.", "Airport Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error deserializing JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AirportPanel_Click(object sender, EventArgs e)
        {
            // This method is called when a panel (flight) is clicked
            if (sender is Panel panel)
            {
                // Access the AirportID from the Tag property
                string airportID = panel.Tag?.ToString();

                // Do something with the selected flight (airport)
                MessageBox.Show($"Flight selected: {airportID}", "Flight Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
