namespace sortowanie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.przez_scalanie = new System.Windows.Forms.CheckBox();
            this.szybkie = new System.Windows.Forms.CheckBox();
            this.przez_wstawianie = new System.Windows.Forms.CheckBox();
            this.przez_wybor = new System.Windows.Forms.CheckBox();
            this.babelkowe = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.losowe = new System.Windows.Forms.CheckBox();
            this.spadajace = new System.Windows.Forms.CheckBox();
            this.zwiekszajace = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 510);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 330);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.przez_scalanie);
            this.groupBox2.Controls.Add(this.szybkie);
            this.groupBox2.Controls.Add(this.przez_wstawianie);
            this.groupBox2.Controls.Add(this.przez_wybor);
            this.groupBox2.Controls.Add(this.babelkowe);
            this.groupBox2.Location = new System.Drawing.Point(3, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rodzaj sortowania";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // przez_scalanie
            // 
            this.przez_scalanie.AutoSize = true;
            this.przez_scalanie.Location = new System.Drawing.Point(63, 122);
            this.przez_scalanie.Name = "przez_scalanie";
            this.przez_scalanie.Size = new System.Drawing.Size(94, 17);
            this.przez_scalanie.TabIndex = 4;
            this.przez_scalanie.Text = "Przez scalanie";
            this.przez_scalanie.UseVisualStyleBackColor = true;
            this.przez_scalanie.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // szybkie
            // 
            this.szybkie.AutoSize = true;
            this.szybkie.Location = new System.Drawing.Point(63, 99);
            this.szybkie.Name = "szybkie";
            this.szybkie.Size = new System.Drawing.Size(63, 17);
            this.szybkie.TabIndex = 3;
            this.szybkie.Text = "Szybkie";
            this.szybkie.UseVisualStyleBackColor = true;
            this.szybkie.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // przez_wstawianie
            // 
            this.przez_wstawianie.AutoSize = true;
            this.przez_wstawianie.Location = new System.Drawing.Point(63, 75);
            this.przez_wstawianie.Name = "przez_wstawianie";
            this.przez_wstawianie.Size = new System.Drawing.Size(107, 17);
            this.przez_wstawianie.TabIndex = 2;
            this.przez_wstawianie.Text = "Przez wstawianie";
            this.przez_wstawianie.UseVisualStyleBackColor = true;
            this.przez_wstawianie.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // przez_wybor
            // 
            this.przez_wybor.AutoSize = true;
            this.przez_wybor.Location = new System.Drawing.Point(63, 51);
            this.przez_wybor.Name = "przez_wybor";
            this.przez_wybor.Size = new System.Drawing.Size(83, 17);
            this.przez_wybor.TabIndex = 1;
            this.przez_wybor.Text = "Przez wybor";
            this.przez_wybor.UseVisualStyleBackColor = true;
            this.przez_wybor.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // babelkowe
            // 
            this.babelkowe.AutoSize = true;
            this.babelkowe.Location = new System.Drawing.Point(63, 28);
            this.babelkowe.Name = "babelkowe";
            this.babelkowe.Size = new System.Drawing.Size(79, 17);
            this.babelkowe.TabIndex = 0;
            this.babelkowe.Text = "Bąbelkowe";
            this.babelkowe.UseVisualStyleBackColor = true;
            this.babelkowe.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.losowe);
            this.groupBox1.Controls.Add(this.spadajace);
            this.groupBox1.Controls.Add(this.zwiekszajace);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj ciagu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // losowe
            // 
            this.losowe.AutoSize = true;
            this.losowe.Location = new System.Drawing.Point(63, 77);
            this.losowe.Name = "losowe";
            this.losowe.Size = new System.Drawing.Size(63, 17);
            this.losowe.TabIndex = 2;
            this.losowe.Text = "Losowe";
            this.losowe.UseVisualStyleBackColor = true;
            this.losowe.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // spadajace
            // 
            this.spadajace.AutoSize = true;
            this.spadajace.Location = new System.Drawing.Point(63, 54);
            this.spadajace.Name = "spadajace";
            this.spadajace.Size = new System.Drawing.Size(69, 17);
            this.spadajace.TabIndex = 1;
            this.spadajace.Text = "Malejace";
            this.spadajace.UseVisualStyleBackColor = true;
            this.spadajace.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // zwiekszajace
            // 
            this.zwiekszajace.AutoSize = true;
            this.zwiekszajace.Location = new System.Drawing.Point(63, 30);
            this.zwiekszajace.Name = "zwiekszajace";
            this.zwiekszajace.Size = new System.Drawing.Size(69, 17);
            this.zwiekszajace.TabIndex = 0;
            this.zwiekszajace.Text = "Rosnace";
            this.zwiekszajace.UseVisualStyleBackColor = true;
            this.zwiekszajace.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(203, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(527, 504);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(200, 390);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox przez_scalanie;
        private System.Windows.Forms.CheckBox szybkie;
        private System.Windows.Forms.CheckBox przez_wstawianie;
        private System.Windows.Forms.CheckBox przez_wybor;
        private System.Windows.Forms.CheckBox babelkowe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox losowe;
        private System.Windows.Forms.CheckBox spadajace;
        private System.Windows.Forms.CheckBox zwiekszajace;
    }
}
