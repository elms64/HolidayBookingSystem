using BookingSystemUI.Model;
using BookingSystemUI.Service;
using BookingSystemUI.UI.UIUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookingSystemUI.UI
{
    public partial class FlightUI : Form
    {
        private FlightServiceImpl flightService;
        private Booking booking;
        private MainMenu mainForm;


        public FlightUI(Booking booking, MainMenu mainForm)
        {
            InitializeComponent();
            this.flightService = new FlightServiceImpl();
            this.Load += Flight_Load;
            this.booking = booking;
            this.mainForm = mainForm;



        }

        private async void Flight_Load(object sender, EventArgs e)
        {
            Task<List<Flight>> taskFlight = flightService.GetFlight(booking.FlightDetails);
            await taskFlight;
            List<Flight> flights = taskFlight.Result;

            //MessageBox.Show(flights.ToString());
            int yOffset = 0;
            foreach (var flight in flights)
            {
                String labelText = $"Booked Seats: {flight.BookedSeats}, " +
                    $"Departur Date Time: {flight.DepartureDateTime}, " +
                    $"Arrival Date Time: {flight.ArrivalDateTime}, " +
                    $"Flight Cost: {flight.FlightCost}";
                Label label = Utils.createLabelWithLabelText(labelText);
                Panel panel = Utils.createPanel(yOffset, flightPanel, label);
                yOffset += panel.Height;

                panel.Click += (sender, e) => Panel_Click(sender, e, flight);
            }


        }

        public void Panel_Click(object sender, EventArgs e, Flight flight)
        {
            MessageBox.Show("Flight Selected");
            booking.Flight = flight;
            flightPanel.Visible = false;
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            HotelUI hotelUI = new HotelUI(booking, mainForm);

            mainForm.ShowFormInMainPanel(hotelUI);
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
