using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaApp
{
    public partial class YardımForm : Form
    {
        public YardımForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //webBrowser1.Navigate("https://saglik.gov.tr/");
            Process.Start("chrome.exe", "https://saglik.gov.tr/");
        }
    }
}
