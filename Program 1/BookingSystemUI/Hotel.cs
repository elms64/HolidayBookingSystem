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
        private int selectedCountryID;
        private DateTime selectedDepartureDate;

        private string comboBoxHotel;
        private string checkInDate = "";
        private string checkOutDate = "";
        public Hotel(DateTime selectedDepartureDate)
        {
            InitializeComponent();
            this.selectedDepartureDate = selectedDepartureDate;
        }

        private async void Hotel_Load(object sender, EventArgs e)
        {
            {

                string message = "SEND_COUNTRY";


                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var data = new StringContent(message, Encoding.UTF8, "application/json");

                        Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                        Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3)));

                        if (completedTask == responseTask)
                        {

                            HttpResponseMessage response = await responseTask;

                            if (response.IsSuccessStatusCode)
                            {

                                string jsonResponse = await response.Content.ReadAsStringAsync();
                                var countries = JsonSerializer.Deserialize<List<CountryData>>(jsonResponse);

                                comboBoxHotel.Items.Clear();
                                CheckInDate.Value = selectedDepartureDate;

                                foreach (var country in countries)
                                {
                                    comboBoxHotel.Items.Add(new KeyValuePair<string, int>(country.CountryName, country.CountryID));
                                }

                                comboBoxHotel.Sorted = true;
                            }
                            else
                            {
                                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No response received within the specified time.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
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
            string selectedHotel = comboBoxHotel.Text();
            checkInDate = CheckInDate.Value.ToString("yyyy-MM-dd");
            checkOutDate = CheckOutDate.Value.ToString("yyyy-MM-dd");
        }

        private void SelectFlight_Click(object sender, EventArgs e)
        {

        }
    }
}
