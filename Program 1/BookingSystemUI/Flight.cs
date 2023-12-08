using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata;
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
        private string selectedDepartureAirportInfo;
        private string selectedArrivalAirportInfo;


        private string GetAirportInfoFromPanel(Panel panel)
        {
            try
            {
                // Find the Label control inside the Panel
                Label label = panel.Controls.OfType<Label>().FirstOrDefault();

                if (label != null)
                {
                    // Extract and return the airport information from the Label's Text property
                    return label.Text;
                }
                else
                {
                    // Handle the case where the Label control is not found
                    return "Airport information not available";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the extraction
                Console.WriteLine($"An error occurred while extracting airport information: {ex.Message}");
                return "Error extracting airport information";
            }
        }

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
        //Testing method for loading data



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

                        // Load departure airports
                        LoadDepartureAirports(airportInfo, selectedDepartureAirportInfo);
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

        private void DisplayAirports(string json)
        {
            try
            {
                List<AirportData> airports = JsonSerializer.Deserialize<List<AirportData>>(json);

                if (airports != null && airports.Any())
                {
                    foreach (var airport in airports)
                    {
                        Panel panel = new Panel();
                        panel.BorderStyle = BorderStyle.FixedSingle;


                        panel.Tag = airport.AirportID;

                        /* // Set properties for interactivity
                         panel.Enabled = true; //Sajan Test
                         panel.Cursor = Cursors.Hand; //Sajan Test

                         Click event to select the panel
                         panel.Click += AirportPanel_Click;//Sajan Test*/

                        Label airportNameLabel = new Label();
                        airportNameLabel.Text = "Name: " + airport.AirportName;
                        airportNameLabel.Location = new Point(10, 10);

                        airportNameLabel.Enabled = true; //Sajan
                        airportNameLabel.Cursor = Cursors.Hand; //Sajan

                        Label airportIDLabel = new Label();
                        airportIDLabel.Text = "ID : " + airport.AirportID;
                        airportIDLabel.Location = new Point(10, 30);

                        // Add MouseClick event to labels to trigger the click event of the panel
                        // airportNameLabel.MouseClick += (s, e) => AirportPanel_Click(panel, e); //Sajan Test
                        // airportNameLabel.MouseClick += (s, e) => AirportPanel_Click(panel, e); //Sajan Test

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

        private void LoadDepartureAirports(AirportInfo airportInfo, string selectedAirportInfo)
        {
            try
            {
                int yOffset = 0;

                // Create a new panel for each origin airport
                foreach (var originAirport in airportInfo.OriginAirports)
                {
                    // Create a new panel
                    MessageBox.Show("UK");
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Size = new Size(850, 100);
                    panel.BackColor = Color.White; // Sajan Test
                    panel.Enabled = true; // Sajan Test

                    // Create a label to display airport information
                    Label label = new Label();
                    label.Text = $"AirportID: {originAirport.AirportID}, CountryID: {originAirport.CountryID}, AirportName: {originAirport.AirportName}";
                    label.AutoSize = true;

                    // Set the location of the panel
                    panel.Location = new Point(0, yOffset);

                    // Add the label to the panel
                    panel.Controls.Add(label);

                    // Attach the click event to the panel
                    panel.Click += (sender, e) => Panel_Click(sender, e, selectedAirportInfo, "departure");

                    // Add the panel to pnlFlight
                    pnlFlight.Controls.Add(panel);

                    // Increment the y-coordinate for the next panel
                    yOffset += panel.Height;
                }

                // Make pnlFlight scrollable
                pnlFlight.AutoScroll = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading departure airports: {ex.Message}");
            }
        }


        private void LoadArrivalAirports(AirportInfo airportInfo, string selectedAirportInfo)
        {
            try
            {
                // Clear existing panels in pnlFlight
                pnlFlight.Controls.Clear();

                int yOffset = 0;

                // Create a new panel for each destination airport
                foreach (var destinationAirport in airportInfo.DestinationAirports)
                {
                    // Create a new panel
                    MessageBox.Show("UK");
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Size = new Size(850, 100);
                    panel.BackColor = Color.White; // Sajan Test
                    panel.Enabled = true; // Sajan Test

                    // Create a label to display airport information
                    Label label = new Label();
                    label.Text = $"AirportID: {destinationAirport.AirportID}, CountryID: {destinationAirport.CountryID}, AirportName: {destinationAirport.AirportName}";
                    label.AutoSize = true;

                    // Set the location of the panel
                    panel.Location = new Point(0, yOffset);

                    // Add the label to the panel
                    panel.Controls.Add(label);

                    // Attach the click event to the panel
                    panel.Click += (sender, e) => Panel_Click(sender, e, selectedAirportInfo, "arrival");

                    // Add the panel to pnlFlight
                    pnlFlight.Controls.Add(panel);

                    // Increment the y-coordinate for the next panel
                    yOffset += panel.Height;
                }

                // Make pnlFlight scrollable
                pnlFlight.AutoScroll = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading arrival airports: {ex.Message}");
            }
        }

        //This will make the panel clickable.
        private void Panel_Click(object sender, EventArgs e, string selectedAirportInfo, string airportType)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                // Extract airport information
                string airportInfo = GetAirportInfoFromPanel(clickedPanel);

                // Perform other actions with the airportInfo and selectedAirportInfo if needed
                if (!string.IsNullOrEmpty(airportInfo))
                {
                    MessageBox.Show($"Panel clicked!\n{airportInfo}\nSelected {airportType} Airport: {selectedAirportInfo}");

                    // You can use airportInfo and selectedAirportInfo as needed, such as storing them in variables
                    if (airportType == "departure")
                    {
                        selectedDepartureAirportInfo = airportInfo;
                        lbshowdeparture.Text = selectedDepartureAirportInfo;
                    }
                    else if (airportType == "arrival")
                    {
                        selectedArrivalAirportInfo = airportInfo;
                        lbshowarrival.Text = selectedArrivalAirportInfo;

                    }
                }
            }
        }

        /*string flightAirportJsonResponse = await response.Content.ReadAsStringAsync();

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
            panel.BackColor = Color.White; //Sajan Test
            panel.Enabled = true; //Sajan Test


            // Create a label to display airport information
            Label label = new Label();
            label.Text = $"AirportID: {originAirport.AirportID}, CountryID: {originAirport.CountryID}, AirportName: {originAirport.AirportName}";
            label.AutoSize = true;

            // Set the location of the panel
            panel.Location = new Point(0, yOffset);

            // Add the label to the panel
            panel.Controls.Add(label);

            panel.Click += Panel_Click;//allows the panel to be clicked

            // Add the panel to pnlFlight
            pnlFlight.Controls.Add(panel);

            // Increment the y-coordinate for the next panel
            yOffset += panel.Height;
        }

        // Make pnlFlight scrollable
        pnlFlight.AutoScroll = true;
    }*/

        // Maybe make a new button or something for select airport, store as variables. 
        // Next you need to send us the dates, selected airport IDs. 
        // Then we'll send you flights.

        // Looking at the code above, add /Flight instead of /Airport

        // Name the headers : 
        // selectedDepartureAirportID
        // selectedArrivalAirportID
        // selectedDepartureDate
        // selectedArrivalDate

        /* Delete later if sure we dont need it, left it for now
         private void AirportPanel_Click(object sender, EventArgs e) //Bogdan Test
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

         // Common event handler for panel click
         private void Panel_Click(object sender, EventArgs e) //Sajan Test
         {
             // Get the clicked panel
             Panel clickedPanel = sender as Panel;

             // Get the AirportID from the Tag property
             int airportID = (int)clickedPanel.Tag;

             // Now you can use the airportID as needed
             MessageBox.Show($"Panel with AirportID {airportID} clicked!");
         }

         private void Label_Click(object sender, EventArgs e)
         {
             // Get the clicked label
             Label clickedLabel = sender as Label;

             // Now you can use the label's properties or perform other actions
             MessageBox.Show($"Label with text '{clickedLabel.Text}' clicked!");
         }
         private void Panel_MouseEnter(object sender, EventArgs e) //Sajan Test
         {
             Panel enteredPanel = sender as Panel;
             enteredPanel.BackColor = Color.LightGray; // Change color when mouse enters
         }

         private void Panel_MouseLeave(object sender, EventArgs e) //Sajan Test
         {
             Panel leftPanel = sender as Panel;
             leftPanel.BackColor = SystemColors.Control; // Change back to default color when mouse leaves
         }
         private void Label_Click(object sender, EventArgs e) //Sajan Test
         {
             // Handle label click event
             Label clickedLabel = sender as Label;

             // Access the text of the clicked label
             string labelText = clickedLabel.Text;

             // Access the corresponding panel if needed
             Panel parentPanel = clickedLabel.Parent as Panel;

             // Access the AirportID from the panel's Tag property
             int airportID = (int)parentPanel.Tag;

             // Now you can use the labelText, airportID, or perform other actions
             MessageBox.Show($"Label with text '{labelText}' in panel with AirportID {airportID} clicked!");
         }*/

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
