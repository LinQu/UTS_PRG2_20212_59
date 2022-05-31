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

namespace UTS_PRG2_20212_59
{
    public partial class UpdateKar : Form
    {
        public UpdateKar()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        string con = "Data Source=DESKTOP-BCLQG20\\ASIRA;Initial Catalog=UTS;Integrated Security=True";

        void ClearData()
        {
            tbID.Text = "";
            tbNama.Text = "";
            rbLaki.Checked = false;
            rbPuan.Checked = false;
            tbTelp.Text = "";
            tbEmail.Text = "";
            tbAlamat.Text = "";
        }
        private void UpdateKar_Load(object sender, EventArgs e)
        {
            tbNama.Enabled = false;
            rbLaki.Enabled = false;
            rbPuan.Enabled = false;
            tbEmail.Enabled = false;
            tbTelp.Enabled = false;
            tbAlamat.Enabled = false;
            btnHapus.Enabled = false;
            btnUpdate.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {

            
            var st = (from s in db.ms_karyawans where s.id_karyawan == (tbID.Text) select s).First();
            tbNama.Text = st.nama_karyawan;
            if (st.jenis_kelamin == "Laki-Laki")
            {
                rbLaki.Checked = true;
            }
            else
            {
                rbPuan.Checked = true;
            }
            tbEmail.Text = st.email;
            tbTelp.Text = st.no_telepon;
            tbAlamat.Text = st.alamat;
            tbNama.Enabled = true;
            rbLaki.Enabled = true;
            rbPuan.Enabled = true;
            tbEmail.Enabled = true;
            tbTelp.Enabled = true;
            tbAlamat.Enabled = true;
            btnHapus.Enabled = true;
            btnUpdate.Enabled = true;
            btnBatal.Enabled = true;
        
            }
            catch (Exception)
            {
                MessageBox.Show("Data Tidak Ditemukan : ");
            }
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearData();
            tbNama.Enabled = false;
            rbLaki.Enabled = false;
            rbPuan.Enabled = false;
            tbEmail.Enabled = false;
            tbTelp.Enabled = false;
            tbAlamat.Enabled = false;
            btnHapus.Enabled = false;
            btnUpdate.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string jeniskelamin = "";
            if (rbLaki.Checked)
            {
                jeniskelamin = rbLaki.Text;
            }
            if (rbPuan.Checked)
            {
                jeniskelamin = rbPuan.Text;
            }
            SqlConnection connection = new SqlConnection(con);

            SqlCommand insert = new SqlCommand("sp_UpdateKar", connection);
            insert.CommandType = CommandType.StoredProcedure;
            insert.Parameters.AddWithValue("id_karyawan", tbID.Text);
            insert.Parameters.AddWithValue("nama_karyawan", tbNama.Text);
            insert.Parameters.AddWithValue("jenis_kelamin", jeniskelamin);
            insert.Parameters.AddWithValue("email", tbEmail.Text);
            insert.Parameters.AddWithValue("no_telepon", tbTelp.Text);
            insert.Parameters.AddWithValue("alamat", tbAlamat.Text);
            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Di Update", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menhapus data?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var sc = (from s in db.ms_karyawans where s.id_karyawan == (tbID.Text) select s).First();
                db.ms_karyawans.DeleteOnSubmit(sc);
                db.SubmitChanges();
                MessageBox.Show("Data Succesfully Delete");
                ClearData();
            }
        }
    }
}
