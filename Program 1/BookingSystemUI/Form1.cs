using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace BookingSystemUI
{
    public partial class Form1 : Form
    {
        private const string ConsoleAppUrl = "http://localhost:8080";

        public Form1()
        {
            InitializeComponent();
        }

        private async void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{ConsoleAppUrl}/flights");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        List<string> flights = JsonSerializer.Deserialize<List<string>>(jsonString);

                        flightBox.DataSource = flights;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void flightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the selected flight change if needed
        }
    }
}
