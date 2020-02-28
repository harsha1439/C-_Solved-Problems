using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat_Percentage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            double totcal;
            double fatgram;
            double calOutput;
            double PercentOutput;

            if(double.TryParse(totCaloriePromptLabel.Text,out totcal))
            {
                if(double.TryParse(numFatInFoodPromptLabel.Text,out fatgram))
                {
                    if(totcal>0 && fatgram >0)
                    {
                        if (fatgram < totcal)
                        {
                            calOutput = fatgram * 9;
                            calFromFatPromptLabel.Text = calOutput.ToString();
                            PercentOutput = calOutput / totcal;
                            percentageOutputLabel.Text = PercentOutput.ToString("p");
                            if (checkOutput.Checked && PercentOutput <0.3 ) 
                            {
                                MessageBox.Show("low fat food");
                            }
                            else
                            {
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Number of caloreis from fat cannot be grater than total calories");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Values entered should be grater than zero");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter valid grams");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid calories");
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            totCaloriePromptLabel.Text = "";
            numFatInFoodPromptLabel.Text = "";
            calFromFatPromptLabel.Text = "";
            percentageOutputLabel.Text = "";
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
