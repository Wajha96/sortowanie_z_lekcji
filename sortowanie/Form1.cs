using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            int wielkosc = 10000;
            int[] wylosowane = new int[wielkosc];
            int[] rosnace = new int[wielkosc];
            int[] malejace = new int[wielkosc];
            chart1.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";


            //start
            if (this.rosnace.Checked)
            {
                //rosnace
                for(int i = 1; i < wielkosc; i++)
                {
                    rosnace[i] = i;
                }
            }
            if (this.malejace.Checked)
            {
                //malejace
                for (int i = wielkosc - 1; i > 0; i--)
                {
                    malejace[i] = i;
                }
            }
            if (losowe.Checked)
            {

                //losowe
                Random rnd = new Random();

                int poczatek = 0;
                int koniec = 1000;
                for (int i = 0; i < wielkosc - 1; i++)
                {

                    wylosowane[i] = rnd.Next(poczatek, koniec); // dla przedziału 0-10
 
                }
            }
            if (babelkowe.Checked)
            {
               

                int[] liczby = new int[wielkosc];
                //bąbelkowe
                if (this.rosnace.Checked)
                {
                chart1.Series.Clear();
                chart1.Series.Add(series);
                chart1.Series.First().Name = "Bąbelkowe_Rosnace";
                    for (int i = 0; i < wielkosc; i++)
                    {
                        liczby[i] = rosnace[i];
                    }
                    int start, stop;
                    start = Environment.TickCount & int.MaxValue;
                    for (int i = 0; i < wielkosc - 1; i++)
                        {
                   
                            for (int j = 0; j < wielkosc - i - 1; j++)
                                if (liczby[j] > liczby[j + 1])
                                {
                                    int temp = liczby[j];
                                    liczby[j] = liczby[j + 1];
                                    liczby[j + 1] = temp;

                                }
                        }
                    stop = Environment.TickCount & int.MaxValue;
                    series.Points.Add(stop - start);
                    
                }
                if (this.malejace.Checked)
                {
                    chart1.Series.Clear();
                    chart1.Series.Add(series);
                    chart1.Series.First().Name = "Bąbelkowe_malejace";
                    for (int i = 0; i < wielkosc; i++)
                    {
                        liczby[i] = malejace[i];
                    }
                    int start, stop;
                    start = Environment.TickCount & int.MaxValue;
                    for (int i = 0; i < wielkosc - 1; i++)
                    {

                        for (int j = 0; j < wielkosc - i - 1; j++)
                            if (liczby[j] > liczby[j + 1])
                            {
                                int temp = liczby[j];
                                liczby[j] = liczby[j + 1];
                                liczby[j + 1] = temp;

                            }
                    }
                    stop = Environment.TickCount & int.MaxValue;
                    series.Points.Add(stop - start);
                }
                if (losowe.Checked)
                {
                    for (int i = 0; i < wielkosc; i++)
                    {
                        liczby[i] = wylosowane[i];
                    }
                    int start, stop;
                    start = Environment.TickCount & Int32.MaxValue;
                    for (int i = 0; i < wielkosc - 1; i++)
                    {

                        for (int j = 0; j < wielkosc - i - 1; j++)
                            if (liczby[j] > liczby[j + 1])
                            {
                                int temp = liczby[j];
                                liczby[j] = liczby[j + 1];
                                liczby[j + 1] = temp;

                            }
                    }
                    stop = Environment.TickCount & Int32.MaxValue;
                    series.Points.Add(stop - start);
                }
             






            }
            if (przez_wybor.Checked)
            {
                //przez wybor
                if (this.rosnace.Checked)
                {

                }
                if (this.malejace.Checked)
                {

                }
                if (losowe.Checked)
                {
                    for (int i = 0; i < wielkosc - 1; i++)
                    {
                    
                        int min_idx = i;
                        for (int j = i + 1; j < wielkosc; j++)
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
            if (przez_wstawianie.Checked)
            {

            }
            if (szybkie.Checked)
            {

            }
            if (przez_scalanie.Checked)
            {

            }
            

        }
    }
}