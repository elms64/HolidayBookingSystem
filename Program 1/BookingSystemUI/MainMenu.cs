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

            Startbooking.Click += Startbooking_Click;
            Vieworder.Click += Vieworder_Click;

        }

        public void ShowHotelForm()
        {
            Hotel hotel = new Hotel();
            hotel.TopLevel = false;
            MainPanel.Controls.Add(hotel);
            hotel.Show();
            hotel.Size = MainPanel.Size;
        }

        private void Startbooking_Click(object? sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.TopLevel = false;
            MainPanel.Controls.Add(flight);
            flight.Show();
            flight.Size = MainPanel.Size;


            foreach (Control control in MainPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;
                }
            }


        }

        private void Vieworder_Click(object? sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.TopLevel = false;
            MainPanel.Controls.Add(viewOrders);
            viewOrders.Show();
            viewOrders.Size = MainPanel.Size;

            foreach (Control control in MainPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;
                }
            }



        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
