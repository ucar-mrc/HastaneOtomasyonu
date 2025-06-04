using FinalKonusu2.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalKonusu2.Forms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            hastaneDBContext db = new hastaneDBContext();
            
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            Form frmHasta = new frmHasta();
            this.Hide();
            frmHasta.Show();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            Form frmDoktor = new frmDoktor();
            this.Hide();
            frmDoktor.Show();
        }
    }
}
