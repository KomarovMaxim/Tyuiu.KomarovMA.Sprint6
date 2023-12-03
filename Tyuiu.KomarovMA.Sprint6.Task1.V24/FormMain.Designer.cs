
namespace Tyuiu.KomarovMA.Sprint6.Task1.V24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox_KMA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KMA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_KMA = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInput_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_KMA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KMA = new System.Windows.Forms.TextBox();
            this.labelEnd_KMA = new System.Windows.Forms.Label();
            this.labelStart_KMA = new System.Windows.Forms.Label();
            this.buttonResult_KMA = new System.Windows.Forms.Button();
            this.buttonRef_KMA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KMA = new System.Windows.Forms.TextBox();
            this.labelResult_KMA = new System.Windows.Forms.Label();
            this.groupBox_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KMA)).BeginInit();
            this.groupBoxInput_KMA.SuspendLayout();
            this.groupBoxOutPut_KMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_KMA
            // 
            this.groupBox_KMA.Controls.Add(this.pictureBoxFormula_KMA);
            this.groupBox_KMA.Controls.Add(this.textBoxTask_KMA);
            this.groupBox_KMA.Location = new System.Drawing.Point(12, 25);
            this.groupBox_KMA.Name = "groupBox_KMA";
            this.groupBox_KMA.Size = new System.Drawing.Size(425, 191);
            this.groupBox_KMA.TabIndex = 0;
            this.groupBox_KMA.TabStop = false;
            this.groupBox_KMA.Text = "Условие";
            // 
            // pictureBoxFormula_KMA
            // 
            this.pictureBoxFormula_KMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KMA.Image")));
            this.pictureBoxFormula_KMA.Location = new System.Drawing.Point(6, 46);
            this.pictureBoxFormula_KMA.Name = "pictureBoxFormula_KMA";
            this.pictureBoxFormula_KMA.Size = new System.Drawing.Size(342, 40);
            this.pictureBoxFormula_KMA.TabIndex = 1;
            this.pictureBoxFormula_KMA.TabStop = false;
            this.pictureBoxFormula_KMA.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxTask_KMA
            // 
            this.textBoxTask_KMA.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_KMA.Multiline = true;
            this.textBoxTask_KMA.Name = "textBoxTask_KMA";
            this.textBoxTask_KMA.ReadOnly = true;
            this.textBoxTask_KMA.Size = new System.Drawing.Size(425, 172);
            this.textBoxTask_KMA.TabIndex = 1;
            this.textBoxTask_KMA.Text = "Вывести таблицу значений функции f(x) на заданном диапазоне [-5;5] с шагом 1";
            // 
            // groupBoxInput_KMA
            // 
            this.groupBoxInput_KMA.Controls.Add(this.textBoxEnd_KMA);
            this.groupBoxInput_KMA.Controls.Add(this.textBoxStart_KMA);
            this.groupBoxInput_KMA.Controls.Add(this.labelEnd_KMA);
            this.groupBoxInput_KMA.Controls.Add(this.labelStart_KMA);
            this.groupBoxInput_KMA.Location = new System.Drawing.Point(12, 325);
            this.groupBoxInput_KMA.Name = "groupBoxInput_KMA";
            this.groupBoxInput_KMA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInput_KMA.TabIndex = 2;
            this.groupBoxInput_KMA.TabStop = false;
            this.groupBoxInput_KMA.Text = "Ввод данных";
            this.groupBoxInput_KMA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxEnd_KMA
            // 
            this.textBoxEnd_KMA.Location = new System.Drawing.Point(108, 58);
            this.textBoxEnd_KMA.Name = "textBoxEnd_KMA";
            this.textBoxEnd_KMA.Size = new System.Drawing.Size(78, 20);
            this.textBoxEnd_KMA.TabIndex = 5;
            // 
            // textBoxStart_KMA
            // 
            this.textBoxStart_KMA.Location = new System.Drawing.Point(9, 58);
            this.textBoxStart_KMA.Name = "textBoxStart_KMA";
            this.textBoxStart_KMA.Size = new System.Drawing.Size(78, 20);
            this.textBoxStart_KMA.TabIndex = 3;
            // 
            // labelEnd_KMA
            // 
            this.labelEnd_KMA.AutoSize = true;
            this.labelEnd_KMA.Location = new System.Drawing.Point(105, 16);
            this.labelEnd_KMA.Name = "labelEnd_KMA";
            this.labelEnd_KMA.Size = new System.Drawing.Size(41, 13);
            this.labelEnd_KMA.TabIndex = 4;
            this.labelEnd_KMA.Text = "Конец:";
            // 
            // labelStart_KMA
            // 
            this.labelStart_KMA.AutoSize = true;
            this.labelStart_KMA.Location = new System.Drawing.Point(6, 16);
            this.labelStart_KMA.Name = "labelStart_KMA";
            this.labelStart_KMA.Size = new System.Drawing.Size(39, 13);
            this.labelStart_KMA.TabIndex = 3;
            this.labelStart_KMA.Text = "Старт:";
            this.labelStart_KMA.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonResult_KMA
            // 
            this.buttonResult_KMA.BackColor = System.Drawing.Color.Green;
            this.buttonResult_KMA.Location = new System.Drawing.Point(369, 341);
            this.buttonResult_KMA.Name = "buttonResult_KMA";
            this.buttonResult_KMA.Size = new System.Drawing.Size(101, 65);
            this.buttonResult_KMA.TabIndex = 6;
            this.buttonResult_KMA.Text = "Выполнить";
            this.buttonResult_KMA.UseVisualStyleBackColor = false;
            this.buttonResult_KMA.Click += new System.EventHandler(this.buttonResult_KMA_Click);
            // 
            // buttonRef_KMA
            // 
            this.buttonRef_KMA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRef_KMA.Location = new System.Drawing.Point(288, 341);
            this.buttonRef_KMA.Name = "buttonRef_KMA";
            this.buttonRef_KMA.Size = new System.Drawing.Size(72, 65);
            this.buttonRef_KMA.TabIndex = 7;
            this.buttonRef_KMA.Text = "Справка";
            this.buttonRef_KMA.UseVisualStyleBackColor = false;
            this.buttonRef_KMA.Click += new System.EventHandler(this.buttonRef_KMA_Click);
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.textBoxResult_KMA);
            this.groupBoxOutPut_KMA.Controls.Add(this.labelResult_KMA);
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(486, 25);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(282, 381);
            this.groupBoxOutPut_KMA.TabIndex = 2;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод данных";
            // 
            // textBoxResult_KMA
            // 
            this.textBoxResult_KMA.Location = new System.Drawing.Point(28, 46);
            this.textBoxResult_KMA.Multiline = true;
            this.textBoxResult_KMA.Name = "textBoxResult_KMA";
            this.textBoxResult_KMA.ReadOnly = true;
            this.textBoxResult_KMA.Size = new System.Drawing.Size(223, 297);
            this.textBoxResult_KMA.TabIndex = 1;
            // 
            // labelResult_KMA
            // 
            this.labelResult_KMA.AutoSize = true;
            this.labelResult_KMA.Location = new System.Drawing.Point(6, 22);
            this.labelResult_KMA.Name = "labelResult_KMA";
            this.labelResult_KMA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KMA.TabIndex = 0;
            this.labelResult_KMA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutPut_KMA);
            this.Controls.Add(this.buttonRef_KMA);
            this.Controls.Add(this.buttonResult_KMA);
            this.Controls.Add(this.groupBoxInput_KMA);
            this.Controls.Add(this.groupBox_KMA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 24 | Комаров М.А.";
            this.groupBox_KMA.ResumeLayout(false);
            this.groupBox_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KMA)).EndInit();
            this.groupBoxInput_KMA.ResumeLayout(false);
            this.groupBoxInput_KMA.PerformLayout();
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            this.groupBoxOutPut_KMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_KMA;
        private System.Windows.Forms.TextBox textBoxTask_KMA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KMA;
        private System.Windows.Forms.GroupBox groupBoxInput_KMA;
        private System.Windows.Forms.Label labelStart_KMA;
        private System.Windows.Forms.Label labelEnd_KMA;
        private System.Windows.Forms.TextBox textBoxEnd_KMA;
        private System.Windows.Forms.TextBox textBoxStart_KMA;
        private System.Windows.Forms.Button buttonResult_KMA;
        private System.Windows.Forms.Button buttonRef_KMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.TextBox textBoxResult_KMA;
        private System.Windows.Forms.Label labelResult_KMA;
    }
}

