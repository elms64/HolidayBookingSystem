using BookingSystemUI.Model;
using BookingSystemUI.Service;
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
using static BookingSystemUI.SelectAirportUI;
using static BookingSystemUI.Form1;
using BookingSystemUI.UI;

namespace BookingSystemUI
{

    public partial class SelectAirportUI : Form
    {
        // Variables
        private MainMenu mainForm; 
        private DateTime selectedDepartureDate;
        private IAirportService airportService;
        private Booking booking;



        // Constructor
        // This receives the data from BookingInit.
        public SelectAirportUI(Booking booking, MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            departureAirportsPanel.AutoScroll = true;
            this.airportService = new AirportServiceImpl();
            this.booking = booking;



            // updates the labels with given variables, mostly for debugging / outputting data to the user.
            lblSelectedCountryUpdate.Text = booking.FlightDetails.ArrivalCountry.Name;
            lblOriginCountryUpdate.Text = booking.FlightDetails.DepartureCountry.Name;
            lblSelectedDepartureDateUpdate.Text = selectedDepartureDate.ToShortDateString();
            lblOriginIdDEBUG.Text = booking.FlightDetails.ArrivalCountry.ID.ToString();
        }


        private async void Flight_Load(object sender, EventArgs e)
        {

            if (booking != null)
            {
                Task<AirportInfo> airportInfoTask = airportService.GetAirports(booking.FlightDetails.DepartureCountry, booking.FlightDetails.ArrivalCountry);
                await airportInfoTask;

                AirportInfo airportInfo = airportInfoTask.Result;


                if (airportInfo != null)
                {
                    // Load departure airports
                    LoadPanelForDepartureAirport(airportInfo);

                    // Load arrival airports
                    LoadPanelForArrivalAirport(airportInfo);
                }

            }
        }

        private void LoadPanelForDepartureAirport(AirportInfo airportInfo) //First Airport, Current loaction
        {
            int yOffset = 0;
            try
            {
                // Create a new panel for each origin airport
                foreach (var originAirport in airportInfo.DepartureAirports)
                {
                    // Create a new panel
                    Panel panel = createPanel(originAirport, "departure", yOffset, departureAirportsPanel);
                    // Increment the y-coordinate for the next panel
                    yOffset += panel.Height;
                    arrivalAirportsPanel.Visible = false;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading departure airports: {ex.Message}");
            }
        }


        private void LoadPanelForArrivalAirport(AirportInfo airportInfo) //2nd airport, destination airport
        {
            int yOffset = 0;
            try
            {
                // Create a new panel for each destination airport
                foreach (var destinationAirport in airportInfo.ArrivalAirports)
                {
                    // Create a new panel
                    Panel panel = createPanel(destinationAirport, "arrival", yOffset, arrivalAirportsPanel);
                    // Increment the y-coordinate for the next panel
                    yOffset += panel.Height;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading arrival airports: {ex.Message}");
            }
        }


        private Panel createPanel(Airport airport, String arrivalOrDeparture, int yOffset, Panel outerPanel)
        {

            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new Size(850, 100);
            panel.BackColor = Color.White; // Sajan Test
            panel.Enabled = true; // Sajan Test

            // Create a label to display airport information
            Label label = new Label();

            label.Text = $"AirportID: {airport.ID}, CountryID: {airport.CountryID}, AirportName: {airport.Name}";
            label.AutoSize = true;

            // associate airport with panel using tag property
            panel.Tag = airport;

            // Set the location of the panel
            panel.Location = new Point(0, yOffset);

            // Add the label to the panel
            panel.Controls.Add(label);

            // Attach the click event to the panel
            panel.Click += (sender, e) => Panel_Click(sender, e, arrivalOrDeparture);

            // Add the panel to outerPanel
            outerPanel.Controls.Add(panel);

            // Make outerPanel scrollable
            outerPanel.AutoScroll = true;

            return panel;
        }

        //This will make the panel clickable.
        private void Panel_Click(object sender, EventArgs e, string airportType)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                // Extract airport information
                Airport airportInfo = clickedPanel.Tag as Airport;

                // Perform other actions with the airportInfo and selectedAirportInfo if needed
                if (airportInfo != null)
                {
                    MessageBox.Show($"Panel clicked!\n{airportInfo}\nSelected {airportType}");

                    // You can use airportInfo and selectedAirportInfo as needed, such as storing them in variables
                    if (airportType == "departure")
                    {
                        lbshowdeparture.Text = airportInfo.Name;
                        booking.FlightDetails.DepartureAirportID = airportInfo.ID;
                        departureAirportsPanel.Visible = false;
                        arrivalAirportsPanel.Visible = true;
                    }
                    else if (airportType == "arrival")
                    {
                        booking.FlightDetails.ArrivalAirportID = airportInfo.ID;
                        lbshowarrival.Text = airportInfo.Name;
                        departureAirportsPanel.Visible = false;
                        arrivalAirportsPanel.Visible = false;
                    }
                }
            }
        }


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

        private void btnNext_Click(object sender, EventArgs e)
        {

            MessageBox.Show(booking.ToString());



            SelectFlightUI selectFlightUI = new SelectFlightUI(booking);
            mainForm.ShowFormInMainPanel(selectFlightUI);

            

            // Close the BookingInit form if needed
            this.Close();
        }
    }
}
