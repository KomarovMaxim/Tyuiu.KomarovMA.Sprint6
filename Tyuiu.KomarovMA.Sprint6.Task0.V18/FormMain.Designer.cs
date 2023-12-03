
namespace Tyuiu.KomarovMA.Sprint6.Task0.V18
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KMA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_KMA = new System.Windows.Forms.GroupBox();
            this.labelInputData_KMA = new System.Windows.Forms.Label();
            this.textBoxVarX_KMA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KMA = new System.Windows.Forms.TextBox();
            this.labelOutPutData_KMA = new System.Windows.Forms.Label();
            this.buttonPushMe_KMA = new System.Windows.Forms.Button();
            this.buttonHelp_KMA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInputData_KMA.SuspendLayout();
            this.groupBoxOutPutData_KMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTask_KMA);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_KMA
            // 
            this.textBoxTask_KMA.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_KMA.Multiline = true;
            this.textBoxTask_KMA.Name = "textBoxTask_KMA";
            this.textBoxTask_KMA.ReadOnly = true;
            this.textBoxTask_KMA.Size = new System.Drawing.Size(750, 232);
            this.textBoxTask_KMA.TabIndex = 0;
            this.textBoxTask_KMA.Text = "Вычислить значение по формуле";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInputData_KMA
            // 
            this.groupBoxInputData_KMA.Controls.Add(this.labelInputData_KMA);
            this.groupBoxInputData_KMA.Controls.Add(this.textBoxVarX_KMA);
            this.groupBoxInputData_KMA.Location = new System.Drawing.Point(33, 313);
            this.groupBoxInputData_KMA.Name = "groupBoxInputData_KMA";
            this.groupBoxInputData_KMA.Size = new System.Drawing.Size(129, 100);
            this.groupBoxInputData_KMA.TabIndex = 2;
            this.groupBoxInputData_KMA.TabStop = false;
            this.groupBoxInputData_KMA.Text = "Ввод данных";
            // 
            // labelInputData_KMA
            // 
            this.labelInputData_KMA.AutoSize = true;
            this.labelInputData_KMA.Location = new System.Drawing.Point(6, 35);
            this.labelInputData_KMA.Name = "labelInputData_KMA";
            this.labelInputData_KMA.Size = new System.Drawing.Size(84, 13);
            this.labelInputData_KMA.TabIndex = 1;
            this.labelInputData_KMA.Text = "Переменная X:";
            this.labelInputData_KMA.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxVarX_KMA
            // 
            this.textBoxVarX_KMA.Location = new System.Drawing.Point(9, 61);
            this.textBoxVarX_KMA.Name = "textBoxVarX_KMA";
            this.textBoxVarX_KMA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_KMA.TabIndex = 0;
            this.textBoxVarX_KMA.TextChanged += new System.EventHandler(this.textBoxVarX_KMA_TextChanged);
            // 
            // groupBoxOutPutData_KMA
            // 
            this.groupBoxOutPutData_KMA.Controls.Add(this.textBoxResult_KMA);
            this.groupBoxOutPutData_KMA.Controls.Add(this.labelOutPutData_KMA);
            this.groupBoxOutPutData_KMA.Location = new System.Drawing.Point(248, 313);
            this.groupBoxOutPutData_KMA.Name = "groupBoxOutPutData_KMA";
            this.groupBoxOutPutData_KMA.Size = new System.Drawing.Size(154, 100);
            this.groupBoxOutPutData_KMA.TabIndex = 2;
            this.groupBoxOutPutData_KMA.TabStop = false;
            this.groupBoxOutPutData_KMA.Text = "Вывод данных";
            // 
            // textBoxResult_KMA
            // 
            this.textBoxResult_KMA.Location = new System.Drawing.Point(9, 61);
            this.textBoxResult_KMA.Name = "textBoxResult_KMA";
            this.textBoxResult_KMA.ReadOnly = true;
            this.textBoxResult_KMA.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_KMA.TabIndex = 4;
            // 
            // labelOutPutData_KMA
            // 
            this.labelOutPutData_KMA.AutoSize = true;
            this.labelOutPutData_KMA.Location = new System.Drawing.Point(6, 35);
            this.labelOutPutData_KMA.Name = "labelOutPutData_KMA";
            this.labelOutPutData_KMA.Size = new System.Drawing.Size(59, 13);
            this.labelOutPutData_KMA.TabIndex = 3;
            this.labelOutPutData_KMA.Text = "Результат";
            // 
            // buttonPushMe_KMA
            // 
            this.buttonPushMe_KMA.Location = new System.Drawing.Point(588, 343);
            this.buttonPushMe_KMA.Name = "buttonPushMe_KMA";
            this.buttonPushMe_KMA.Size = new System.Drawing.Size(104, 51);
            this.buttonPushMe_KMA.TabIndex = 3;
            this.buttonPushMe_KMA.Text = "Выполнить";
            this.buttonPushMe_KMA.UseVisualStyleBackColor = true;
            this.buttonPushMe_KMA.Click += new System.EventHandler(this.buttonPushMe_KMA_Click);
            // 
            // buttonHelp_KMA
            // 
            this.buttonHelp_KMA.Location = new System.Drawing.Point(528, 349);
            this.buttonHelp_KMA.Name = "buttonHelp_KMA";
            this.buttonHelp_KMA.Size = new System.Drawing.Size(36, 39);
            this.buttonHelp_KMA.TabIndex = 2;
            this.buttonHelp_KMA.Text = "?";
            this.buttonHelp_KMA.UseVisualStyleBackColor = true;
            this.buttonHelp_KMA.Click += new System.EventHandler(this.buttonHelp_KMA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.buttonHelp_KMA);
            this.Controls.Add(this.buttonPushMe_KMA);
            this.Controls.Add(this.groupBoxOutPutData_KMA);
            this.Controls.Add(this.groupBoxInputData_KMA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 18 | Комаров М.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInputData_KMA.ResumeLayout(false);
            this.groupBoxInputData_KMA.PerformLayout();
            this.groupBoxOutPutData_KMA.ResumeLayout(false);
            this.groupBoxOutPutData_KMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTask_KMA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInputData_KMA;
        private System.Windows.Forms.Label labelInputData_KMA;
        private System.Windows.Forms.TextBox textBoxVarX_KMA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KMA;
        private System.Windows.Forms.TextBox textBoxResult_KMA;
        private System.Windows.Forms.Label labelOutPutData_KMA;
        private System.Windows.Forms.Button buttonPushMe_KMA;
        private System.Windows.Forms.Button buttonHelp_KMA;
    }
}

