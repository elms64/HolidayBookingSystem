using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingSystemUI.Form1;

namespace BookingSystemUI
{

    public partial class Hotel : Form
    {
        private const string ConsoleAppUrl = "http://localhost:8080";
        private string selectedCountry;
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;
        private string comboBoxHotel = "";
        
        public Hotel(string selectedCountry, string selectedOrigin, int selectedOriginID, int selectedCountryID, MainMenu mainForm, string )
        {
            
            InitializeComponent();
            //this.selectedDepartureDate = selectedDepartureDate;
            this.selectedCountry = selectedCountry;
            //this.selectedReturnDate = selectedReturnDate; 
            LBCountry.Text = selectedCountry;
            LBReturnDate.Text = selectedReturnDate;
            LBDepartureDate.Text = selectedDepartureDate.ToShortDateString();
        }

        private async void Hotel_Load(object sender, EventArgs e)
        {
           
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void HotelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchHotel_Click(object sender, EventArgs e)
        {
            
        }

        private void SelectFlight_Click(object sender, EventArgs e)
        {

        }
    }
}
