using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
