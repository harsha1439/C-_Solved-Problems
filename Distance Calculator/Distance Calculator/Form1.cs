using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DistOutput_Click(object sender, EventArgs e)
        {
            //Local Varaibles
            double speed;             //speed input variable
            int Inputhours;                  //Hours input variable
            int time = 1;           //time variable initialized to 1 hour
            double distance;         //Total distance

            //Gets the speed input
            if(double.TryParse(SpeedInputLabel.Text, out speed))
            {
                //Gets the Hours Input
                if(int.TryParse(HoursInputLabel.Text, out Inputhours))
                {
                    //The following loop calculates the distance for each hour
                    while (time<=Inputhours)
                    {
                        distance = speed * time;
                        OutputListbox.Items.Add("After hour " + time + " the distance is " + distance.ToString());
                        time++;
                    }

                }
                //Invalid hours entered
                else
                {
                    MessageBox.Show("Please enter a valid hours");
                }
                //invalid Speed entered
            }
            else
            {
                MessageBox.Show("Invalid Speed");
            }
        }

        //Exit the form
        private void TotalExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
