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

namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //to read boys file
        private void boysRead(List<string> boyslist)
        {
            try
            {
                StreamReader inputFile = File.OpenText("..\\..\\BoyNames.txt");
                while (!inputFile.EndOfStream)
                {
                    boyslist.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
       
        //to read girls file
        private void girlsRead(List<string> girlslist)
        {
            try
            {
                StreamReader inputFile2 = File.OpenText("..\\..\\GirlNames.txt");
                while (!inputFile2.EndOfStream)
                {
                    girlslist.Add(inputFile2.ReadLine());
                    
                }
                inputFile2.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
           
            List<string> boylist = new List<string>();
            List<string> girllist = new List<string>();
            boysRead(boylist);
            girlsRead(girllist);

            string boysInput = boyNameInput.Text;
            string girlsInput = girlNameInput.Text;
            // for checking the boylist items

            try {
               
                if (boylist.Contains(boysInput) && girllist.Contains(girlsInput))
                {
                    MessageBox.Show("Both Were the most popular names");
                }
                
                else if(boylist.Contains(boysInput) && !girllist.Contains(girlsInput))
                { 
                    MessageBox.Show(boysInput + " name was among the most popular name");
                }
                else if (!boylist.Contains(boysInput) && girllist.Contains(girlsInput))
                {
                    MessageBox.Show(girlsInput + " was among the most popular name");
                }
                else
                {
                    MessageBox.Show("InputNames were not among the most popular names");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //for checking the girl list items
           




        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void Exitall_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            boyNameInput.Text = "";
            girlNameInput.Text = "";
        }
    }
}
