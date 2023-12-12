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
    public partial class MainMenu2 : Form
    {
        public MainMenu2()
        {
            InitializeComponent();
        }

        private void StartBooking_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void ViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.Show();
            this.Hide();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
