using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sortowanie
{
    public partial class Form1 : Form
    {
        Series series = new Series();
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();

            chart1.Series.Add(series);
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //rosnace

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //malejace
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //losowe
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //bombelkowe
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //przez wybor
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //przez wstawianie
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //szybkie
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //przez scalanie
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] wylosowane = new int[100];
            int[] rosnace = new int[100];
            int[] malejace = new int[100];
            


            chart1.Series.Clear();
            chart1.Series.Add(series);

            //start
            if (checkBox1.Checked)
            {
                
            }
            if (checkBox2.Checked)
            {

            }
            if (checkBox3.Checked)
            {

                //losowe
                Random rnd = new Random();

                int poczatek = 0;
                int koniec = 100;
                for (int i = 0; i < 99; i++)
                {

                    wylosowane[i] = rnd.Next(poczatek, koniec); // dla przedziału 0-10
 
                }
            }
            if (checkBox4.Checked)
            {
               
                //bombelkowe
                if (checkBox1.Checked)
                { 

                }
                if (checkBox2.Checked)
                {

                }
                if (checkBox3.Checked)
                {
                    //tablica tablic
                    int[] ciag = new int[3];
                    int[] liczby = new int[100];
                }
                    int n = wylosowane.Length;
                    for (int i = 0; i < n - 1; i++)
                    {
                   
                        for (int j = 0; j < n - i - 1; j++)
                            if (wylosowane[j] > wylosowane[j + 1])
                            {
                                int temp = wylosowane[j];
                                wylosowane[j] = wylosowane[j + 1];
                                wylosowane[j + 1] = temp;

                            }
                    }
                    for (int k = 0;k < 99;k++)
                    {
                        series.Points.Add(wylosowane[k]);
                    }


               
            }
            if (checkBox5.Checked)
            {
                //przez wybor
                if (checkBox1.Checked)
                {

                }
                if (checkBox2.Checked)
                {

                }
                if (checkBox3.Checked)
                {
                    int n = wylosowane.Length;
                    for (int i = 0; i < n - 1; i++)
                    {
                    
                        int min_idx = i;
                        for (int j = i + 1; j < n; j++)
                            if (wylosowane[j] < wylosowane[min_idx])
                                min_idx = j;

                  
                        int temp = wylosowane[min_idx];
                        wylosowane[min_idx] = wylosowane[i];
                        wylosowane[i] = temp;
                    }
                    for (int k = 0; k < 99; k++)
                    {
                        series.Points.Add(wylosowane[k]);
                    }

                }

            }
            if (checkBox6.Checked)
            {

            }
            if (checkBox7.Checked)
            {

            }
            if (checkBox8.Checked)
            {

            }
            

        }
    }
}