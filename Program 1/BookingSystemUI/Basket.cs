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
    public partial class Basket : Form
    {

        private MainMenu mainForm;
        private string selectedCountry;
        private string selectedOrigin;
        private int selectedOriginID;
        private int selectedCountryID;
        private DateTime selectedDepartureDate;
        private string selectedReturnDate;


        public Basket(string selectedCountry, string selectedOrigin, int selectedOriginID, int selectedCountryID, MainMenu mainForm, DateTime selectedDepartureDate, string selectedReturnDate)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Assign the values to the class members
            this.selectedCountry = selectedCountry;
            this.selectedOrigin = selectedOrigin;
            this.selectedOriginID = selectedOriginID;
            this.selectedCountryID = selectedCountryID;
            this.selectedDepartureDate = selectedDepartureDate;
            this.selectedReturnDate = selectedReturnDate;

            MessageBox.Show($"btnNext_Click:\nselectedCountry: {selectedCountry}\nselectedOrigin: {selectedOrigin}\nselectedOriginID: {selectedOriginID}\nselectedCountryID: {selectedCountryID}");
        }

        private void MainBasket_Click(object sender, EventArgs e)
        {
           
        }

        private void Basket_Load(object sender, EventArgs e)
        {

        }
    }
}
