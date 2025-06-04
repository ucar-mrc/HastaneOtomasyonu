using FinalKonusu2.Forms.Hastalar;
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

namespace FinalKonusu2.Forms
{
    public partial class frmHasta : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = hastaneDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");

        public frmHasta()
        {
            InitializeComponent();
            goster();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form frmAdd = new frmAdd(this);
            frmAdd.Show();
        }

        public void goster()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from hastas";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHastalar.DataSource = dt;
            conn.Close();

        }

        int selectedId;
        private void dgvHastalar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHastalar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHastalar.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value != null)
                {
                    selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHastalar.CurrentRow;

            if (row != null)
            {
                int hastaId = int.Parse(row.Cells["hastaId"].Value.ToString());
                String hastaAdi = row.Cells["hastaAdi"].Value.ToString();
                String hastasoyadi = row.Cells["hastaSoyadi"].Value.ToString();
                int hastaYasi = int.Parse(row.Cells["hastaYasi"].Value.ToString());
                String gittigiBolum = row.Cells["gittigiBolum"].Value.ToString();

                frmDelete frm = new frmDelete(this,hastaId, hastaAdi, hastasoyadi, hastaYasi, gittigiBolum);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goster();
                }
            }
            else
                MessageBox.Show("Lütfen silinecek hastayı seçin.");
        }

        

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHastalar.CurrentRow;

            if (row != null)
            {
                int hastaId = int.Parse(row.Cells["hastaId"].Value.ToString());
                String hastaAdi = row.Cells["hastaAdi"].Value.ToString();
                String hastasoyadi = row.Cells["hastaSoyadi"].Value.ToString();
                int hastaYasi = int.Parse(row.Cells["hastaYasi"].Value.ToString());
                String gittigiBolum = row.Cells["gittigiBolum"].Value.ToString();

                frmUpdate frm = new frmUpdate(this, hastaId, hastaAdi, hastasoyadi, hastaYasi, gittigiBolum);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goster(); // listeyi yenile
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek hastayı seçin.");
            }
        }
    }
}
