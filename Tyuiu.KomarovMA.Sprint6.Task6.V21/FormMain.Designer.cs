
namespace Tyuiu.KomarovMA.Sprint6.Task6.V21
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KMA));
            this.groupBoxTask_KMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_KMA = new System.Windows.Forms.Button();
            this.buttonHelp_KMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_KMA = new System.Windows.Forms.Button();
            this.textBoxTask_KMA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_KMA = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_KMA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_KMA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KMA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask_KMA.SuspendLayout();
            this.groupBoxInput_KMA.SuspendLayout();
            this.groupBoxOutPut_KMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KMA
            // 
            this.groupBoxTask_KMA.Controls.Add(this.textBoxTask_KMA);
            this.groupBoxTask_KMA.Location = new System.Drawing.Point(8, 64);
            this.groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            this.groupBoxTask_KMA.Size = new System.Drawing.Size(780, 100);
            this.groupBoxTask_KMA.TabIndex = 0;
            this.groupBoxTask_KMA.TabStop = false;
            this.groupBoxTask_KMA.Text = "Условие";
            // 
            // buttonDone_KMA
            // 
            this.buttonDone_KMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KMA.Image")));
            this.buttonDone_KMA.Location = new System.Drawing.Point(8, 12);
            this.buttonDone_KMA.Name = "buttonDone_KMA";
            this.buttonDone_KMA.Size = new System.Drawing.Size(68, 45);
            this.buttonDone_KMA.TabIndex = 0;
            this.toolTip_KMA.SetToolTip(this.buttonDone_KMA, "Открыть файл. \r\nВыберите нужный файл для обработки.");
            this.buttonDone_KMA.UseVisualStyleBackColor = true;
            this.buttonDone_KMA.Click += new System.EventHandler(this.buttonDone_KMA_Click);
            // 
            // buttonHelp_KMA
            // 
            this.buttonHelp_KMA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_KMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KMA.Image")));
            this.buttonHelp_KMA.Location = new System.Drawing.Point(720, 12);
            this.buttonHelp_KMA.Name = "buttonHelp_KMA";
            this.buttonHelp_KMA.Size = new System.Drawing.Size(68, 45);
            this.buttonHelp_KMA.TabIndex = 1;
            this.toolTip_KMA.SetToolTip(this.buttonHelp_KMA, "Сведение о программе");
            this.buttonHelp_KMA.UseVisualStyleBackColor = false;
            this.buttonHelp_KMA.Click += new System.EventHandler(this.buttonHelp_KMA_Click);
            // 
            // buttonOpenFile_KMA
            // 
            this.buttonOpenFile_KMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KMA.Image")));
            this.buttonOpenFile_KMA.Location = new System.Drawing.Point(82, 12);
            this.buttonOpenFile_KMA.Name = "buttonOpenFile_KMA";
            this.buttonOpenFile_KMA.Size = new System.Drawing.Size(68, 45);
            this.buttonOpenFile_KMA.TabIndex = 2;
            this.toolTip_KMA.SetToolTip(this.buttonOpenFile_KMA, "Производит поиск в файле.");
            this.buttonOpenFile_KMA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KMA.Click += new System.EventHandler(this.buttonOpenFile_KMA_Click);
            // 
            // textBoxTask_KMA
            // 
            this.textBoxTask_KMA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_KMA.Multiline = true;
            this.textBoxTask_KMA.Name = "textBoxTask_KMA";
            this.textBoxTask_KMA.ReadOnly = true;
            this.textBoxTask_KMA.Size = new System.Drawing.Size(768, 75);
            this.textBoxTask_KMA.TabIndex = 3;
            this.textBoxTask_KMA.Text = "Вывести слова в которых встречается g в результирующею строку и вывести ее в text" +
    "BoxOut.";
            // 
            // groupBoxInput_KMA
            // 
            this.groupBoxInput_KMA.Controls.Add(this.textBoxInPut_KMA);
            this.groupBoxInput_KMA.Location = new System.Drawing.Point(14, 170);
            this.groupBoxInput_KMA.Name = "groupBoxInput_KMA";
            this.groupBoxInput_KMA.Size = new System.Drawing.Size(372, 394);
            this.groupBoxInput_KMA.TabIndex = 3;
            this.groupBoxInput_KMA.TabStop = false;
            this.groupBoxInput_KMA.Text = "Ввод:";
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.textBoxOutPut_KMA);
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(392, 170);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(396, 394);
            this.groupBoxOutPut_KMA.TabIndex = 4;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод:";
            // 
            // textBoxInPut_KMA
            // 
            this.textBoxInPut_KMA.Location = new System.Drawing.Point(6, 61);
            this.textBoxInPut_KMA.Multiline = true;
            this.textBoxInPut_KMA.Name = "textBoxInPut_KMA";
            this.textBoxInPut_KMA.Size = new System.Drawing.Size(360, 327);
            this.textBoxInPut_KMA.TabIndex = 0;
            // 
            // textBoxOutPut_KMA
            // 
            this.textBoxOutPut_KMA.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutPut_KMA.Multiline = true;
            this.textBoxOutPut_KMA.Name = "textBoxOutPut_KMA";
            this.textBoxOutPut_KMA.ReadOnly = true;
            this.textBoxOutPut_KMA.Size = new System.Drawing.Size(384, 369);
            this.textBoxOutPut_KMA.TabIndex = 1;
            // 
            // openFileDialogTask_KMA
            // 
            this.openFileDialogTask_KMA.FileName = "openFileDialog1";
            // 
            // toolTip_KMA
            // 
            this.toolTip_KMA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_KMA.ToolTipTitle = "Подсказка";
            // 
            // FormMain_KMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.groupBoxOutPut_KMA);
            this.Controls.Add(this.groupBoxInput_KMA);
            this.Controls.Add(this.buttonOpenFile_KMA);
            this.Controls.Add(this.buttonHelp_KMA);
            this.Controls.Add(this.buttonDone_KMA);
            this.Controls.Add(this.groupBoxTask_KMA);
            this.Name = "FormMain_KMA";
            this.Text = "Спринт 6 | Таск 6 | Вариант 21 | Комаров М.А.";
            this.groupBoxTask_KMA.ResumeLayout(false);
            this.groupBoxTask_KMA.PerformLayout();
            this.groupBoxInput_KMA.ResumeLayout(false);
            this.groupBoxInput_KMA.PerformLayout();
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            this.groupBoxOutPut_KMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KMA;
        private System.Windows.Forms.TextBox textBoxTask_KMA;
        private System.Windows.Forms.Button buttonDone_KMA;
        private System.Windows.Forms.ToolTip toolTip_KMA;
        private System.Windows.Forms.Button buttonHelp_KMA;
        private System.Windows.Forms.Button buttonOpenFile_KMA;
        private System.Windows.Forms.GroupBox groupBoxInput_KMA;
        private System.Windows.Forms.TextBox textBoxInPut_KMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.TextBox textBoxOutPut_KMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KMA;
    }
}

