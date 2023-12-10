
namespace Tyuiu.KomarovMA.Sprint6.Task7.V15
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
            this.panelBottoms = new System.Windows.Forms.Panel();
            this.buttonDone_KMA = new System.Windows.Forms.Button();
            this.buttonOpen_KMA = new System.Windows.Forms.Button();
            this.buttonSave_KMA = new System.Windows.Forms.Button();
            this.buttonHelp_KMA = new System.Windows.Forms.Button();
            this.panelBetweenButtons_KMA = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTask_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KMA = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInPut_KMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_KMA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPut_KMA = new System.Windows.Forms.DataGridView();
            this.saveFileDialogMatrix_KMA = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTask_KMA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_KMA = new System.Windows.Forms.ToolTip(this.components);
            this.panelBottoms.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxTask_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInPut_KMA.SuspendLayout();
            this.groupBoxOutPut_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottoms
            // 
            this.panelBottoms.Controls.Add(this.panelBetweenButtons_KMA);
            this.panelBottoms.Controls.Add(this.buttonHelp_KMA);
            this.panelBottoms.Controls.Add(this.buttonSave_KMA);
            this.panelBottoms.Controls.Add(this.buttonOpen_KMA);
            this.panelBottoms.Controls.Add(this.buttonDone_KMA);
            this.panelBottoms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottoms.Location = new System.Drawing.Point(0, 0);
            this.panelBottoms.Name = "panelBottoms";
            this.panelBottoms.Size = new System.Drawing.Size(833, 87);
            this.panelBottoms.TabIndex = 0;
            // 
            // buttonDone_KMA
            // 
            this.buttonDone_KMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDone_KMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KMA.Image")));
            this.buttonDone_KMA.Location = new System.Drawing.Point(0, 0);
            this.buttonDone_KMA.Name = "buttonDone_KMA";
            this.buttonDone_KMA.Size = new System.Drawing.Size(102, 87);
            this.buttonDone_KMA.TabIndex = 0;
            this.toolTipButton_KMA.SetToolTip(this.buttonDone_KMA, "Открыть файл. \r\nВыберите нужный файл для обработки.");
            this.buttonDone_KMA.UseVisualStyleBackColor = true;
            this.buttonDone_KMA.Click += new System.EventHandler(this.buttonDone_KMA_Click);
            // 
            // buttonOpen_KMA
            // 
            this.buttonOpen_KMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOpen_KMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_KMA.Image")));
            this.buttonOpen_KMA.Location = new System.Drawing.Point(102, 0);
            this.buttonOpen_KMA.Name = "buttonOpen_KMA";
            this.buttonOpen_KMA.Size = new System.Drawing.Size(102, 87);
            this.buttonOpen_KMA.TabIndex = 1;
            this.toolTipButton_KMA.SetToolTip(this.buttonOpen_KMA, "Производит поиск файла.\r\n");
            this.buttonOpen_KMA.UseVisualStyleBackColor = true;
            this.buttonOpen_KMA.Click += new System.EventHandler(this.buttonOpen_KMA_Click);
            // 
            // buttonSave_KMA
            // 
            this.buttonSave_KMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave_KMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_KMA.Image")));
            this.buttonSave_KMA.Location = new System.Drawing.Point(204, 0);
            this.buttonSave_KMA.Name = "buttonSave_KMA";
            this.buttonSave_KMA.Size = new System.Drawing.Size(102, 87);
            this.buttonSave_KMA.TabIndex = 2;
            this.toolTipButton_KMA.SetToolTip(this.buttonSave_KMA, "Сохранить.");
            this.buttonSave_KMA.UseVisualStyleBackColor = true;
            this.buttonSave_KMA.Click += new System.EventHandler(this.buttonSave_KMA_Click);
            // 
            // buttonHelp_KMA
            // 
            this.buttonHelp_KMA.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_KMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KMA.Image")));
            this.buttonHelp_KMA.Location = new System.Drawing.Point(731, 0);
            this.buttonHelp_KMA.Name = "buttonHelp_KMA";
            this.buttonHelp_KMA.Size = new System.Drawing.Size(102, 87);
            this.buttonHelp_KMA.TabIndex = 3;
            this.toolTipButton_KMA.SetToolTip(this.buttonHelp_KMA, "Помощь");
            this.buttonHelp_KMA.UseVisualStyleBackColor = true;
            this.buttonHelp_KMA.Click += new System.EventHandler(this.buttonHelp_KMA_Click);
            // 
            // panelBetweenButtons_KMA
            // 
            this.panelBetweenButtons_KMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBetweenButtons_KMA.Location = new System.Drawing.Point(306, 0);
            this.panelBetweenButtons_KMA.Name = "panelBetweenButtons_KMA";
            this.panelBetweenButtons_KMA.Size = new System.Drawing.Size(425, 87);
            this.panelBetweenButtons_KMA.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTask_KMA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 100);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxTask_KMA
            // 
            this.groupBoxTask_KMA.Controls.Add(this.textBoxTask_KMA);
            this.groupBoxTask_KMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_KMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            this.groupBoxTask_KMA.Size = new System.Drawing.Size(833, 100);
            this.groupBoxTask_KMA.TabIndex = 0;
            this.groupBoxTask_KMA.TabStop = false;
            this.groupBoxTask_KMA.Text = "Условие";
            // 
            // textBoxTask_KMA
            // 
            this.textBoxTask_KMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_KMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_KMA.Multiline = true;
            this.textBoxTask_KMA.Name = "textBoxTask_KMA";
            this.textBoxTask_KMA.ReadOnly = true;
            this.textBoxTask_KMA.Size = new System.Drawing.Size(827, 81);
            this.textBoxTask_KMA.TabIndex = 0;
            this.textBoxTask_KMA.Text = resources.GetString("textBoxTask_KMA.Text");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 187);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInPut_KMA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutPut_KMA);
            this.splitContainer1.Size = new System.Drawing.Size(833, 332);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBoxInPut_KMA
            // 
            this.groupBoxInPut_KMA.Controls.Add(this.dataGridViewInPut_KMA);
            this.groupBoxInPut_KMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_KMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_KMA.Name = "groupBoxInPut_KMA";
            this.groupBoxInPut_KMA.Size = new System.Drawing.Size(277, 332);
            this.groupBoxInPut_KMA.TabIndex = 0;
            this.groupBoxInPut_KMA.TabStop = false;
            this.groupBoxInPut_KMA.Text = "Ввод";
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.dataGridViewOutPut_KMA);
            this.groupBoxOutPut_KMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(552, 332);
            this.groupBoxOutPut_KMA.TabIndex = 0;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод";
            // 
            // dataGridViewInPut_KMA
            // 
            this.dataGridViewInPut_KMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_KMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_KMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_KMA.Name = "dataGridViewInPut_KMA";
            this.dataGridViewInPut_KMA.Size = new System.Drawing.Size(271, 313);
            this.dataGridViewInPut_KMA.TabIndex = 0;
            // 
            // dataGridViewOutPut_KMA
            // 
            this.dataGridViewOutPut_KMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_KMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_KMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_KMA.Name = "dataGridViewOutPut_KMA";
            this.dataGridViewOutPut_KMA.Size = new System.Drawing.Size(546, 313);
            this.dataGridViewOutPut_KMA.TabIndex = 0;
            // 
            // openFileDialogTask_KMA
            // 
            this.openFileDialogTask_KMA.FileName = "openFileDialog1";
            // 
            // toolTipButton_KMA
            // 
            this.toolTipButton_KMA.IsBalloon = true;
            this.toolTipButton_KMA.ToolTipTitle = "Подсказка";
            // 
            // FormMain_KMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottoms);
            this.Name = "FormMain_KMA";
            this.Text = "Спринт 6 | Таск 7 | Вариант 15 | Комаров М.А.";
            this.Load += new System.EventHandler(this.FormMain_KMA_Load);
            this.panelBottoms.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxTask_KMA.ResumeLayout(false);
            this.groupBoxTask_KMA.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInPut_KMA.ResumeLayout(false);
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottoms;
        private System.Windows.Forms.Panel panelBetweenButtons_KMA;
        private System.Windows.Forms.Button buttonHelp_KMA;
        private System.Windows.Forms.Button buttonSave_KMA;
        private System.Windows.Forms.Button buttonOpen_KMA;
        private System.Windows.Forms.Button buttonDone_KMA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTask_KMA;
        private System.Windows.Forms.TextBox textBoxTask_KMA;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInPut_KMA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_KMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_KMA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KMA;
        private System.Windows.Forms.ToolTip toolTipButton_KMA;
    }
}

