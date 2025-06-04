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
    public partial class frmUpdate : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = hastaneDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");
        private frmHasta anaForm;
        private int hastaId;

        public frmUpdate(frmHasta form, int id, string ad, string soyad, int yas, string bolum)
        {
            InitializeComponent();
            anaForm = form;
            hastaId = id;

            // Gelen değerleri form kontrollerine yerleştir
            Hastaadtxt.Text = ad;
            hastasoyadtxt.Text = soyad;
            hastayastxt.Text = yas.ToString();
            cmbBolum.Text = bolum;
        }

       

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE hastas SET hastaAdi=@ad, hastaSoyadi=@soyad, hastaYasi=@yas, gittigiBolum=@bolum WHERE hastaId=@id";
                SqlCommand guncelle = new SqlCommand(query, conn);
                guncelle.Parameters.AddWithValue("@id", hastaId);
                guncelle.Parameters.AddWithValue("@ad", Hastaadtxt.Text);
                guncelle.Parameters.AddWithValue("@soyad", hastasoyadtxt.Text);
                guncelle.Parameters.AddWithValue("@yas", int.Parse(hastayastxt.Text));
                guncelle.Parameters.AddWithValue("@bolum", cmbBolum.Text);
                guncelle.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Hasta güncellendi.");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
