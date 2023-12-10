
namespace Tyuiu.KomarovMA.Sprint6.Task5.V21
{
    partial class FormMain_KMA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KMA = new System.Windows.Forms.TextBox();
            this.buttonDone_KMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_KMA = new System.Windows.Forms.Button();
            this.buttonHelp_KMA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_KMA = new System.Windows.Forms.DataGridView();
            this.chartFunction_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KMA.SuspendLayout();
            this.groupBoxOutPut_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KMA
            // 
            this.groupBoxTask_KMA.Controls.Add(this.textBoxTask_KMA);
            this.groupBoxTask_KMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            this.groupBoxTask_KMA.Size = new System.Drawing.Size(456, 93);
            this.groupBoxTask_KMA.TabIndex = 0;
            this.groupBoxTask_KMA.TabStop = false;
            this.groupBoxTask_KMA.Text = "Условие";
            // 
            // textBoxTask_KMA
            // 
            this.textBoxTask_KMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_KMA.Multiline = true;
            this.textBoxTask_KMA.Name = "textBoxTask_KMA";
            this.textBoxTask_KMA.ReadOnly = true;
            this.textBoxTask_KMA.Size = new System.Drawing.Size(447, 68);
            this.textBoxTask_KMA.TabIndex = 0;
            this.textBoxTask_KMA.Text = "Прочитать данные из файла InPutFileTask5V21.txt. Вывести в dataGridView. Дан спис" +
    "ок из 20 чисел. Вывести все числа кратные 3.";
            // 
            // buttonDone_KMA
            // 
            this.buttonDone_KMA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KMA.Location = new System.Drawing.Point(474, 28);
            this.buttonDone_KMA.Name = "buttonDone_KMA";
            this.buttonDone_KMA.Size = new System.Drawing.Size(99, 68);
            this.buttonDone_KMA.TabIndex = 1;
            this.buttonDone_KMA.Text = "Выполнить";
            this.buttonDone_KMA.UseVisualStyleBackColor = false;
            this.buttonDone_KMA.Click += new System.EventHandler(this.buttonDone_KMA_Click);
            // 
            // buttonOpenFile_KMA
            // 
            this.buttonOpenFile_KMA.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpenFile_KMA.Location = new System.Drawing.Point(579, 28);
            this.buttonOpenFile_KMA.Name = "buttonOpenFile_KMA";
            this.buttonOpenFile_KMA.Size = new System.Drawing.Size(99, 68);
            this.buttonOpenFile_KMA.TabIndex = 2;
            this.buttonOpenFile_KMA.Text = "Открыть файл";
            this.buttonOpenFile_KMA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KMA.Click += new System.EventHandler(this.buttonOpenFile_KMA_Click);
            // 
            // buttonHelp_KMA
            // 
            this.buttonHelp_KMA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_KMA.Location = new System.Drawing.Point(684, 28);
            this.buttonHelp_KMA.Name = "buttonHelp_KMA";
            this.buttonHelp_KMA.Size = new System.Drawing.Size(99, 68);
            this.buttonHelp_KMA.TabIndex = 3;
            this.buttonHelp_KMA.Text = "Справка";
            this.buttonHelp_KMA.UseVisualStyleBackColor = false;
            this.buttonHelp_KMA.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.dataGridViewResult_KMA);
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(15, 111);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(200, 327);
            this.groupBoxOutPut_KMA.TabIndex = 4;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод данных";
            // 
            // dataGridViewResult_KMA
            // 
            this.dataGridViewResult_KMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_KMA.Name = "dataGridViewResult_KMA";
            this.dataGridViewResult_KMA.Size = new System.Drawing.Size(191, 305);
            this.dataGridViewResult_KMA.TabIndex = 0;
            // 
            // chartFunction_KMA
            // 
            this.chartFunction_KMA.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea3.Name = "ChartArea1";
            this.chartFunction_KMA.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartFunction_KMA.Legends.Add(legend3);
            this.chartFunction_KMA.Location = new System.Drawing.Point(231, 127);
            this.chartFunction_KMA.Name = "chartFunction_KMA";
            this.chartFunction_KMA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_KMA.Series.Add(series3);
            this.chartFunction_KMA.Size = new System.Drawing.Size(552, 300);
            this.chartFunction_KMA.TabIndex = 5;
            this.chartFunction_KMA.Text = "chart1";
            this.chartFunction_KMA.Click += new System.EventHandler(this.chartFunction_KMA_Click);
            // 
            // FormMain_KMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartFunction_KMA);
            this.Controls.Add(this.groupBoxOutPut_KMA);
            this.Controls.Add(this.buttonHelp_KMA);
            this.Controls.Add(this.buttonOpenFile_KMA);
            this.Controls.Add(this.buttonDone_KMA);
            this.Controls.Add(this.groupBoxTask_KMA);
            this.Name = "FormMain_KMA";
            this.Text = "Спринт 6 | Таск 5 | Вариант 21 | Комаров М.А.";
            this.Load += new System.EventHandler(this.FormMain_KMA_Load);
            this.groupBoxTask_KMA.ResumeLayout(false);
            this.groupBoxTask_KMA.PerformLayout();
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KMA;
        private System.Windows.Forms.TextBox textBoxTask_KMA;
        private System.Windows.Forms.Button buttonDone_KMA;
        private System.Windows.Forms.Button buttonOpenFile_KMA;
        private System.Windows.Forms.Button buttonHelp_KMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_KMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KMA;
    }
}

