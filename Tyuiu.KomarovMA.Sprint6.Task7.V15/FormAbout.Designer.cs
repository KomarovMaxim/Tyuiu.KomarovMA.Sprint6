
namespace Tyuiu.KomarovMA.Sprint6.Task7.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxHelp_KMA = new System.Windows.Forms.TextBox();
            this.pictureBoxFace_KMA = new System.Windows.Forms.PictureBox();
            this.buttonOK_KMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace_KMA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHelp_KMA
            // 
            this.textBoxHelp_KMA.Location = new System.Drawing.Point(213, 6);
            this.textBoxHelp_KMA.Multiline = true;
            this.textBoxHelp_KMA.Name = "textBoxHelp_KMA";
            this.textBoxHelp_KMA.ReadOnly = true;
            this.textBoxHelp_KMA.Size = new System.Drawing.Size(308, 192);
            this.textBoxHelp_KMA.TabIndex = 2;
            this.textBoxHelp_KMA.Text = "Разработчик: Комаров М.А.\r\nГруппа СМАРТб-23-1\r\nПрограмма разработана в рамках изу" +
    "чения языка C#\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа цифр" +
    "овых технологий (с) 2023";
            // 
            // pictureBoxFace_KMA
            // 
            this.pictureBoxFace_KMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFace_KMA.Image")));
            this.pictureBoxFace_KMA.Location = new System.Drawing.Point(34, 6);
            this.pictureBoxFace_KMA.Name = "pictureBoxFace_KMA";
            this.pictureBoxFace_KMA.Size = new System.Drawing.Size(173, 192);
            this.pictureBoxFace_KMA.TabIndex = 3;
            this.pictureBoxFace_KMA.TabStop = false;
            // 
            // buttonOK_KMA
            // 
            this.buttonOK_KMA.Location = new System.Drawing.Point(446, 223);
            this.buttonOK_KMA.Name = "buttonOK_KMA";
            this.buttonOK_KMA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KMA.TabIndex = 4;
            this.buttonOK_KMA.Text = "Ок";
            this.buttonOK_KMA.UseVisualStyleBackColor = true;
            this.buttonOK_KMA.Click += new System.EventHandler(this.buttonOK_KMA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 251);
            this.Controls.Add(this.buttonOK_KMA);
            this.Controls.Add(this.pictureBoxFace_KMA);
            this.Controls.Add(this.textBoxHelp_KMA);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace_KMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHelp_KMA;
        private System.Windows.Forms.PictureBox pictureBoxFace_KMA;
        private System.Windows.Forms.Button buttonOK_KMA;
    }
}