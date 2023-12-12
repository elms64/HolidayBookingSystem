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
using static BookingSystemUI.AirportUI;
using static BookingSystemUI.Form1;
using BookingSystemUI.UI;
using BookingSystemUI.UI.UIUtils;

namespace BookingSystemUI
{

    public partial class AirportUI : Form
    {
        // Variables
        private MainMenu mainForm;
        private DateTime selectedDepartureDate;
        private IAirportService airportService;
        private Booking booking;
        private DateTime selectedReturnDate;



        // Constructor
        // This receives the data from BookingInit.
        public AirportUI(Booking booking, MainMenu mainForm)
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
            lblSelectedReturnDateUpdate.Text = selectedReturnDate.ToShortDateString();
        }


        private async void Airport_Load(object sender, EventArgs e)
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
                    // Create label 
                    String labelText = $"AirportID: {originAirport.ID}, CountryID: {originAirport.CountryID}, AirportName: {originAirport.Name}";
                    Label label = Utils.createLabelWithLabelText(labelText);
                    // Create a new panel
                    Panel panel = Utils.createPanel(yOffset, departureAirportsPanel, label);
                    // associate airport with panel using tag property
                    panel.Tag = originAirport;
                    // Attach the click event to the panel
                    panel.Click += (sender, e) => Panel_Click(sender, e, "departure");
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
                    // Create label 
                    String labelText = $"AirportID: {destinationAirport.ID}, CountryID: {destinationAirport.CountryID}, AirportName: {destinationAirport.Name}";
                    Label label = Utils.createLabelWithLabelText(labelText);
                    // Create a new panel
                    Panel panel = Utils.createPanel(yOffset, arrivalAirportsPanel, label);
                    // associate airport with panel using tag property
                    panel.Tag = destinationAirport;
                    // Attach the click event to the panel
                    panel.Click += (sender, e) => Panel_Click(sender, e, "arrival");
                    // Increment the y-coordinate for the next panel
                    yOffset += panel.Height;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading arrival airports: {ex.Message}");
            }
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
                    MessageBox.Show($"Airport Selected ");

                    // You can use airportInfo and selectedAirportInfo as needed, such as storing them in variables
                    if (airportType == "departure")
                    {
                        departureBox.Text = airportInfo.Name;
                        booking.FlightDetails.DepartureAirportID = airportInfo.ID;
                        departureAirportsPanel.Visible = false;
                        arrivalAirportsPanel.Visible = true;
                    }
                    else if (airportType == "arrival")
                    {
                        booking.FlightDetails.ArrivalAirportID = airportInfo.ID;
                        arrivalBox.Text = airportInfo.Name;
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

            // MessageBox.Show(booking.ToString());



            FlightUI flightUI = new FlightUI(booking, mainForm);
            mainForm.ShowFormInMainPanel(flightUI);



            // Close the BookingInit form if needed
            this.Close();
        }

        private void departureBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
