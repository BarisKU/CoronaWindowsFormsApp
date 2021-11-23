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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            HosgeldinForm hosgeldinForm = new HosgeldinForm();
            hosgeldinForm.MdiParent = this;
            hosgeldinForm.Show();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardımForm yardımForm = new YardımForm();
            yardımForm.MdiParent = this;
            yardımForm.Show();
        }

        private void belirtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BelirtiForm form = new BelirtiForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void yüzdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YuzdeForm form = new YuzdeForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
