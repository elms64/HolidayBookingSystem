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
    public partial class CarRental : Form
    {
        private string carType = "";
        private string pickUpDate = "";
        private string dropOffDate = "";
        public CarRental()
        {
            InitializeComponent();
        }

        private void SearchCar_Click(object sender, EventArgs e)
        {
            string carType = CarType.SelectedItem.ToString() ?? string.Empty;
            pickUpDate = PickUpDate.Value.ToString("yyyy-MM-dd");
            dropOffDate = DropOffDate.Value.ToString("yyyy-MM-dd");
        }

        private void CarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PickUpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DropOffDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
