using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

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
                    HttpResponseMessage response = await client.GetAsync($"{ConsoleAppUrl}");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        List<int> flights = JsonSerializer.Deserialize<List<int>>(jsonString);



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

        private void btnSendToProgram2_Click(object sender, EventArgs e)
        {
            string message = txtBoxMessage.Text;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new StringContent(message, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("http://localhost:8080/", data).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Data sent successfully to Program 2");
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



    }
}
