using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class YuzdeForm : Form
    {
        public YuzdeForm()
        {
            InitializeComponent();
        }

    
        void Hesapla()
        {
            string sonuc;
            int yuzde = 0;
            if (cbAtes.Checked)
                yuzde += 70;
            if (cbOksuruk.Checked)
                yuzde += 20;
            if (cbBogaz.Checked)
                yuzde += 10;
      
            sonuc = "\r\n Sayın " + tbAdSoyad.Text + ", ";
            sonuc += " Korona olma yüzdeniz = % " + yuzde;
            lbSonuc.Items.Add(sonuc);
        }

        private void bTespit_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbAdSoyad.Clear();
            cbAtes.Checked = false;
            cbOksuruk.Checked = false;
            cbBogaz.Checked = false;
            lbSonuc.Items.Clear();
            rtbRapor.Text = "";
            rtbRapor.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbRapor.Text = "";
            foreach(var item in lbSonuc.Items)
            {
                 rtbRapor.Text+=item.ToString()+"\r\n";
            }
            rtbRapor.Visible = true;
        }
        
    }
}
