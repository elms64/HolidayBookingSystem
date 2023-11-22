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
    public partial class Insurance : Form
    {
        public Insurance()
        {
            InitializeComponent();
        }

        private void SeearchInsurance_Click(object sender, EventArgs e)
        {
            string insuranceType = InsuranceType.SelectedItem.ToString() ?? string.Empty;
            string insuranceStart = InsuranceStart.Value.ToString("yyyy-MM-dd");
            string insuranceEnd = InsuranceEnd.Value.ToString("yyyy-MM-dd");
        }

        private void InsuranceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
