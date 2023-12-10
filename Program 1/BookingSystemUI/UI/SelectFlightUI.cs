using BookingSystemUI.Model;
using BookingSystemUI.Service;
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
    public partial class SelectFlightUI : Form
    {
        private FlightServiceImpl flightService;
        private Booking booking;
        
        public SelectFlightUI(Booking booking)
        {
            InitializeComponent();
            this.flightService = new FlightServiceImpl();
            this.Load += Flight_Load;
            this.booking = booking;
          


        }

        private async void Flight_Load(object sender, EventArgs e)
        {
            Task<Flight> taskFlight = flightService.GetFlight(booking.FlightDetails);
            await taskFlight;
            Flight flight = taskFlight.Result;

            MessageBox.Show(flight.ToString());
           
        }

    }
}
