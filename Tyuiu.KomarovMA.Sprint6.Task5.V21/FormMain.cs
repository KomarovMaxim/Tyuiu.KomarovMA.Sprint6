using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovMA.Sprint6.Task5.V21.Lib;
namespace Tyuiu.KomarovMA.Sprint6.Task5.V21
{
    public partial class FormMain_KMA : Form
    {
        public FormMain_KMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"D:\SOURSE\Tyuiu.KomarovMA.Sprint6\Tyuiu.KomarovMA.Sprint6.Task5.V21\bin\Debug\InPutFileTask5V21.txt";
        private void FormMain_KMA_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-23-1 Комаров Максим Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_KMA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_KMA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KMA.ColumnCount = 2;
            dataGridViewResult_KMA.Columns[0].Width = 20;
            dataGridViewResult_KMA.Columns[1].Width = 50;
            this.chartFunction_KMA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_KMA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_KMA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KMA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_KMA.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonOpenFile_KMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
