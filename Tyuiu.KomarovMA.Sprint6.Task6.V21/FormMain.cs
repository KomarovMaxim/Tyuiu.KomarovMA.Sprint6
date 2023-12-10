using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovMA.Sprint6.Task6.V21.Lib;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint6.Task6.V21
{
    public partial class FormMain_KMA : Form
    {
        public FormMain_KMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath_KMA;
        private void buttonDone_KMA_Click(object sender, EventArgs e)
        {
            string str = "g";
            textBoxOutPut_KMA.Text = ds.CollectTextFromFile(str, openFilePath_KMA);

        }

        private void buttonHelp_KMA_Click(object sender, EventArgs e)
        {
            FormAbout_KMA formabout = new FormAbout_KMA();
            formabout.ShowDialog();
        }

        private void buttonOpenFile_KMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KMA.ShowDialog();
            openFilePath_KMA = openFileDialogTask_KMA.FileName;
            textBoxInPut_KMA.Text = File.ReadAllText(openFilePath_KMA);
            groupBoxInput_KMA.Text = groupBoxInput_KMA.Text + " " + openFileDialogTask_KMA.FileName;
            buttonDone_KMA.Enabled = true;
        }
    }
}
