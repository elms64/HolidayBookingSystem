using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BookingSystemUI
{
    public partial class MainMenu : Form
    {
        bool sidebarExpand;
        public MainMenu()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Basket_Click(object sender, EventArgs e)
        {

        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            MainMenu2 mainMenu2 = new MainMenu2();
            mainMenu2.Show();
            this.Hide();
        }

        private void btnBookingInit_Click(object sender, EventArgs e)
        {
            BookingUI bookinginit = new BookingUI(this); // Pass reference to the main form
            bookinginit.TopLevel = false;
            MainPanel.Controls.Add(bookinginit);
            bookinginit.Show();
            bookinginit.Size = MainPanel.Size;
            bookinginit.BringToFront();
        }

        public void ShowFormInMainPanel(Form form)
        {
            form.TopLevel = false;
            MainPanel.Controls.Clear(); // Clear existing controls in MainPanel
            MainPanel.Controls.Add(form);
            form.Show();
            form.Size = MainPanel.Size;
            form.BringToFront();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
