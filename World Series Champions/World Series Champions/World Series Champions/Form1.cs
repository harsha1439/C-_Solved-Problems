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
namespace World_Series_Champions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        //read Teams from file
        private void ReadTeams(List<string> Teamlist)
        {
            try
            {
                StreamReader inputFile = File.OpenText("..\\..\\Teams.txt");
                while (!inputFile.EndOfStream)
                {
                    Teamlist.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Display teams from file
        private void DisplayTeams(List<string> Teamlist)
        {
            foreach (string team in Teamlist)
            {
                teamListBox.Items.Add(team);
            }
        }

        //Read winners from file
        private void ReadWinners(List<string> WinningList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("..\\..\\WorldSeriesWinners.txt");
                while (!inputFile.EndOfStream)
                {
                    WinningList.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void outputLabel_Click(object sender, EventArgs e)
        {
            List<string> Teamlist = new List<string>();
            List<string> WinningList = new List<string>();
            ReadWinners(WinningList); //Method calling for winners
            int c = 0;
            string selection;
            //selected index to the string
            if (teamListBox.SelectedIndex != -1)
            {
                selection = teamListBox.SelectedItem.ToString();
                foreach (string winners in WinningList)
                {
                    if (selection == winners)
                    {
                        c++;
                    }
                }
                MessageBox.Show(selection + "  had won world series championship " + c + " times");
            }
            else
            {
                MessageBox.Show("please select atleast one team");
            }     
       }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load event for the team list
            List<string> Teamlist = new List<string>();
            ReadTeams(Teamlist);
            DisplayTeams(Teamlist);
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
