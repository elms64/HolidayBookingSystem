using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BookingSystemUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Startbooking_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.TopLevel = false;
            MainPanel.Controls.Add(flight);
            flight.Show();
            flight.Size = MainPanel.Size;
            flight.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HotelBooking_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.TopLevel = false;
            MainPanel.Controls.Add(hotel);
            hotel.Show();
            hotel.Size = MainPanel.Size;
            hotel.BringToFront();
        }

        private void CarBooking_Click(object sender, EventArgs e)
        {
            CarRental carRental = new CarRental();
            carRental.TopLevel = false;
            MainPanel.Controls.Add(carRental);
            carRental.Show();
            carRental.Size = MainPanel.Size;
            carRental.BringToFront();
        }

        private void InsuranceBooking_Click(object sender, EventArgs e)
        {
            Insurance insurance = new Insurance();
            insurance.TopLevel = false;
            MainPanel.Controls.Add(insurance);
            insurance.Show();
            insurance.Size = MainPanel.Size;
            insurance.BringToFront();
        }

        private void Basket_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.TopLevel = false;
            MainPanel.Controls.Add(basket);
            basket.Show();
            basket.Size = MainPanel.Size;
            basket.BringToFront();
        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            MainMenu2 mainMenu2 = new MainMenu2();
            mainMenu2.Show();
            this.Hide();
        }
    }
}
