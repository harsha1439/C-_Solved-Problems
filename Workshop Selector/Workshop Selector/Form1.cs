using System;
using System.Windows.Forms;

namespace Workshop_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcTotal_Click(object sender, EventArgs e)
        {


            
            
            int days;
            int regfee;
            int tot;


            if (workShopListBox.SelectedIndex == 0 )
            {
                days = 3;
                regfee = 1000;
                
                
            }
            else if(workShopListBox.SelectedIndex == 1 )
            {
                days = 3;
                regfee = 800;
               


            }
            else if (workShopListBox.SelectedIndex == 2)
            {
                days = 3;
                regfee = 1500;
                
            }
            else if(workShopListBox.SelectedIndex == 3 )
            {
                days = 5;
                regfee = 1300;
            }
            else 
            {
                days = 1;
                regfee = 500;
            }

            //for location table
            int fee;
            if (lodgingListBox.SelectedIndex == 0)
            {
                fee = days * 150;
            }
            else if (lodgingListBox.SelectedIndex == 1)
            {
                fee = days * 225;
            }
            else if (lodgingListBox.SelectedIndex == 2)
            {
                fee = days * 175;
            }
            else if (lodgingListBox.SelectedIndex == 3)
            {
                fee = days * 300;
            }
            else if (lodgingListBox.SelectedIndex == 4)
            {
                fee = days * 175;
            }
            else
            {
                fee = days * 150;
            }

            if (workShopListBox.SelectedIndex!=-1)
            {
                if(lodgingListBox.SelectedIndex != -1)
                {
                    regOutput.Text = regfee.ToString("c");
                    lodgOutput.Text = fee.ToString("c");
                    tot = regfee + fee;
                    totalOutput.Text = tot.ToString("c");
                }
                else
                {
                    MessageBox.Show("Please select one location from the Location listbox");
                }
                
            }
            else
            {
                MessageBox.Show("please select atleat one from Workshop list box");
            }
            


            
            
          
            
            
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            regOutput.Text = "";
            lodgOutput.Text = "";
            totalOutput.Text = "";
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
