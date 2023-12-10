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
using Tyuiu.KomarovMA.Sprint6.Task7.V15.Lib;
namespace Tyuiu.KomarovMA.Sprint6.Task7.V15
{
    public partial class FormMain_KMA : Form
    {
        public FormMain_KMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;
        public static int[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void FormMain_KMA_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            openFileDialogTask_KMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void groupBoxTask_KMA_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewOutPut_KMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_KMA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues1 = new int[rows, columns];
            arrayValues1 = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_KMA.Rows[r].Cells[c].Value = arrayValues1[r, c];
                }
            }
            buttonSave_KMA.Enabled = true;
        }

        private void buttonOpen_KMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KMA.ShowDialog();
            openFilePath = openFileDialogTask_KMA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_KMA.ColumnCount = columns;
            dataGridViewInPut_KMA.RowCount = rows;
            dataGridViewOutPut_KMA.ColumnCount = columns;
            dataGridViewOutPut_KMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_KMA.Columns[i].Width = 50;
                dataGridViewOutPut_KMA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_KMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KMA.Enabled = true;
        }

        private void buttonSave_KMA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KMA.FileName = "OutPutFileTask7v15.csv";
            saveFileDialogMatrix_KMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KMA.ShowDialog();

            string path = saveFileDialogMatrix_KMA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_KMA.RowCount;
            int columns = dataGridViewOutPut_KMA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_KMA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_KMA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_KMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
