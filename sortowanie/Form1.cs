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
            int wielkosc = 100000;
            int[] wylosowane = new int[wielkosc];
            int[] rosnace = new int[wielkosc];
            int[] malejace = new int[wielkosc];
            chart1.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";

            if (this.rosnace.Checked)
            {
                for(int i = 1; i < wielkosc; i++)
                {
                    rosnace[i] = i;
                }
            }
            if (this.malejace.Checked)
            {
                for (int i = wielkosc - 1; i > 0; i--)
                {
                    malejace[i] = i;
                }
            }
            if (losowe.Checked)
            {
                Random rnd = new Random();

                int poczatek = 0;
                int koniec = 1000;
                for (int i = 0; i < wielkosc - 1; i++)
                {

                    wylosowane[i] = rnd.Next(poczatek, koniec);
 
                }
            }
            if (babelkowe.Checked)
            {
                int[] liczby = new int[wielkosc];
                if (this.rosnace.Checked)
                {
                    Babelkowe.BubbleSort(rosnace);
                }
                if (this.malejace.Checked)
                {
                    Babelkowe.BubbleSort(malejace);
                }
                if (losowe.Checked)
                {
                    Babelkowe.BubbleSort(wylosowane);
                }
            }

            if (przez_wybor.Checked)
            {
                if (this.rosnace.Checked)
                {
                    PrzezWybor.BySelection(rosnace);
                }
                if (this.malejace.Checked)
                {
                    PrzezWybor.BySelection(malejace);
                }
                if (losowe.Checked)
                {
                    PrzezWybor.BySelection(wylosowane);
                }

            }
            if (przez_wstawianie.Checked)
            {
                PrzezWstawianie w = new PrzezWstawianie();
                if(this.rosnace.Checked)
                {
                    w.InsertionSort(rosnace);
                }
                if (this.malejace.Checked)
                {
                    w.InsertionSort(malejace);
                }
                if (losowe.Checked)
                {
                    w.InsertionSort(wylosowane);
                    
                        Series s = new Series("WSTAWIANIE");
                    s.Points.Add(w.Duration);
                    chart1.Series.Add(s);
                }
            }
            if (szybkie.Checked)
            {
                if (this.rosnace.Checked)
                { 
                    Szybkie.QuickSort(rosnace, 0, wielkosc - 1);
                }
                if (this.malejace.Checked)
                {
                    Szybkie.QuickSort(malejace, 0, wielkosc - 1);
                }
                if (losowe.Checked)
                {
                    Szybkie.QuickSort(wylosowane, 0, wielkosc - 1);
                }
            }
            if (przez_scalanie.Checked)
            {

            }
            

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}