
namespace Tyuiu.KomarovMA.Sprint6.Task3.V29
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
            this.groupBoxTask_KMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewRes_KMA = new System.Windows.Forms.DataGridView();
            this.buttonDone_KMA = new System.Windows.Forms.Button();
            this.buttonHelp_KMA = new System.Windows.Forms.Button();
            this.dataGridViewInPut_KMA = new System.Windows.Forms.DataGridView();
            this.labelInPut_KMA = new System.Windows.Forms.Label();
            this.groupBoxTask_KMA.SuspendLayout();
            this.groupBoxOutPut_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_KMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KMA
            // 
            this.groupBoxTask_KMA.Controls.Add(this.labelInPut_KMA);
            this.groupBoxTask_KMA.Controls.Add(this.dataGridViewInPut_KMA);
            this.groupBoxTask_KMA.Controls.Add(this.textBox1);
            this.groupBoxTask_KMA.Location = new System.Drawing.Point(3, 23);
            this.groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            this.groupBoxTask_KMA.Size = new System.Drawing.Size(503, 357);
            this.groupBoxTask_KMA.TabIndex = 0;
            this.groupBoxTask_KMA.TabStop = false;
            this.groupBoxTask_KMA.Text = "Условие";
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.dataGridViewRes_KMA);
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(512, 23);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(243, 357);
            this.groupBoxOutPut_KMA.TabIndex = 1;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод данных";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(218, 230);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дан массив 5 на 5 элементов.\r\nВыполнить сортировку по возрастанию в пятом столбце" +
    ".\r\n -2 -13 -15  -9 -17\r\n\r\n  13 -20 -15  27  18\r\n\r\n -12  -1 -20  13   0\r\n\r\n  15  " +
    "32  18 -12 -18\r\n\r\n  16   5   3  -5  -8";
            // 
            // dataGridViewRes_KMA
            // 
            this.dataGridViewRes_KMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_KMA.Location = new System.Drawing.Point(17, 28);
            this.dataGridViewRes_KMA.Name = "dataGridViewRes_KMA";
            this.dataGridViewRes_KMA.Size = new System.Drawing.Size(201, 257);
            this.dataGridViewRes_KMA.TabIndex = 2;
            // 
            // buttonDone_KMA
            // 
            this.buttonDone_KMA.Location = new System.Drawing.Point(655, 386);
            this.buttonDone_KMA.Name = "buttonDone_KMA";
            this.buttonDone_KMA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_KMA.TabIndex = 3;
            this.buttonDone_KMA.Text = "Выполнить";
            this.buttonDone_KMA.UseVisualStyleBackColor = true;
            this.buttonDone_KMA.Click += new System.EventHandler(this.buttonDone_KMA_Click);
            // 
            // buttonHelp_KMA
            // 
            this.buttonHelp_KMA.Location = new System.Drawing.Point(622, 386);
            this.buttonHelp_KMA.Name = "buttonHelp_KMA";
            this.buttonHelp_KMA.Size = new System.Drawing.Size(27, 23);
            this.buttonHelp_KMA.TabIndex = 4;
            this.buttonHelp_KMA.Text = "?";
            this.buttonHelp_KMA.UseVisualStyleBackColor = true;
            this.buttonHelp_KMA.Click += new System.EventHandler(this.buttonHelp_KMA_Click);
            // 
            // dataGridViewInPut_KMA
            // 
            this.dataGridViewInPut_KMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_KMA.Location = new System.Drawing.Point(249, 55);
            this.dataGridViewInPut_KMA.Name = "dataGridViewInPut_KMA";
            this.dataGridViewInPut_KMA.Size = new System.Drawing.Size(248, 230);
            this.dataGridViewInPut_KMA.TabIndex = 5;
            // 
            // labelInPut_KMA
            // 
            this.labelInPut_KMA.AutoSize = true;
            this.labelInPut_KMA.Location = new System.Drawing.Point(246, 28);
            this.labelInPut_KMA.Name = "labelInPut_KMA";
            this.labelInPut_KMA.Size = new System.Drawing.Size(72, 13);
            this.labelInPut_KMA.TabIndex = 6;
            this.labelInPut_KMA.Text = "Ввод данных";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_KMA);
            this.Controls.Add(this.buttonDone_KMA);
            this.Controls.Add(this.groupBoxOutPut_KMA);
            this.Controls.Add(this.groupBoxTask_KMA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 29 | Комаров М.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KMA.ResumeLayout(false);
            this.groupBoxTask_KMA.PerformLayout();
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_KMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KMA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewRes_KMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.Button buttonDone_KMA;
        private System.Windows.Forms.Button buttonHelp_KMA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_KMA;
        private System.Windows.Forms.Label labelInPut_KMA;
    }
}

