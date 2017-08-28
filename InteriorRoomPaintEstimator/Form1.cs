using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteriorRoomPaintEstimator
{
    public partial class InteriorPaintRoomEstimatorForm : Form
    {
        public InteriorPaintRoomEstimatorForm()
        {
            InitializeComponent();
        }

        private void widthRoomBox_Enter(object sender, EventArgs e)
        {

        }

     

        //Declare class level variables
        int heightFeet, heightInch, widthFeet, widthInch, lengthFeet, lengthInch, 
            numCoats, numDoors, numWindows, numGallons, numQuarts;

        private void numOfDoorsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numOfWindowsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void numOfCoatsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Check that each box is filled in before calculating the paint area
                if (heightFeetTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a height in the height feet box.");
                    return;
                }
                else if (heightInchTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a height in the height inches box.");
                    return;
                }
                else if (widthFeetTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the width in the width feet box.");
                    return;
                }
                else if (widthInchTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the width in the width inches box.");
                    return;
                }
                else if (lengthFeetTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the length in the length feet box.");
                    return;
                }
                else if (lengthInchTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the length in the length inches box.");
                    return;
                }
                else if (numOfCoatsTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the number of coats of paint in the num coats box.");
                    return;
                }
                else if (numOfDoorsTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the number of doors in the room in the num of doors box.");
                    return;
                }
                else if (numOfWindowsTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the number of windows in the room in the num windows box.");
                    return;
                }
                   
            heightInch = int.Parse(heightInchTextBox.Text);
            widthFeet = int.Parse(widthFeetTextBox.Text);
            widthInch = int.Parse(widthInchTextBox.Text);
            lengthFeet = int.Parse(lengthFeetTextBox.Text);
            lengthInch = int.Parse(lengthInchTextBox.Text);
            numCoats = int.Parse(numOfCoatsTextBox.Text);
            numDoors = int.Parse(numOfDoorsTextBox.Text);
            numWindows = int.Parse(numOfWindowsTextBox.Text);

            //convert input values from text string to int (numbers)
            {
                heightFeet = int.Parse(heightFeetTextBox.Text);
                heightInch = int.Parse(heightInchTextBox.Text);
                widthFeet = int.Parse(widthFeetTextBox.Text);
                widthInch = int.Parse(widthInchTextBox.Text);
                lengthFeet = int.Parse(lengthFeetTextBox.Text);
                lengthInch = int.Parse(lengthInchTextBox.Text);
                numCoats = int.Parse(numOfCoatsTextBox.Text);
                numDoors = int.Parse(numOfDoorsTextBox.Text);
                numWindows = int.Parse(numOfWindowsTextBox.Text);


                {
                    //Translate feet and inches to all inches (height, width, length)
                    int heightAllInch = ((12 * heightFeet) + heightInch);
                    int widthAllInch = ((12 * widthFeet) + widthInch);
                    int lengthAllInch = ((12 * lengthFeet) + lengthInch);

                    //Calculate 4 walls area without obstructions
                    int roomArea = ((2 * (heightAllInch * widthAllInch)) + (2 * (heightAllInch * lengthAllInch)));

                    //Calculate area taken up by windows
                    //Average window is 24 inches by 24 inches, area = 576 inches square
                    int windowsArea = (numWindows * 576);

                    //Calculate area taken up by doors
                    //Average door is 80 inches by 32 inches(not handicapped), area = 2560 inches square
                    int doorsArea = (numDoors * 2560);

                    //Wall area minus window and door area in square inches
                    int nonPaint = (windowsArea + doorsArea);
                    int paintArea = (roomArea - nonPaint);
                    int paintArea2 = (numCoats * paintArea);

                    //Translate area gallon will cover
                    //One gallon covers 400 square feet of area or 57600 square inches
                    numGallons = (paintArea2 / 57600);
                    int leftOver = (paintArea2 % 57600);
                    if (leftOver >= 28800)
                    {
                        numGallons++;
                        numQuarts = 0;
                    }
                    else if (leftOver >= 14400)
                    {
                        numQuarts = 2;
                    }
                    else if (leftOver >= 1)
                    {
                        numQuarts = 1;
                    }
                    else
                    {
                        numQuarts = 0;
                    }

                    //Display the results
                    numOfGallonsTextBox.Text = numGallons.ToString();
                    numOfQuartsTextBox.Text = numQuarts.ToString();
                }

            }
            }

        private void resetButton_Click(object sender, EventArgs e)
        {
            heightFeetTextBox.Text = "";
            heightInchTextBox.Text = "";
            widthFeetTextBox.Text = "";
            widthInchTextBox.Text = "";
            lengthFeetTextBox.Text = "";
            lengthInchTextBox.Text = "";
            numOfCoatsTextBox.Text = "";
            numOfDoorsTextBox.Text = "";
            numOfWindowsTextBox.Text = "";
            numOfGallonsTextBox.Text = "";
            numOfQuartsTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void widthFeetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthInchTextBox_TextChanged(object sender, EventArgs e)
        {            
        }

        private void lengthInchTextBox_TextChanged(object sender, EventArgs e)
        {            
        }

        private void lengthFeetTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void heightFeetTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    
        private void heightInchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

       


    }
}
