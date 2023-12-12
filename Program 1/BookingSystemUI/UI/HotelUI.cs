using BookingSystemUI.Model;
using BookingSystemUI.Service;
using BookingSystemUI.UI.UIUtils;
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

    public partial class HotelUI : Form
    {



        //Variables
        private Booking booking;
        private MainMenu mainForm;
        private HotelService hotelService;

        public HotelUI(Booking booking, MainMenu mainForm)
        {

            InitializeComponent();

            MessageBox.Show(booking.ToString()); // Check if this shows the correct value
            this.mainForm = mainForm;  // Ensure that mainForm is assigned here.
            this.hotelService = new HotelService();
            this.Load += Hotel_Load;
            this.booking = booking;
        }

        private async void Hotel_Load(object sender, EventArgs e)
        {
            if (booking != null)
            {
                Task<List<Hotel>> hotelTask = hotelService.GetHotels(booking.FlightDetails.ArrivalCountry);
                await hotelTask;

                List<Hotel> hotels = hotelTask.Result;

                int yOffset = 8;
                foreach (var hotel in hotels)
                {
                    String labelText = $"Hotel Name: {hotel.HotelName}," +
                        $"City: {hotel.City}, " +
                        $"Rating: {hotel.Rating}, " +
                        $"Phone Number: {hotel.PhoneNumber}";
                    Label label = Utils.createLabelWithLabelText(labelText);
                    Panel panel = Utils.createPanel(yOffset, hotelPanel, label);
                    yOffset += panel.Height;

                    panel.Click += (sender, e) => Panel_Click(sender, e, hotel);
                }
            }
            /* lblSelectedCountry.Text = selectedCountry;
            lblSelectedOrigin.Text = selectedOrigin;
            lblCountryID.Text = selectedCountryID.ToString();
            lblOriginID.Text = selectedOriginID.ToString();
            lblSelectedReturnDate.Text = selectedReturnDate;
            lblSelectedDepartureDate.Text = selectedDepartureDate.ToString();
           */

            // Add code for GET request. No need to send CountryID or anything - has been remembered from flight form.
            // Populate hotel data.


        }

        public void Panel_Click(object sender, EventArgs e, Hotel hotel)
        {
            booking.Hotel = hotel;
            MessageBox.Show(hotel.ToString());
            hotelPanel.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            VehicleUI vehicleUI = new VehicleUI(booking, mainForm);

            mainForm.ShowFormInMainPanel(vehicleUI);
            this.Close();


            /*
            CarRentalUI carRental = new CarRentalUI(booking, mainForm);

            // Show the Flight form
            mainForm.ShowFormInMainPanel(carRental);

            // Close the BookingInit form if needed
            this.Close();
            */
        }
    }
}
