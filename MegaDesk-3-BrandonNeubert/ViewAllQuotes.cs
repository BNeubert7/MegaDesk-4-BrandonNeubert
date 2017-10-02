using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class ViewAllQuotes : Form
    {
        public DateTime dateSet { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Double DeskCost { get; set; }
        public int ShippingDays { get; set; }
        public double ShippingCost { get; set; }
        public Desk Desk { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public double Surface { get; set; }



        public ViewAllQuotes()
        {
            InitializeComponent();
            
            using (StreamReader sr = new StreamReader("quotes.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string json = sr.ReadLine();
                    JsonSerializer serializer = new JsonSerializer();
                    //DeskQuote printQuote = (DeskQuote)serializer.Deserialize(json,typeof(DeskQuote);
                    DeskQuote printQuote = JsonConvert.DeserializeObject<DeskQuote>(json);

                    ViewAQuotes.AppendText(
                        "Date: \t" + printQuote.date +
                        "\n First Name: \t" + printQuote.FirstName +
                        "\n Last Name: \t" + printQuote.LastName +
                        "\n Desk Specs:" +
                        "\n Width: \t\t" + System.Convert.ToString(printQuote.newDesk1.width) +
                        "\n Depth: \t\t" + System.Convert.ToString(printQuote.newDesk1.depth) +
                        "\n Drawers: \t" + System.Convert.ToString(printQuote.newDesk1.drawerCount) + 
                        "\n Material: \t\t" + System.Convert.ToString(printQuote.newDesk1.surface) +
                        "\n Shipping: \t" + System.Convert.ToString(printQuote.ShippingDays) + " Day" +
                        "\n Total Cost: \t" + "$" + System.Convert.ToString(printQuote.DeskCost + printQuote.ShippingCost) +
                        "\n" +
                        "==============================" +
                        "\n");
                }
            }
        }
    }
}
