
namespace Tyuiu.KomarovMA.Sprint6.Task4.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KMA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KMA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KMA = new System.Windows.Forms.TextBox();
            this.labelEnd_KMA = new System.Windows.Forms.Label();
            this.labelStart_KMA = new System.Windows.Forms.Label();
            this.buttonDone_KMA = new System.Windows.Forms.Button();
            this.buttonSave_KMA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KMA = new System.Windows.Forms.TextBox();
            this.chartFunction_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KMA.SuspendLayout();
            this.groupBoxInput_KMA.SuspendLayout();
            this.groupBoxOutPut_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KMA
            // 
            this.groupBoxTask_KMA.Controls.Add(this.textBoxTask_KMA);
            this.groupBoxTask_KMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            this.groupBoxTask_KMA.Size = new System.Drawing.Size(447, 93);
            this.groupBoxTask_KMA.TabIndex = 0;
            this.groupBoxTask_KMA.TabStop = false;
            this.groupBoxTask_KMA.Text = "Условие";
            this.groupBoxTask_KMA.Enter += new System.EventHandler(this.groupBoxTask_KMA_Enter);
            // 
            // textBoxTask_KMA
            // 
            this.textBoxTask_KMA.Location = new System.Drawing.Point(6, 18);
            this.textBoxTask_KMA.Multiline = true;
            this.textBoxTask_KMA.Name = "textBoxTask_KMA";
            this.textBoxTask_KMA.ReadOnly = true;
            this.textBoxTask_KMA.Size = new System.Drawing.Size(438, 69);
            this.textBoxTask_KMA.TabIndex = 0;
            this.textBoxTask_KMA.Text = "Протабулировать функцию f(x) на заданном диапазоне [-5;5] ";
            // 
            // groupBoxInput_KMA
            // 
            this.groupBoxInput_KMA.Controls.Add(this.textBoxStop_KMA);
            this.groupBoxInput_KMA.Controls.Add(this.textBoxStart_KMA);
            this.groupBoxInput_KMA.Controls.Add(this.labelEnd_KMA);
            this.groupBoxInput_KMA.Controls.Add(this.labelStart_KMA);
            this.groupBoxInput_KMA.Location = new System.Drawing.Point(465, 12);
            this.groupBoxInput_KMA.Name = "groupBoxInput_KMA";
            this.groupBoxInput_KMA.Size = new System.Drawing.Size(264, 93);
            this.groupBoxInput_KMA.TabIndex = 1;
            this.groupBoxInput_KMA.TabStop = false;
            this.groupBoxInput_KMA.Text = "Ввод данных";
            // 
            // textBoxStop_KMA
            // 
            this.textBoxStop_KMA.Location = new System.Drawing.Point(156, 46);
            this.textBoxStop_KMA.Name = "textBoxStop_KMA";
            this.textBoxStop_KMA.Size = new System.Drawing.Size(102, 20);
            this.textBoxStop_KMA.TabIndex = 3;
            this.textBoxStop_KMA.TextChanged += new System.EventHandler(this.textBoxStop_KMA_TextChanged);
            // 
            // textBoxStart_KMA
            // 
            this.textBoxStart_KMA.Location = new System.Drawing.Point(9, 46);
            this.textBoxStart_KMA.Name = "textBoxStart_KMA";
            this.textBoxStart_KMA.Size = new System.Drawing.Size(76, 20);
            this.textBoxStart_KMA.TabIndex = 2;
            // 
            // labelEnd_KMA
            // 
            this.labelEnd_KMA.AutoSize = true;
            this.labelEnd_KMA.Location = new System.Drawing.Point(153, 21);
            this.labelEnd_KMA.Name = "labelEnd_KMA";
            this.labelEnd_KMA.Size = new System.Drawing.Size(70, 13);
            this.labelEnd_KMA.TabIndex = 1;
            this.labelEnd_KMA.Text = "Конец Шага:";
            // 
            // labelStart_KMA
            // 
            this.labelStart_KMA.AutoSize = true;
            this.labelStart_KMA.Location = new System.Drawing.Point(6, 21);
            this.labelStart_KMA.Name = "labelStart_KMA";
            this.labelStart_KMA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_KMA.TabIndex = 0;
            this.labelStart_KMA.Text = "Старт шага:";
            this.labelStart_KMA.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDone_KMA
            // 
            this.buttonDone_KMA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KMA.Location = new System.Drawing.Point(766, 30);
            this.buttonDone_KMA.Name = "buttonDone_KMA";
            this.buttonDone_KMA.Size = new System.Drawing.Size(73, 60);
            this.buttonDone_KMA.TabIndex = 2;
            this.buttonDone_KMA.Text = "Выполнить";
            this.buttonDone_KMA.UseVisualStyleBackColor = false;
            this.buttonDone_KMA.Click += new System.EventHandler(this.buttonDone_KMA_Click);
            // 
            // buttonSave_KMA
            // 
            this.buttonSave_KMA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_KMA.Location = new System.Drawing.Point(845, 30);
            this.buttonSave_KMA.Name = "buttonSave_KMA";
            this.buttonSave_KMA.Size = new System.Drawing.Size(73, 60);
            this.buttonSave_KMA.TabIndex = 3;
            this.buttonSave_KMA.Text = "Сохранить";
            this.buttonSave_KMA.UseVisualStyleBackColor = false;
            this.buttonSave_KMA.Click += new System.EventHandler(this.buttonSave_KMA_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(924, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.textBoxResult_KMA);
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(12, 111);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(297, 327);
            this.groupBoxOutPut_KMA.TabIndex = 1;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод данных";
            // 
            // textBoxResult_KMA
            // 
            this.textBoxResult_KMA.Location = new System.Drawing.Point(6, 18);
            this.textBoxResult_KMA.Multiline = true;
            this.textBoxResult_KMA.Name = "textBoxResult_KMA";
            this.textBoxResult_KMA.ReadOnly = true;
            this.textBoxResult_KMA.Size = new System.Drawing.Size(287, 303);
            this.textBoxResult_KMA.TabIndex = 0;
            // 
            // chartFunction_KMA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_KMA.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.chartFunction_KMA.Legends.Add(legend2);
            this.chartFunction_KMA.Location = new System.Drawing.Point(351, 129);
            this.chartFunction_KMA.Name = "chartFunction_KMA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_KMA.Series.Add(series2);
            this.chartFunction_KMA.Size = new System.Drawing.Size(646, 300);
            this.chartFunction_KMA.TabIndex = 1;
            this.chartFunction_KMA.Text = "chart1";
            title2.Name = "TitleFunc_KMA";
            title2.Text = "График Функции";
            this.chartFunction_KMA.Titles.Add(title2);
            // 
            // FormMain_KMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.chartFunction_KMA);
            this.Controls.Add(this.groupBoxOutPut_KMA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave_KMA);
            this.Controls.Add(this.buttonDone_KMA);
            this.Controls.Add(this.groupBoxInput_KMA);
            this.Controls.Add(this.groupBoxTask_KMA);
            this.Name = "FormMain_KMA";
            this.Text = "Спринт 6 | Таск 4 | Вариант 27 | Комаров М.А.";
            this.groupBoxTask_KMA.ResumeLayout(false);
            this.groupBoxTask_KMA.PerformLayout();
            this.groupBoxInput_KMA.ResumeLayout(false);
            this.groupBoxInput_KMA.PerformLayout();
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            this.groupBoxOutPut_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KMA;
        private System.Windows.Forms.TextBox textBoxTask_KMA;
        private System.Windows.Forms.GroupBox groupBoxInput_KMA;
        private System.Windows.Forms.Label labelStart_KMA;
        private System.Windows.Forms.Label labelEnd_KMA;
        private System.Windows.Forms.TextBox textBoxStop_KMA;
        private System.Windows.Forms.TextBox textBoxStart_KMA;
        private System.Windows.Forms.Button buttonDone_KMA;
        private System.Windows.Forms.Button buttonSave_KMA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.TextBox textBoxResult_KMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KMA;
    }
}

