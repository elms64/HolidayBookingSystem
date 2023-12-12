using BookingSystemUI.Model;
using BookingSystemUI.Service;
using BookingSystemUI.UI.UIUtils;
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



    public partial class VehicleUI : Form
    {
        private const string ConsoleAppUrl = "http://localhost:8080";

        private MainMenu mainForm;
        private Booking booking;
        private VehicleService vehicleSerivce;

        public VehicleUI(Booking booking, MainMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.vehicleSerivce = new VehicleService();
            this.Load += Vehicle_Load;
            this.booking = booking;



        }

        private async void Vehicle_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Vehicle Load"); //Testing
            {
                if (booking != null)
                {
                    Task<List<Vehicle>> vehicleTask = vehicleSerivce.GetVehicle();
                    await vehicleTask;

                    List<Vehicle> vehicles = vehicleTask.Result;

                    int yOffset = 8;
                    foreach (var vehicle in vehicles)
                    {
                        String labelText = $"Vehicle ID: {vehicle.VehicleID}," +
                            $"Vehicle Type: {vehicle.VehicleType}, " +
                            $"Price Per Day: {vehicle.PricePerDay}, ";
                        Label label = Utils.createLabelWithLabelText(labelText);
                        Panel panel = Utils.createPanel(yOffset, vehiclePanel, label);
                        yOffset += panel.Height;

                        panel.Click += (sender, e) => Panel_Click(sender, e, vehicle);
                    }
                }

            }


        }
        public void Panel_Click(object sender, EventArgs e, Vehicle vehicle)
        {
            booking.Vehicle = vehicle;
            MessageBox.Show(vehicle.ToString());
            vehiclePanel.Visible = false;

        }
        /*  private async Task Send_Vehicles(string messageType)
          {
              //pass the message and the selectedCountry/OriginID
              string message = messageType;

              try
              {
                  // Create a new HTTPclient
                  using (HttpClient client = new HttpClient())
                  {

                      // Data variable has the message passed in.
                      var data = new StringContent(message, Encoding.UTF8, "application/json");

                      // Data is actually sent here.
                      Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                      // Use Task.WhenAny to wait for the response or a delay
                      Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3))); // Adjust the timeout duration as needed


                      if (completedTask == responseTask)
                      {
                          // Response received within the timeout
                          HttpResponseMessage response = await responseTask;

                          // If the response is successful
                          if (response.IsSuccessStatusCode)
                          {
                              // Load the received flight data to the front end.
                              var responseData = await response.Content.ReadAsStringAsync();
                              // TODO: Deserialize and process the responseData
                          }
                          else
                          {
                              Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                          }
                      }
                      else
                      {
                          // Timeout occurred, show a message
                          MessageBox.Show($"No response received within the specified time for message: {message}");
                      }
                  }
              }
              catch (HttpRequestException ex)
              {
                  Console.WriteLine($"HTTP Request Error: {ex.Message}");
                  Console.WriteLine($"HTTP Request Error Details: {ex}");
              }
              catch (TaskCanceledException ex)
              {
                  Console.WriteLine($"Task Canceled Error: {ex.Message}");
                  Console.WriteLine($"Task Canceled Error Details: {ex}");
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"An error occurred: {ex.Message}");
                  Console.WriteLine($"Error Details: {ex}");
              }
          }

          */

        private void SearchCar_Click(object sender, EventArgs e)
        {

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



        private async void btnNext_Click(object sender, EventArgs e)
        {
            InsuranceUI insuranceUI = new InsuranceUI(booking, mainForm);

            mainForm.ShowFormInMainPanel(insuranceUI);
            this.Close();
            /*
            try
            {
                //Change this variable when the selected vehicle ID can be detected.

                int selectedVehicleID = 45;
                await Send_Selected("VEHICLE_SELECTED_ID", selectedVehicleID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


            InsuranceUI insurance = new InsuranceUI(selectedCountry, selectedOrigin, selectedOriginID, selectedCountryID, mainForm, selectedDepartureDate, selectedReturnDate);

            // Show the Flight form
            mainForm.ShowFormInMainPanel(insurance);

            // Close the BookingInit form if needed
            this.Close();
            */
        }

        // Also just here for testing. Remove when you hvae the selectediD
        private int selectedVehicleID = 1341243123;
        /* private async Task Send_Selected(string messageType, int value)
         {
             //pass the message and the selectedCountry/OriginID
             string message = $"{messageType}:{value}";

             try
             {
                 // Create a new HTTPclient
                 using (HttpClient client = new HttpClient())
                 {
                     // Add headers to the client, not 100% necessary, but for a polished finish they should probably be present in all of them
                     client.DefaultRequestHeaders.Add("VehicleID", selectedVehicleID.ToString());

                     // Data variable has the message passed in.
                     var data = new StringContent(message, Encoding.UTF8, "application/json");

                     // Data is actually sent here.
                     Task<HttpResponseMessage> responseTask = client.PostAsync(ConsoleAppUrl, data);

                     // Use Task.WhenAny to wait for the response or a delay
                     Task completedTask = await Task.WhenAny(responseTask, Task.Delay(TimeSpan.FromSeconds(3))); // Adjust the timeout duration as needed


                     if (completedTask == responseTask)
                     {
                         // Response received within the timeout
                         HttpResponseMessage response = await responseTask;

                         // If the response is successful
                         if (response.IsSuccessStatusCode)
                         {
                             // Load the received flight data to the front end.
                             var responseData = await response.Content.ReadAsStringAsync();
                             // TODO: Deserialize and process the responseData
                         }
                         else
                         {
                             Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                         }
                     }
                     else
                     {
                         // Timeout occurred, show a message
                         MessageBox.Show($"No response received within the specified time for message: {message}");
                     }
                 }
             }
             catch (HttpRequestException ex)
             {
                 Console.WriteLine($"HTTP Request Error: {ex.Message}");
                 Console.WriteLine($"HTTP Request Error Details: {ex}");
             }
             catch (TaskCanceledException ex)
             {
                 Console.WriteLine($"Task Canceled Error: {ex.Message}");
                 Console.WriteLine($"Task Canceled Error Details: {ex}");
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"An error occurred: {ex.Message}");
                 Console.WriteLine($"Error Details: {ex}");
             }
         }*/
    }
}
