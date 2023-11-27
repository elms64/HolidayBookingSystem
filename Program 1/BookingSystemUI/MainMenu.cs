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

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HotelBooking_Click(object sender, EventArgs e)
        {

        }

        private void CarBooking_Click(object sender, EventArgs e)
        {

        }

        private void InsuranceBooking_Click(object sender, EventArgs e)
        {

        }

        private void Basket_Click(object sender, EventArgs e)
        {

        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            MainMenu2 mainMenu2 = new MainMenu2();
            mainMenu2.Show();
            this.Hide();
        }

        private void btnBookingInit_Click(object sender, EventArgs e)
        {
            BookingInit bookinginit = new BookingInit(this); // Pass reference to the main form
            bookinginit.TopLevel = false;
            MainPanel.Controls.Add(bookinginit);
            bookinginit.Show();
            bookinginit.Size = MainPanel.Size;
            bookinginit.BringToFront();
        }

        public void ShowFormInMainPanel(Form form)
        {
            form.TopLevel = false;
            MainPanel.Controls.Clear(); // Clear existing controls in MainPanel
            MainPanel.Controls.Add(form);
            form.Show();
            form.Size = MainPanel.Size;
            form.BringToFront();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
