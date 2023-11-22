using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystemUI
{
    public partial class Flight : Form
    {
        private string departureAirport = "";
        private string arrivalAirport = "";
        private string departureDate = "";
        private string returnDate = "";
        public Flight()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectFlight_Click(object sender, EventArgs e)
        {

        }

        private void DepartureAirport_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            departureAirport = DepartureAirport.Text;
            arrivalAirport = ArrivingAirport.Text;
            departureDate = DepartingDate.Value.ToString("yyyy-MM-dd");
            returnDate = ReturnDate.Value.ToString("yyyy-MM-dd");
        }

        private void ArrivingAirport_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartingDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
