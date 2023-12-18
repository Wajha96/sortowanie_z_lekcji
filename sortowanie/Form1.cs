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
      
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
  
          
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
            chart1.Series.Clear();
            
            int wielkosc = 10000;
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
                int koniec = wielkosc*2;
                for (int i = 0; i < wielkosc - 1; i++)
                {
                    wylosowane[i] = rnd.Next(poczatek, koniec);
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
                PrzezWybor wyb = new PrzezWybor();
                if (zwiekszajace.Checked)
                {
                    wyb.BySelection(rosnace);
                    Series wybr = new Series("wybor-rosnace");
                    wybr.Points.Add(wyb.Duration);
                    chart1.Series.Add(wybr);
                }
                if (spadajace.Checked)
                {
                    wyb.BySelection(malejace);
                    Series wybm = new Series("wybor-malejace");
                    wybm.Points.Add(wyb.Duration);
                    chart1.Series.Add(wybm);
                }
                if (losowe.Checked)
                {
                    wyb.BySelection(wylosowane);
                    Series wybs = new Series("wybor-wylosowane");
                    wybs.Points.Add(wyb.Duration);
                    chart1.Series.Add(wybs);
                }

            }
            if (przez_wstawianie.Checked)
            {
                PrzezWstawianie wst = new PrzezWstawianie();
                if (zwiekszajace.Checked)
                {
                    wst.InsertionSort(rosnace);
                    Series wr = new Series("wstawianie-rosnancy");
                    wr.Points.Add(wst.Duration);
                    chart1.Series.Add(wr);
                }
                if (spadajace.Checked)
                {
                    wst.InsertionSort(malejace);
                    Series wm = new Series("wstawianie-malejace");
                    wm.Points.Add(wst.Duration);
                    chart1.Series.Add(wm);
                }
                if (losowe.Checked)
                {
                    wst.InsertionSort(wylosowane);
                    Series ws = new Series("wstawianie-wylosowane");
                    ws.Points.Add(wst.Duration);
                    chart1.Series.Add(ws);
                }
            }
            if (szybkie.Checked)
            {
                Szybkie s = new Szybkie();
                if (zwiekszajace.Checked)
                { 
                    s.QuickSort(rosnace, 0, wielkosc - 1);
                    Series sr = new Series("szybkie-rosnace");
                    sr.Points.Add(s.Duration);
                    chart1.Series.Add(sr);
                }
                if (spadajace.Checked)
                {
                    s.QuickSort(malejace, 0, wielkosc - 1);
                    Series sm = new Series("szybkie-malejace");
                    sm.Points.Add(s.Duration);
                    chart1.Series.Add(sm);
                }
                if (losowe.Checked)
                {
                    s.QuickSort(wylosowane, 0, wielkosc - 1);
                    Series ss = new Series("szybkie-losowe");
                    ss.Points.Add(s.Duration);
                    chart1.Series.Add(ss);
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