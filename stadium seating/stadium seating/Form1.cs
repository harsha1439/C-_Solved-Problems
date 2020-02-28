using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stadium_seating
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {
            try { 
            double Atktprice = 15;
            double classa;
            double Arevenout;
            classa = double.Parse(classAticketsold.Text);
            Arevenout = classa * Atktprice;
            classAtotalreven.Text =Arevenout.ToString("c");
            double Btktprice = 12;
            double Bclass;
            double Brevenout;
            Bclass = double.Parse(classBticketsold.Text);
            Brevenout = Bclass * Btktprice;
            classBtotalreven.Text = Brevenout.ToString("c");
            double Ctktprice = 9;
            double Cclass;
            double Crevenout;
            Cclass = double.Parse(classCticketsold.Text);
            Crevenout = Cclass * Ctktprice;
            classCtotalreven.Text = Crevenout.ToString("c");
            double totoutput;
            totoutput = Arevenout + Brevenout + Crevenout;
            totalReven.Text = totoutput.ToString("c");
            }
            catch
            {
                MessageBox.Show("Invalid Data Entered");
            }

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearall_Click(object sender, EventArgs e)
        {
            classAticketsold.Text = "";
            classBticketsold.Text = "";
            classCticketsold.Text = "";
            classAtotalreven.Text = "";
            classBtotalreven.Text = "";
            classCtotalreven.Text = "";
            totalReven.Text = "";
        }

        private void ClassAticketsold_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
