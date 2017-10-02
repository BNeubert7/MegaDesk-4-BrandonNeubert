using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BrandonNeubert
{
    public partial class DisplayQuote : Form
    {
        //Write the object as a JSON
        DeskQuote CurrentDeskQuote { get; set; }
        public JsonSerializer JsonSerializer { get; private set; }

        public DisplayQuote(DeskQuote previousDeskQuote)
        {
            InitializeComponent();

            CurrentDeskQuote = previousDeskQuote;

            FirstNameValue.Text = CurrentDeskQuote.FirstName;
            LastNameValue.Text = CurrentDeskQuote.LastName;

            WidthValue.Text = System.Convert.ToString(CurrentDeskQuote.newDesk1.width);
            DepthValue.Text = System.Convert.ToString(CurrentDeskQuote.newDesk1.depth);
            DeskAreaCost.Text = "$" + System.Convert.ToString(CurrentDeskQuote.newDesk1.DeskAreaCostCalc());

            DrawerCtValue.Text = System.Convert.ToString(CurrentDeskQuote.newDesk1.drawerCount);
            DrawerCtCost.Text = "$" + System.Convert.ToString(CurrentDeskQuote.newDesk1.drawerCount * 50);

            MaterialValue.Text = System.Convert.ToString(CurrentDeskQuote.newDesk1.surface);
            MaterialCost.Text = "$" + System.Convert.ToString((double)CurrentDeskQuote.newDesk1.surface);

            ShippingOpValue.Text = System.Convert.ToString(CurrentDeskQuote.ShippingDays) + " Day";
            ShippingOpCost.Text = "$" + System.Convert.ToString(CurrentDeskQuote.ShippingCost);

            DeskCost.Text = "$" + System.Convert.ToString(CurrentDeskQuote.DeskCost+CurrentDeskQuote.ShippingCost);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveQuit_Click(object sender, EventArgs e)
        {
            File.AppendAllText("quotes.txt",JsonConvert.SerializeObject(CurrentDeskQuote) + "\r\n");
            //File.AppendAllText("quotes.txt", JsonConvert.SerializeObject(Environment.NewLine));
            Close();
        }     
    }
}