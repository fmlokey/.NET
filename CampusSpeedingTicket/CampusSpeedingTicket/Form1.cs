using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusSpeedingTicket
{
    {
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new speedingTicket());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Calculate button 
        //If else statements using the radion buttons of 
        //freshman, sophomore, visitor, or staff are checked to 
        //decide ticket amount, and using if else statements to 
        //decide if extra fees for night ticket

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int freshMiles;
            freshMiles = int.Parse(freshTextBox.Text);
            int sophMiles;
            sophMiles = int.Parse(sophTextBox.Text);
            int result;
            int fine = 35;
            int flatFee = 25;


            if (freshmanRadioButton.Checked == true)
            {
                // freshMiles = int.Parse(freshMiles);
                // freshMiles = int.Parse(freshTextBox);

                result = fine + (freshMiles * 2);
                ticketPriceTextBox.Text = " " + result;
            }
            else if (sophmoreRadioButton.Checked == true)
            {
                result = fine + (sophMiles * 5);
                ticketPriceTextBox.Text = " " + result;
            }
            else if (visitorRadioButton.Checked == true)
            {
                result = fine;
                ticketPriceTextBox.Text = " " + result;
            }
            else //(staffRadioButton.Checked == true)
            {
                result = fine + flatFee;
                ticketPriceTextBox.Text = " " + result;
            }

            if (nightRadioButton.Checked == true)
            {
                int finalResult = result + 20;
                ticketPriceTextBox.Text = "$" + finalResult;
            }
            else
            {
                ticketPriceTextBox.Text = "$" + result;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void freshTextBox_TextChanged(object sender, EventArgs e)
        {
            int freshMiles;
            freshMiles = int.Parse(freshTextBox.Text);
        }

        private void sophTextBox_TextChanged(object sender, EventArgs e)
        {
            int sophMiles;
            sophMiles = int.Parse(sophTextBox.Text);
        }

        private void freshmanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}