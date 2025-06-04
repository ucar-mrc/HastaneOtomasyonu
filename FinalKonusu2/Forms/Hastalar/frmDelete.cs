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
    public partial class frmDelete : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = hastaneDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");

        private frmHasta frmHastalar;
        int hasId;
        public frmDelete(frmHasta frm ,int hastaId,string hastaAdi,string hastaSoyadi,int hastaYasi,string gittigiBolum)
        {
            InitializeComponent();
            this.frmHastalar = frm;

            hasId = hastaId;
            Hastaadtxt.Text = hastaAdi;
            hastasoyadtxt.Text = hastaSoyadi;
            hastayastxt.Text = hastaYasi.ToString();
            txtbolum.Text = gittigiBolum;


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hasId.ToString());

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM hastas WHERE hastaId =@IDs";
            cmd.Parameters.AddWithValue("@IDs", hasId);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Hasta kaydı başarıyla silindi");

            frmHastalar.goster();
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {

        }
    }
}

