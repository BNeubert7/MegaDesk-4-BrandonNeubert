using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BrandonNeubert
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Please note I am never hiding the Main Menu, but further sub-forms such
        //as (displayQuotes) will hide prior forms (addQuote)

        // Click the AddQuote button
        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Show();
        }
        //Click the ViewQuotes Button
        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAllQuotes = new ViewAllQuotes();
            ViewAllQuotes.Show();

        }
        // Click the SearchQuotes button
        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Show();
        }

        // Click the exit button
        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}