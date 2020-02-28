using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Distance_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void DistOutput_Click(object sender, EventArgs e)
        {
            double speed;             //speed input variable
            int Inputhours;                  //Hours input variable
            int time = 1;           //time variable initialized to 1 hour
            double distance;         //Total distance
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Distance Calc.txt");
                //Gets the speed input
                if (double.TryParse(SpeedInputLabel.Text, out speed))
                {
                    //Gets the Hours Input
                    if (int.TryParse(HoursInputLabel.Text, out Inputhours))
                    {
                        //The following loop calculates the distance for each hour
                        while (time <= Inputhours)
                        {
                            distance = speed * time;
                            outputFile.WriteLine("After hour " + time + " the distance is " + distance.ToString());
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
                outputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
