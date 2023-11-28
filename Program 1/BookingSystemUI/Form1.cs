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
using System.Diagnostics.Metrics;

namespace BookingSystemUI
{
    public partial class Form1 : Form
    {
        //Change IP to localhost for testing on one machine, and the IP of Program 2 for remote testing
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
                    HttpResponseMessage response = client.PostAsync(ConsoleAppUrl, data).Result;

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

        private async void btnLoadCountries_Click(object sender, EventArgs e)
        {
            string message = txtBoxMessage.Text;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new StringContent(message, Encoding.UTF8, "application/json");
                    Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                    // Use Task.WhenAny to wait for the response or a delay
                    Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3))); // Adjust the timeout duration as needed

                    if (completedTask == responseTask)
                    {
                        // Response received within the timeout
                        HttpResponseMessage response = await responseTask;
                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            var countries = JsonSerializer.Deserialize<List<CountryData>>(jsonResponse);
                            DisplayCountries(countries);
                        }
                        else
                        {
                            Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        }
                    }
                    else
                    {
                        // Timeout occurred, show a message
                        MessageBox.Show("No response received within the specified time.");

                        // Save the HTTP message to a JSON file
                        SaveBatches saver = new SaveBatches();
                        await saver.SaveBatchProcess(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

       


        public class CountryData
        {
            public int CountryID { get; set; }
            public string CountryName { get; set; }
        }


        private void DisplayCountries(List<CountryData> countries)
        {
            foreach (var country in countries)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new Size(300, 60);

                // Setting the tag to store the ID
                panel.Tag = country.CountryID;

                // Click event to select the panel
                panel.Click += Panel_Click;

                Label countryNameLabel = new Label();
                countryNameLabel.Text = country.CountryName;
                countryNameLabel.Location = new Point(10, 10);

                Label countryIdLabel = new Label();
                countryIdLabel.Text = "ID: " + country.CountryID;
                countryIdLabel.Location = new Point(10, 30);

                // Add MouseClick event to labels to trigger the click event of the panel
                countryNameLabel.MouseClick += (s, e) => Panel_Click(panel, e);
                countryIdLabel.MouseClick += (s, e) => Panel_Click(panel, e);

                panel.Controls.Add(countryNameLabel);
                panel.Controls.Add(countryIdLabel);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        int selectedPanelID;

        private void Panel_Click(object sender, EventArgs e)
        {
            foreach (Panel pnl in flowLayoutPanel1.Controls)
            {
                pnl.BackColor = SystemColors.Control; // Reset all panels' color
            }

            Panel selectedPanel = (Panel)sender;
            selectedPanel.BackColor = Color.LightBlue;

            selectedPanelID = (int)selectedPanel.Tag; // Store the selected ID in the variable
            label1.Text = selectedPanelID.ToString();
        }

        private void btnSendID_Click(object sender, EventArgs e)
        {
            // You can use the selectedPanelID here to access the ID of the selected panel
            MessageBox.Show("Selected ID: " + selectedPanelID);
            // Or perform any other action with the selectedPanelID
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }


}