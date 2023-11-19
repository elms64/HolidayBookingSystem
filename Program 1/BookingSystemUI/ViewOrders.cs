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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void MainMenuOrder_Click(object sender, EventArgs e)
        {
            MainMenu2 mainMenu2 = new MainMenu2();
            mainMenu2.Show();
            this.Hide();
        }
    }
}
