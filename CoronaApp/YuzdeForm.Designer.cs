
namespace CoronaApp
{
    partial class YuzdeForm
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
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.bTespit = new System.Windows.Forms.Button();
            this.cbBogaz = new System.Windows.Forms.CheckBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.rtbRapor = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(89, 30);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(240, 20);
            this.tbAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bTemizle);
            this.groupBox1.Controls.Add(this.bTespit);
            this.groupBox1.Controls.Add(this.cbBogaz);
            this.groupBox1.Controls.Add(this.cbAtes);
            this.groupBox1.Controls.Add(this.cbOksuruk);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belirtiler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 90);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rapor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(323, 9);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(126, 90);
            this.bTemizle.TabIndex = 6;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // bTespit
            // 
            this.bTespit.Location = new System.Drawing.Point(191, 9);
            this.bTespit.Name = "bTespit";
            this.bTespit.Size = new System.Drawing.Size(126, 90);
            this.bTespit.TabIndex = 5;
            this.bTespit.Text = "Tespit et";
            this.bTespit.UseVisualStyleBackColor = true;
            this.bTespit.Click += new System.EventHandler(this.bTespit_Click);
            // 
            // cbBogaz
            // 
            this.cbBogaz.AutoSize = true;
            this.cbBogaz.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogaz.Location = new System.Drawing.Point(50, 59);
            this.cbBogaz.Name = "cbBogaz";
            this.cbBogaz.Size = new System.Drawing.Size(127, 17);
            this.cbBogaz.TabIndex = 1;
            this.cbBogaz.Text = "Boğaz Ağrısı var mı=?";
            this.cbBogaz.UseVisualStyleBackColor = true;
            // 
            // cbAtes
            // 
            this.cbAtes.AutoSize = true;
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Location = new System.Drawing.Point(50, 13);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(90, 17);
            this.cbAtes.TabIndex = 0;
            this.cbAtes.Text = "Ateş var mı=?";
            this.cbAtes.UseVisualStyleBackColor = true;
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.AutoSize = true;
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Location = new System.Drawing.Point(50, 36);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(109, 17);
            this.cbOksuruk.TabIndex = 1;
            this.cbOksuruk.Text = "Öksürük var mı=?";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(16, 175);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(771, 82);
            this.lbSonuc.TabIndex = 5;
            // 
            // rtbRapor
            // 
            this.rtbRapor.Location = new System.Drawing.Point(16, 263);
            this.rtbRapor.Name = "rtbRapor";
            this.rtbRapor.ReadOnly = true;
            this.rtbRapor.Size = new System.Drawing.Size(771, 96);
            this.rtbRapor.TabIndex = 6;
            this.rtbRapor.Text = "";
            this.rtbRapor.Visible = false;
            // 
            // YuzdeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbRapor);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdSoyad);
            this.Name = "YuzdeForm";
            this.Text = "YuzdeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBogaz;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.Button bTespit;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbRapor;
    }
}