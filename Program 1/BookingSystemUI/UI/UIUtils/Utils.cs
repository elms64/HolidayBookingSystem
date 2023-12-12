using BookingSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystemUI.UI.UIUtils
{

    public class Utils
    {
        public static Panel createPanel(int yOffset, Panel outerPanel, Label label)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new Size(850, 100);
            panel.BackColor = Color.White; // Sajan Test
            panel.Enabled = true; // Sajan Test

            // Set the location of the panel
            panel.Location = new Point(0, yOffset);

            // Add the label to the panel
            panel.Controls.Add(label);

            // Add the panel to outerPanel
            outerPanel.Controls.Add(panel);

            // Make outerPanel scrollable
            outerPanel.AutoScroll = true;

            return panel;
        }

        // Create a label to display airport information
        public static Label createLabelWithLabelText(String labelText)
        {
            Label label = new Label();
            label.Text = labelText;
            label.AutoSize = true;
            return label;
        }
    }

   
}
