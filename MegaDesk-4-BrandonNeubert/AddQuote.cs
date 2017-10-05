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
    public partial class AddQuote : Form
    {

        private List<string> materials;


        public AddQuote()
        {
            InitializeComponent();
            materials = new List<string>();

            foreach (Desk.SurfaceMaterials surfaceMaterials in Enum.GetValues(typeof(Desk.SurfaceMaterials)))
            {
                materials.Add(Convert.ToString(surfaceMaterials));
            }
            variableSurfaceMaterial.DataSource = materials;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //Try to submit, if something goes wrong then catch and notify the user.
//            try
//            {
                // Read Values
                string FirstName = nameFirstForm.Text;
                string LastName = nameLastForm.Text;
                int width = Convert.ToInt32(variableWidth.Text);
                int depth = Convert.ToInt32(variableDepth.Text);
                int drawerCt = decimal.ToInt16(variableDrawerCount.Value);
                string MaterialSelectedText = variableSurfaceMaterial.SelectedItem.ToString();
                Desk.SurfaceMaterials MaterialSelected = (Desk.SurfaceMaterials)Enum.Parse(typeof(Desk.SurfaceMaterials), MaterialSelectedText);
                int ShippingDays = int.Parse(variableShippingMethod.SelectedItem.ToString());

                // Create the newDesk object
                Desk newDesk1 = new Desk(width, depth, drawerCt, MaterialSelected);

                //Calculate the deskCost and ShippingCost so we can create the DeskQuote object
                double deskCost = newDesk1.CalculateDeskCost();
                double ShippingCost = CalculateShipping(ShippingDays, newDesk1);

                // Create the DeskQuote object
                DeskQuote newDeskQuote1 = new DeskQuote(FirstName, LastName, deskCost, ShippingDays, ShippingCost, newDesk1);

                // Move on to display the quote on-screen
                DisplayQuote DisplayQuote = new DisplayQuote(newDeskQuote1);
                DisplayQuote.Show();
                this.Hide();
//            }
//            catch (Exception)
//            {
//                MessageBox.Show("There is an issue in one of your entries. Please ensure that values are entered correctly.");
//            }
        }

        //Check the values of width for the right range and integer entries
        private void variableWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean isDigit = char.IsDigit(e.KeyChar);
            Boolean isControl = char.IsControl(e.KeyChar);

            if (isDigit == false && isControl == false)
            {
                MessageBox.Show("The width must be entered as an integer.");
                variableWidth.Clear();
            }
        }
        private void variableWidth_Validating(object sender, CancelEventArgs e)
        {
            try { // Try/Catch so that if this form item is skipped an error is not thrown.
                string errorMsgWidth = "The width must be between 24\" and 96\". Please try again.";
                int widthTest = Convert.ToInt32(variableWidth.Text);
                if (widthTest < 24 || widthTest > 96)
                {
                    MessageBox.Show(errorMsgWidth);
                    variableWidth.Clear();
                }
            }
            catch (Exception)
            { }

        }

        // Check the values of depth for the right range and integer entries
        private void variableDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean isDigit = char.IsDigit(e.KeyChar);
            Boolean isControl = char.IsControl(e.KeyChar);

            if (isDigit == false && isControl == false)
            {
                MessageBox.Show("The depth must be entered as an integer.");
                variableDepth.Clear();
            }
        }
        private void variableDepth_Validating(object sender, CancelEventArgs e)
        {
            try
            { // Try/Catch so that if this form item is skipped an error is not thrown.
                string errorMsgDepth = "The depth must be between 12\" and 48\". Please try again.";
                int depthTest = Convert.ToInt32(variableDepth.Text);
                if (depthTest < 12 || depthTest > 48)
                {
                    MessageBox.Show(errorMsgDepth);
                    variableDepth.Clear();
                }
            }
            catch (Exception)
            { }

        }

        // Check the drawer count
        private void variableDrawerCount_ValueChanged(object sender, EventArgs e)
        {
            double drawerCtTest = decimal.ToDouble(variableDrawerCount.Value);
            if (drawerCtTest > 7)
            {
                MessageBox.Show("The maximum number of drawers is 7. Please try again.");
                variableDrawerCount.Value = 7;
            }
        }

        // Calculator for shipping Costs
        //double CalculateShipping(int inShippingDays, Desk inDesk)
        //{
        //    int shippingDays = inShippingDays;
        //    Desk newDesk1 = inDesk;
        //    double DeskArea = inDesk.DeskAreaCalc();
        //    double ShippingCost;

        //    int i;
        //    if (DeskArea < 1000)
        //    { i = 0;
        //    }
        //    else if (DeskArea > 1000 && DeskArea < 2000)
        //    { i = 1;
        //    }
        //    else
        //    { i = 2;
        //    }

        //    switch (shippingDays)
        //    {
        //        case 3:
        //            double[] ThreeDay = new double[3] { 60, 70, 80 };
        //            ShippingCost = ThreeDay[i];
        //            break;
        //        case 5:
        //            double[] FiveDay = new double[3] { 40, 50, 60 };
        //            ShippingCost = FiveDay[i];
        //            break;
        //        case 7:
        //            double[] SevenDay = new double[3] { 30, 35, 40 };
        //            ShippingCost = SevenDay[i];
        //            break;
        //        case 14:
        //            double[] FourteenDay = new double[3] { 0, 0, 0 };
        //            ShippingCost = FourteenDay[i];
        //            break;
        //        default:
        //            throw new Exception("Bad Input");
        //            break;
        //    }

        //    return ShippingCost;
















        double CalculateShipping(int inShippingDays, Desk inDesk)
        {
            double shippingCost = 0.0;
            double[,] priceArray = new double[3,3];
            StreamReader sr1 = new StreamReader("rushOrderPrices.txt");
            double DeskArea = inDesk.DeskAreaCalc();

            while (sr1.Peek() >= 0)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        priceArray[row,column] = Convert.ToDouble(sr1.ReadLine());
                    }
                }
            }

            int findRow = 0;
            int findColumn = 0;

            switch (inShippingDays)
            {
                case 3:
                    findRow = 0;
                    break;
                case 5:
                    findRow = 1;
                    break;
                case 7:
                    findRow = 2;
                    break;
                case 14:
                    shippingCost = 0.0;
                    break;
                default:
                    throw new Exception("Bad Input");
                    break;
            }

            if (DeskArea < 1000)
            { findColumn = 0; }
            else if (DeskArea < 2000)
            { findColumn = 1; }
            else
            { findColumn = 2; }

            if (inShippingDays != 14)
            { shippingCost = priceArray[findRow,findColumn]; }

            sr1.Close();
            return shippingCost;
        }
    }
}