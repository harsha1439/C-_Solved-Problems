using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
{
    public partial class form : Form
    {

        
        
        public form()
        {
            InitializeComponent();
        }

        private void FirstLetter_Click(object sender, EventArgs e)
        {
           
            outputLabel.Text = outputLabel.Text + firstLetter.Text;
        }

        private void EithLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + eigthLetter.Text;

        }

        private void TwentytwoLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + " ";
        }

        private void SeventhLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + seventhLetter.Text;
        }

        private void SecondLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + SecondLetter.Text;
        }
         private void FourthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + fourthLetter.Text;
        }

        private void ThirdLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + thirdLetter.Text;
        }
        private void FifthButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + fifthButton.Text;
        }

        private void SixthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + sixthLetter.Text;
        }

        private void NinthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + ninthLetter.Text;
        }

        private void TenthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + tenthLetter.Text;
        }

        private void EleventhLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + eleventhLetter.Text;
        }

        private void TwelevethLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + twelevethLetter.Text;
        }

        private void ThirteenLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + thirteenLetter.Text;
        }

        private void FourteenLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + fourteenLetter.Text;
        }

        private void FiftenLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + fiftenLetter.Text;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + sixteenLetter.Text;
        }

        private void SeventeenthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + seventeenthLetter.Text;
        }

        private void EighteenthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + eighteenthLetter.Text;
        }

        private void NinteenthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + ninteenthLetter.Text;
        }

        private void TwenthLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + twenthLetter.Text;
        }

        private void TwenthoneLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + twenthoneLetter.Text;
        }

        private void TwentythreeLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + twentythreeLetter.Text;
        }

        private void TwentyfourLetter_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputLabel.Text + twentyfourLetter.Text;
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
