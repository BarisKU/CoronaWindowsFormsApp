
namespace CoronaApp
{
    partial class BelirtiForm
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
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbBogaz = new System.Windows.Forms.CheckBox();
            this.bTespit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.rdKadın = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlSehir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.SuspendLayout();
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
            // bTespit
            // 
            this.bTespit.Location = new System.Drawing.Point(4, 377);
            this.bTespit.Name = "bTespit";
            this.bTespit.Size = new System.Drawing.Size(126, 23);
            this.bTespit.TabIndex = 2;
            this.bTespit.Text = "Tespit et";
            this.bTespit.UseVisualStyleBackColor = true;
            this.bTespit.Click += new System.EventHandler(this.bTespit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBogaz);
            this.groupBox1.Controls.Add(this.cbAtes);
            this.groupBox1.Controls.Add(this.cbOksuruk);
            this.groupBox1.Location = new System.Drawing.Point(501, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belirtiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDogumTarihi);
            this.groupBox2.Controls.Add(this.rdErkek);
            this.groupBox2.Controls.Add(this.rdKadın);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudYas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ddlSehir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbAdSoyad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GenelBilgiler";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(84, 144);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 11;
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Checked = true;
            this.rdErkek.Location = new System.Drawing.Point(190, 117);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(56, 17);
            this.rdErkek.TabIndex = 10;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek:";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // rdKadın
            // 
            this.rdKadın.AutoSize = true;
            this.rdKadın.Location = new System.Drawing.Point(84, 117);
            this.rdKadın.Name = "rdKadın";
            this.rdKadın.Size = new System.Drawing.Size(55, 17);
            this.rdKadın.TabIndex = 9;
            this.rdKadın.Text = "Kadın:";
            this.rdKadın.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(85, 82);
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(209, 20);
            this.nudYas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yaş:";
            // 
            // ddlSehir
            // 
            this.ddlSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSehir.FormattingEnabled = true;
            this.ddlSehir.Location = new System.Drawing.Point(84, 47);
            this.ddlSehir.Name = "ddlSehir";
            this.ddlSehir.Size = new System.Drawing.Size(211, 21);
            this.ddlSehir.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şehir:";
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(84, 17);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(214, 20);
            this.tbAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(4, 250);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.ReadOnly = true;
            this.tbSonuc.Size = new System.Drawing.Size(794, 108);
            this.tbSonuc.TabIndex = 5;
    
            // 
            // BelirtiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.bTespit);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.groupBox2);
            this.Name = "BelirtiForm";
            this.Text = "Belirti Tespit";
            this.Load += new System.EventHandler(this.BelirtiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbBogaz;
        private System.Windows.Forms.Button bTespit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.RadioButton rdKadın;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
    }
}