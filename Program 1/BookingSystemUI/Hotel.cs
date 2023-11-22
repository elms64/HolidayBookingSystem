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
    public partial class Hotel : Form
    {
        private string hotelName = "";
        private string checkInDate = "";
        private string checkOutDate = "";
        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HotelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchHotel_Click(object sender, EventArgs e)
        {
            hotelName = HotelName.Text;
            checkInDate = CheckInDate.Value.ToString("yyyy-MM-dd");
            checkOutDate = CheckOutDate.Value.ToString("yyyy-MM-dd");
        }
    }
}
