
namespace Tyuiu.KomarovMA.Sprint6.Task2.V15
{
    partial class FormMain
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
            this.groupBoxInfo_KMA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_KMA = new System.Windows.Forms.GroupBox();
            this.labelEnd_KMA = new System.Windows.Forms.Label();
            this.labelStart_KMA = new System.Windows.Forms.Label();
            this.textBoxEnd_KMA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KMA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KMA = new System.Windows.Forms.Button();
            this.buttonOutPut_KMA = new System.Windows.Forms.Button();
            this.dataGridOutPut_KMA = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.labelOutPut_KMA = new System.Windows.Forms.Label();
            this.chartFunction_KMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X_KMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FX_KMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInfo_KMA.SuspendLayout();
            this.groupBoxInPut_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutPut_KMA)).BeginInit();
            this.groupBoxOutPut_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo_KMA
            // 
            this.groupBoxInfo_KMA.Controls.Add(this.textBox1);
            this.groupBoxInfo_KMA.Location = new System.Drawing.Point(12, 23);
            this.groupBoxInfo_KMA.Name = "groupBoxInfo_KMA";
            this.groupBoxInfo_KMA.Size = new System.Drawing.Size(354, 264);
            this.groupBoxInfo_KMA.TabIndex = 0;
            this.groupBoxInfo_KMA.TabStop = false;
            this.groupBoxInfo_KMA.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(342, 239);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию (2Sin(x))/(3x+1,2)+COS(x)-7x*2 на заданном диапазоне.\r\nРе" +
    "зультат вывести в таблице.";
            // 
            // groupBoxInPut_KMA
            // 
            this.groupBoxInPut_KMA.Controls.Add(this.labelEnd_KMA);
            this.groupBoxInPut_KMA.Controls.Add(this.labelStart_KMA);
            this.groupBoxInPut_KMA.Controls.Add(this.textBoxEnd_KMA);
            this.groupBoxInPut_KMA.Controls.Add(this.textBoxStart_KMA);
            this.groupBoxInPut_KMA.Location = new System.Drawing.Point(18, 293);
            this.groupBoxInPut_KMA.Name = "groupBoxInPut_KMA";
            this.groupBoxInPut_KMA.Size = new System.Drawing.Size(248, 94);
            this.groupBoxInPut_KMA.TabIndex = 1;
            this.groupBoxInPut_KMA.TabStop = false;
            this.groupBoxInPut_KMA.Text = "Ввод данных";
            // 
            // labelEnd_KMA
            // 
            this.labelEnd_KMA.AutoSize = true;
            this.labelEnd_KMA.Location = new System.Drawing.Point(132, 31);
            this.labelEnd_KMA.Name = "labelEnd_KMA";
            this.labelEnd_KMA.Size = new System.Drawing.Size(70, 13);
            this.labelEnd_KMA.TabIndex = 3;
            this.labelEnd_KMA.Text = "Конец Шага:";
            // 
            // labelStart_KMA
            // 
            this.labelStart_KMA.AutoSize = true;
            this.labelStart_KMA.Location = new System.Drawing.Point(6, 31);
            this.labelStart_KMA.Name = "labelStart_KMA";
            this.labelStart_KMA.Size = new System.Drawing.Size(68, 13);
            this.labelStart_KMA.TabIndex = 2;
            this.labelStart_KMA.Text = "Старт Шага:";
            // 
            // textBoxEnd_KMA
            // 
            this.textBoxEnd_KMA.Location = new System.Drawing.Point(135, 60);
            this.textBoxEnd_KMA.Name = "textBoxEnd_KMA";
            this.textBoxEnd_KMA.Size = new System.Drawing.Size(107, 20);
            this.textBoxEnd_KMA.TabIndex = 1;
            // 
            // textBoxStart_KMA
            // 
            this.textBoxStart_KMA.Location = new System.Drawing.Point(6, 60);
            this.textBoxStart_KMA.Name = "textBoxStart_KMA";
            this.textBoxStart_KMA.Size = new System.Drawing.Size(111, 20);
            this.textBoxStart_KMA.TabIndex = 0;
            // 
            // buttonHelp_KMA
            // 
            this.buttonHelp_KMA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_KMA.Location = new System.Drawing.Point(272, 299);
            this.buttonHelp_KMA.Name = "buttonHelp_KMA";
            this.buttonHelp_KMA.Size = new System.Drawing.Size(78, 88);
            this.buttonHelp_KMA.TabIndex = 4;
            this.buttonHelp_KMA.Text = "Справка";
            this.buttonHelp_KMA.UseVisualStyleBackColor = false;
            this.buttonHelp_KMA.Click += new System.EventHandler(this.buttonHelp_KMA_Click);
            // 
            // buttonOutPut_KMA
            // 
            this.buttonOutPut_KMA.BackColor = System.Drawing.Color.Green;
            this.buttonOutPut_KMA.Location = new System.Drawing.Point(356, 299);
            this.buttonOutPut_KMA.Name = "buttonOutPut_KMA";
            this.buttonOutPut_KMA.Size = new System.Drawing.Size(101, 88);
            this.buttonOutPut_KMA.TabIndex = 5;
            this.buttonOutPut_KMA.Text = "Выполнить";
            this.buttonOutPut_KMA.UseVisualStyleBackColor = false;
            this.buttonOutPut_KMA.Click += new System.EventHandler(this.button1_Click);
            this.buttonOutPut_KMA.MouseEnter += new System.EventHandler(this.buttonOutPut_KMA_MouseEnter);
            this.buttonOutPut_KMA.MouseLeave += new System.EventHandler(this.buttonOutPut_KMA_MouseLeave);
            // 
            // dataGridOutPut_KMA
            // 
            this.dataGridOutPut_KMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOutPut_KMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_KMA,
            this.FX_KMA});
            this.dataGridOutPut_KMA.Location = new System.Drawing.Point(6, 45);
            this.dataGridOutPut_KMA.Name = "dataGridOutPut_KMA";
            this.dataGridOutPut_KMA.ReadOnly = true;
            this.dataGridOutPut_KMA.RowHeadersVisible = false;
            this.dataGridOutPut_KMA.Size = new System.Drawing.Size(121, 213);
            this.dataGridOutPut_KMA.TabIndex = 6;
            this.dataGridOutPut_KMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.chartFunction_KMA);
            this.groupBoxOutPut_KMA.Controls.Add(this.labelOutPut_KMA);
            this.groupBoxOutPut_KMA.Controls.Add(this.dataGridOutPut_KMA);
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(372, 23);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(416, 264);
            this.groupBoxOutPut_KMA.TabIndex = 1;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод данных";
            // 
            // labelOutPut_KMA
            // 
            this.labelOutPut_KMA.AutoSize = true;
            this.labelOutPut_KMA.Location = new System.Drawing.Point(6, 29);
            this.labelOutPut_KMA.Name = "labelOutPut_KMA";
            this.labelOutPut_KMA.Size = new System.Drawing.Size(59, 13);
            this.labelOutPut_KMA.TabIndex = 7;
            this.labelOutPut_KMA.Text = "Результат";
            // 
            // chartFunction_KMA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_KMA.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartFunction_KMA.Legends.Add(legend3);
            this.chartFunction_KMA.Location = new System.Drawing.Point(150, 55);
            this.chartFunction_KMA.Name = "chartFunction_KMA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_KMA.Series.Add(series3);
            this.chartFunction_KMA.Size = new System.Drawing.Size(249, 203);
            this.chartFunction_KMA.TabIndex = 8;
            this.chartFunction_KMA.Text = "chart1";
            // 
            // X_KMA
            // 
            this.X_KMA.HeaderText = "X";
            this.X_KMA.Name = "X_KMA";
            this.X_KMA.ReadOnly = true;
            this.X_KMA.Width = 55;
            // 
            // FX_KMA
            // 
            this.FX_KMA.HeaderText = "F(X)";
            this.FX_KMA.Name = "FX_KMA";
            this.FX_KMA.ReadOnly = true;
            this.FX_KMA.Width = 55;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.groupBoxOutPut_KMA);
            this.Controls.Add(this.buttonOutPut_KMA);
            this.Controls.Add(this.buttonHelp_KMA);
            this.Controls.Add(this.groupBoxInPut_KMA);
            this.Controls.Add(this.groupBoxInfo_KMA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxInfo_KMA.ResumeLayout(false);
            this.groupBoxInfo_KMA.PerformLayout();
            this.groupBoxInPut_KMA.ResumeLayout(false);
            this.groupBoxInPut_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutPut_KMA)).EndInit();
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            this.groupBoxOutPut_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_KMA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_KMA;
        private System.Windows.Forms.Label labelEnd_KMA;
        private System.Windows.Forms.Label labelStart_KMA;
        private System.Windows.Forms.TextBox textBoxEnd_KMA;
        private System.Windows.Forms.TextBox textBoxStart_KMA;
        private System.Windows.Forms.Button buttonHelp_KMA;
        private System.Windows.Forms.Button buttonOutPut_KMA;
        private System.Windows.Forms.DataGridView dataGridOutPut_KMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.Label labelOutPut_KMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_KMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FX_KMA;
    }
}

