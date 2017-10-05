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
    public partial class SearchQuotes : Form
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

        public SearchQuotes()
        {
            InitializeComponent();
        }


        private void SearchAllQuotes_Click(object sender, EventArgs e)
        {
            viewSQuotes.Clear();
            using (StreamReader sr = new StreamReader("quotes.json"))
            {
                while (sr.Peek() >= 0)
                {
                    string json = sr.ReadLine();

                    JsonSerializer SearchSerializer = new JsonSerializer();
                    DeskQuote SearchPrintQuote = JsonConvert.DeserializeObject<DeskQuote>(json);

                    if (SurfaceSearch.Text == System.Convert.ToString(SearchPrintQuote.newDesk1.surface))
                        {
                        //Desk.SurfaceMaterials MaterialSelected = (Desk.SurfaceMaterials)Enum.Parse(typeof(Desk.SurfaceMaterials), MaterialSelectedText);
                        //Print the matching quotes
                        viewSQuotes.AppendText(
                                        "Date: \t" + SearchPrintQuote.date +
                                        "\n First Name: \t" + SearchPrintQuote.FirstName +
                                        "\n Last Name: \t" + SearchPrintQuote.LastName +
                                        "\n Desk Specs:" +
                                        "\n Width: \t\t" + System.Convert.ToString(SearchPrintQuote.newDesk1.width) +
                                        "\n Depth: \t\t" + System.Convert.ToString(SearchPrintQuote.newDesk1.depth) +
                                        "\n Drawers: \t" + System.Convert.ToString(SearchPrintQuote.newDesk1.drawerCount) +
                                        "\n Material: \t\t" + System.Convert.ToString(SearchPrintQuote.newDesk1.surface) +
                                        "\n Shipping: \t" + System.Convert.ToString(SearchPrintQuote.ShippingDays) + " Day" +
                                        "\n Total Cost: \t" + "$" + System.Convert.ToString(SearchPrintQuote.DeskCost + SearchPrintQuote.ShippingCost) +
                                        "\n" +
                                        "==============================" +
                                        "\n");
                    }
                }
            }
        }
    }
}