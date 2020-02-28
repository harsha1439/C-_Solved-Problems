using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_From_Fat_and_Carbohydrates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //The fat calories method
        private double fatcal(double fcal)
        {
            return fcal * 9;
        }
        //Carb calorie method
        private double carbcal(double Ccal)
        {
            return Ccal * 4;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // declaring variables to hold the fat inout and carbinput
            double fatinput, carbin, Totalfat, Totalcarb;
            //Get the fatcalorie input
            if(double.TryParse(fatGramInput.Text, out fatinput))
            {
                //Get the carbcalorie Input
                if(double.TryParse(carbInput.Text, out carbin))
                {
                    //calling method and returns a value
                    Totalfat = fatcal(fatinput);
                    Totalcarb = carbcal(carbin);
                    //display the Calorie from fat
                    fatGramOutput.Text = Totalfat.ToString();
                    //Display the calorie from carb
                    carbOutput.Text = Totalcarb.ToString();

                }
                //Display an error message
                else
                {
                    MessageBox.Show("please enter valid carbinput");
                }
            }
            //Display an erroe message
            else
            {
                MessageBox.Show("Please enter Valid gram Input");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
