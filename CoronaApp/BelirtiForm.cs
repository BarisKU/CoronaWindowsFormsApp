using CoronaApp.Models;
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
    public partial class BelirtiForm : Form
    {
        public BelirtiForm()
        {
            InitializeComponent();
        }


        private void bTespit_Click(object sender, EventArgs e)
        {
            //tbSonuc.Text = tbAdSoyad.Text;

            if (dtpDogumTarihi.Value > DateTime.Today)
            {
                tbSonuc.Text = "Doğum tarihi bugünün tarihinden büyük olamaz";
            }
            else
            {
                Kisi kisi = new Kisi()
                {
                    AdSoyad = tbAdSoyad.Text.Trim(),
                    Id = 1,
                    Yas = Convert.ToByte(nudYas.Value),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = rdKadın.Checked ? Cinsiyet.Kadın : Cinsiyet.Erkek,
                    SehirId = (ddlSehir.SelectedItem as Sehir).Value
                    //SehirId = Convert.ToInt32(ddlSehir.SelectedValue)


                };

                bool koronaMi = false;
                if (cbAtes.Checked)
                    koronaMi = true;
                else if (cbBogaz.Checked && cbOksuruk.Checked)
                    koronaMi = true;

                tbSonuc.Text = "Hoşgeldiniz..";
                tbSonuc.Text += " Ad Soyad: " + kisi.AdSoyad;
                tbSonuc.Text += "\r\n Sehir: " + kisi.SehirId;
                tbSonuc.Text += "\r\n Yas: " + kisi.Yas;
                tbSonuc.Text += "\r\n Doğum Tarihi: " + kisi.DogumTarihi.ToLongDateString();
                tbSonuc.Text += "\r\n Cinsiyet: " + kisi.Cinsiyet;
                if (koronaMi)
                    tbSonuc.Text += "\r\n Korona olabilirsiniz.";
                else
                    tbSonuc.Text += "\r\n Korona Değilsiniz.";
            }
        }

        private void BelirtiForm_Load(object sender, EventArgs e)
        {
            ddlSehir.Items.Add(new Sehir()
            {
                Value = 06,
                Text = "Ankara"
            });//text ve value olmalı text yazıyı gösterir value ise değerini
            ddlSehir.Items.Add(new Sehir()
            {
                Value = 34,
                Text = "İstanbul"
            });
            ddlSehir.Items.Add(new Sehir()
            {
                Value = 35,
                Text = "İzmir"
            });
            ddlSehir.ValueMember = "Value";
            ddlSehir.DisplayMember = "Text";
        }

    }
}
