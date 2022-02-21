using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversionGUI
{
    public partial class FrmMain : Form
    {

        //Declare Variables to store conversion values
        double Input = 0, Output = 0;

        //Declare string to store input type
        String inputType = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Call the exit procedure
            Exit();
        }

        private void Exit()
        {
            //prompt user to confirm exit

            DialogResult userResponse = MessageBox.Show("Are you sure you want to exit?",//message
                "Exit", //caption
                MessageBoxButtons.YesNo, //buttons
                MessageBoxIcon.Warning); //icon

            //Evaluate users response
           if (userResponse.Equals(DialogResult.Yes))
            {
                //exit application
                Application.Exit(); //dont need to code "No" on a windows form
            }
        }

        //Function to check if form is empty
        private bool IsEmpty()
        {
            //function should return true if the form is empty
            //otherwise return false
            
            if (!String.IsNullOrEmpty(txtInput.Text) || !String.IsNullOrEmpty(txtOutput.Text)) //if input or output is NOT empty
            {
                //if either text 
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Check if form is empty
            if (!IsEmpty()) //runs if IsEmpty returns false (due to !)
            {
                //prompt user to confirm reset
                DialogResult userResponse = MessageBox.Show("Reset will result in loss of resuilt. Are you sure you want to reset?",//message
                    "Reset?", //caption
                    MessageBoxButtons.YesNo, //buttons
                    MessageBoxIcon.Warning); //icon

                //Evaluate users response
                if (userResponse.Equals(DialogResult.Yes))
                {
                    //reset 
                    Reset();
                }
            }
        }

        //Procedure to reset form
        private void Reset()
        {
            //Clear the form
            //Clear textboxes
            txtInput.Text = ""; //could also set these to null
            txtOutput.Text = "";

            //reset radio buttons
            rbFtoM.Checked = false;
            rbMtoF.Checked = false;
            rbKToMi.Checked = false;
            rbMitoK.Checked = false;

            //reset variables
            Input = 0;
            Output = 0;
            inputType = "";

            //Reset input and output labels

            lblInput.Text = "Input";
            lblOutput.Text = "Output";
        }

        private double MetresToFeet(double n1)
        {
            //1 Meter = 3.2808399 Foot

            double result = n1 * 3.2808399;
            return result;
        }
        private double FeetToMetres(double n1) //convert feet to metres
        {
            //1ft= 0.3048000m

            double result = n1 * 0.3048000; //can also just reverse the * and / when going between units
            return result;                  // e.g. n1 / 0.30480000
        }
        private double MilesToKilometres(double n1) //convert miles to kilometres
        {
            //1mi = 1.609344km

            double result = n1 * 1.609344;
            return result;
        } 
        
        private double KilometresToMiles(double n1) //convert kilometres to miles
        {
            //1Km is equivalent to 0.6214 miles

            double result = n1 * 0.6214;
            return result;
        }

        private void rbFtoM_CheckedChanged(object sender, EventArgs e)
        {
            //get checked staus of radiobutton
            if (rbFtoM.Checked)
            {
                //set input type
                inputType = "feet";

                //set label
                lblInput.Text = "feet";
                lblOutput.Text = "metres";

            }
        }

        private void rbMitoK_CheckedChanged(object sender, EventArgs e)
        {
            //get checked staus of radiobutton
            if (rbMitoK.Checked)
            {
                //set input type
                inputType = "miles";

                //set label
                lblInput.Text = "miles";
                lblOutput.Text = "kilometres";

            }

        }

        private void rbKToMi_CheckedChanged(object sender, EventArgs e)
        {
            //get checked staus of radiobutton
            if (rbKToMi.Checked)
            {
                //set input type
                inputType = "kilometres";

                //set label
                lblInput.Text = "kilometres";
                lblOutput.Text = "miles";

            }

        }
        
        private void rbMtoF_CheckedChanged(object sender, EventArgs e)
        {
            //get checked staus of radiobutton
            if (rbMtoF.Checked)
            {
                //set input type
                inputType = "metres";

                //set label
                lblInput.Text = "metres";
                lblOutput.Text = "feet";

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //call the convert procedure
            ConvertInput();


        }

        private void ConvertInput()
        {
            //convert and store input
            Input = Convert.ToDouble(txtInput.Text.Trim());

            //use inputType to determine which function to call and pass input as a paramter

            if (inputType.Equals("metres"))
            {
                Output = MetresToFeet(Input);
                //Display output
                txtOutput.Text = Output.ToString("0.0");//moved this inside if statements so output doesn't display if a conversion type has not been selected

            }
            else if (inputType.Equals("feet"))
            {
                Output = FeetToMetres(Input);
                //Display output
                txtOutput.Text = Output.ToString("0.0"); //the 0.0 will round the result to 1 decimal place
            }                                              //this is also only for converting to a string. if you are using numbers, you need to use math.round

            else if (inputType.Equals("miles"))
            {
                Output = MilesToKilometres(Input);
                //Display output
                txtOutput.Text = Output.ToString("0.0");
            }

            else if (inputType.Equals("Kilometres"))
            {
                Output = KilometresToMiles(Input);
                //Display output
                txtOutput.Text = Output.ToString("0.0");
            }

            else
            {
                MessageBox.Show("Please select a conversion",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            
        }



       

        



       
    }
}
