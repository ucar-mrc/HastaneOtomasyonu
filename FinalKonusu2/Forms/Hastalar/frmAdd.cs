using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalKonusu2.Forms.Hastalar
{
    public partial class frmAdd : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = hastaneDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");

        private frmHasta frmHastalar;

        public frmAdd(frmHasta frm) //hastaları anımsattık 
        {
            InitializeComponent();
            this.frmHastalar = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText="insert into hastas values ('"+Hastaadtxt.Text+"','" +hastasoyadtxt.Text+ "','" + hastayastxt.Text+ "','"+cmbBolum.SelectedItem.ToString()+ "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci kaydı başarılı şekilde eklendi");

            frmHastalar.goster();
            this.Hide();
           
            
        }
    }
}
