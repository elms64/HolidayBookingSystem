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
        public MainMenu mainMenuInstance;
        public Flight()
        {
            InitializeComponent();
            mainMenuInstance = new MainMenu();
        }

        public void ShowHotelForm()
        {
            mainMenuInstance.ShowHotelForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Flight_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectFlight_Click(object sender, EventArgs e)
        {
            ShowHotelForm();
        }
    }
}
