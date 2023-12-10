
namespace Tyuiu.KomarovMA.Sprint6.Task6.V21
{
    partial class FormAbout_KMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KMA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxHelp_KMA = new System.Windows.Forms.TextBox();
            this.buttonOK_KMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxHelp_KMA
            // 
            this.textBoxHelp_KMA.Location = new System.Drawing.Point(191, 23);
            this.textBoxHelp_KMA.Multiline = true;
            this.textBoxHelp_KMA.Name = "textBoxHelp_KMA";
            this.textBoxHelp_KMA.ReadOnly = true;
            this.textBoxHelp_KMA.Size = new System.Drawing.Size(308, 192);
            this.textBoxHelp_KMA.TabIndex = 1;
            this.textBoxHelp_KMA.Text = "Разработчик: Комаров М.А.\r\nГруппа СМАРТб-23-1\r\nПрограмма разработана в рамках изу" +
    "чения языка C#\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа цифр" +
    "овых технологий (с) 2023";
            // 
            // buttonOK_KMA
            // 
            this.buttonOK_KMA.Location = new System.Drawing.Point(409, 231);
            this.buttonOK_KMA.Name = "buttonOK_KMA";
            this.buttonOK_KMA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KMA.TabIndex = 2;
            this.buttonOK_KMA.Text = "Ок";
            this.buttonOK_KMA.UseVisualStyleBackColor = true;
            this.buttonOK_KMA.Click += new System.EventHandler(this.buttonOK_KMA_Click);
            // 
            // FormAbout_KMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 266);
            this.Controls.Add(this.buttonOK_KMA);
            this.Controls.Add(this.textBoxHelp_KMA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAbout_KMA";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxHelp_KMA;
        private System.Windows.Forms.Button buttonOK_KMA;
    }
}