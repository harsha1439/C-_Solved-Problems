using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
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
        decimal totalparts = 0;
        //Value returnm Method for oilLube Changes
        private decimal OilLubeCharges()
        {
            decimal properValue = 0m;
            decimal oil = 26.00m;
            decimal lube = 18.00m;

            if (oilCheckBox.Checked)
            {
                properValue += oil;
            }
            if (lubeCheckBox.Checked)
            {
                properValue += lube;
            }
           
            return properValue;
        }

        //Value returning method for Flush group box
        private decimal FlushCharges()
        {
            decimal flushvalue = 0m;
            decimal rad = 30.00m;
            decimal trans = 80.00m;

            if (radiatorCheckBox.Checked)
            {
                flushvalue += rad;
            }
            if (transCheckBox.Checked)
            {
                flushvalue += trans;
            }
            return flushvalue;
        }
        // Value returning method for Misc charges
        private decimal Misccharges()
        {
            decimal miscvalue = 0m;
            decimal insp = 15.00m;
            decimal muff = 100.00m;
            decimal tire = 20.00m;
            if (inspCheckBox.Checked)
            {
                miscvalue += insp;
            }
            if (muffCheckBox.Checked)
            {
                miscvalue += muff;
            }
            if (tireCheckBox.Checked)
            {
                miscvalue +=tire;
            }
            return miscvalue;
        }

        // Value returning method for parts and labor
           private decimal otherCharges()
            {
           
            decimal parts = 0;
            

            if (decimal.TryParse(partsInput.Text, out parts))
            {
                partsOutput.Text = parts.ToString("c");
                totalparts = parts;
            }
            
            return parts;
     }

        //value returning method for tax calculation
       private decimal Taxcharges()
       {
           decimal tax = 0;
            tax = totalparts * 0.06m;
            taxOutputlabel.Text = tax.ToString("c");
           return tax;
        }           
            
     //Value returning for total charges method
        private decimal totalCharges()
        {
            decimal totalfee = 0;
            totalfee =   OilLubeCharges() + FlushCharges() + Misccharges() + otherCharges()+Taxcharges()+laborcharges();
            totalFeeOutput.Text = totalfee.ToString("c");
            return totalfee;

        }
        //value returning method for the labor charges
        private decimal laborcharges()
        {
            decimal labour = 0;
            decimal total = 0;

            if (decimal.TryParse(laborInput.Text, out labour))
            {
                 total += labour;
            }
            
            return total;
        }
       

        // Void methods for clearing the check box
        private void clearOilLube()
        {
            oilCheckBox.Checked = false;
            lubeCheckBox.Checked = false;
        }
        private void clearFlushes()
        {
            radiatorCheckBox.Checked = false;
            transCheckBox.Checked = false;
        }
        private void clearMisc()
        {
            inspCheckBox.Checked = false;
            muffCheckBox.Checked = false;
            tireCheckBox.Checked = false;
        }
        private void clearothers()
        {
            partsInput.Text = "";
            laborInput.Text = "";
        }
        private void clearFees()
        {
            laborOutput.Text = "";
            partsOutput.Text = "";
            taxOutputlabel.Text = "";
            totalFeeOutput.Text = "";
        }
       

        private void CalcOutputButton_Click(object sender, EventArgs e)
        {
             decimal servicelabor;
            servicelabor = OilLubeCharges() + FlushCharges() + Misccharges()+laborcharges();
            laborOutput.Text = servicelabor.ToString("c");
            Taxcharges();
            totalCharges();

        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearOilLube();
            clearFlushes();
            clearMisc();
            clearothers();
            clearFees();
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
