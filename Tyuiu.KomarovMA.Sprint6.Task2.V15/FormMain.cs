using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovMA.Sprint6.Task2.V15.Lib;
namespace Tyuiu.KomarovMA.Sprint6.Task2.V15
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KMA.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_KMA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KMA.Titles.Add("График функции");
                this.chartFunction_KMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KMA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridOutPut_KMA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KMA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutPut_KMA_MouseEnter(object sender, EventArgs e)
        {
            buttonOutPut_KMA.BackColor = Color.Red;
        }

        private void buttonOutPut_KMA_MouseLeave(object sender, EventArgs e)
        {
            buttonOutPut_KMA.BackColor = Color.Green;
        }

        private void buttonHelp_KMA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Task2 выполнил студент группы СМАРТб-23-1 Комаров Максим Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
