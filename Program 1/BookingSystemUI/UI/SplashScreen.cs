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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            loading.Width += 5;
            if (loading.Width >= 700) //Making use of the timer to load MainMenu when the width is 700 (might change later)
            {
                loadingTimer.Stop();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
        }

        private void SplashScreen_Load(Object sender, EventArgs e)
        {
            loadingTimer.Start();
        }
    }
}
