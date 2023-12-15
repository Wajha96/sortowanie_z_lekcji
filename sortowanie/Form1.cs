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

            if (zwiekszajace.Checked)
            {
                for(int i = 0; i < wielkosc; i++)
                {
                    rosnace[i] = i;
                }
            }
            if (spadajace.Checked)
            {
                int b = 0;
                for (int i = 0; i < wielkosc; i++)
                {
                    b = wielkosc;
                    malejace[i] = b-i;
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
            if (przez_wstawianie.Checked)
            {
                PrzezWstawianie w = new PrzezWstawianie();
                if (zwiekszajace.Checked)
                {
                    w.InsertionSort(rosnace);
                    Series wr = new Series("WSTAWIANIE-rosnancy");
                    wr.Points.Add(w.Duration);
                    chart1.Series.Add(wr);
                }
                if (spadajace.Checked)
                {
                    w.InsertionSort(malejace);
                    Series wm = new Series("WSTAWIANIE-malejace");
                    wm.Points.Add(w.Duration);
                    chart1.Series.Add(wm);
                }
                if (losowe.Checked)
                {
                    w.InsertionSort(wylosowane);
                    Series ws = new Series("WSTAWIANIE-wylosowane");
                    ws.Points.Add(w.Duration);
                    chart1.Series.Add(ws);
                }
            }

            if (babelkowe.Checked)
            {
                Babelkowe b = new Babelkowe();
                if (zwiekszajace.Checked)
                {
                    b.BubbleSort(rosnace);
                    Series br = new Series("babelkowe-rosnace");
                    br.Points.Add(b.Duration);
                    chart1.Series.Add(br);
                }
                if (spadajace.Checked)
                {
                    b.BubbleSort(malejace);
                    Series bm = new Series("babelkowe-malejace");
                    bm.Points.Add(b.Duration);
                    chart1.Series.Add(bm);
                }
                if (losowe.Checked)
                {
                    b.BubbleSort(wylosowane);
                    Series bs = new Series("babelkowe-wylosowane");
                    bs.Points.Add(b.Duration);
                    chart1.Series.Add(bs);
                }
            }
           

            if (przez_wybor.Checked)
            {
                if (this.zwiekszajace.Checked)
                {
                    PrzezWybor.BySelection(rosnace);
                }
                if (this.spadajace.Checked)
                {
                    PrzezWybor.BySelection(malejace);
                }
                if (losowe.Checked)
                {
                    PrzezWybor.BySelection(wylosowane);
                }

            }
            if (szybkie.Checked)
            {
                if (this.zwiekszajace.Checked)
                { 
                    Szybkie.QuickSort(rosnace, 0, wielkosc - 1);
                }
                if (this.spadajace.Checked)
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

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}