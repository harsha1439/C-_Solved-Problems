using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_tour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Local Variables Initilization
        int num1;
        int num2;
        int total;
        int output;
        //Create a randon objcet
        Random rand = new Random();
        
        private void Button1_Click(object sender, EventArgs e)
        {
            //to get the string total
          if(int.TryParse(AnsInput.Text, out total))
            {
               output= int.Parse(AnsInput.Text);    //to get the string output
                total = num1 + num2; // Addition of two random numbers generated
                if (output == total) //comparing both the entered values and total value
                {
                    MessageBox.Show("Answer is correct"); //Display Message
                    additionTour(); //Method reuse
                    AnsInput.Text = ""; //Clear the textbox
                }
                else
                {
                    MessageBox.Show("Incorrect answer");
                    additionTour(); //Method Reuse
                    AnsInput.Text = ""; //Clear the textbox
                }
            }
            else
            {
                MessageBox.Show("PLease enter a valid input");
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            additionTour();
        }
        private void additionTour() //Creating a method which can be reused
        {
            //Get a random integer and assign it to num1 and num2 after the form load

            num1 = rand.Next(400)+100;
            num2 = rand.Next(400)+100;
            label3.Text = num1.ToString() + "+" + num2.ToString() + "=";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
