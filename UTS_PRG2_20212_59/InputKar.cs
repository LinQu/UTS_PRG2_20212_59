using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UTS_PRG2_20212_59
{
    public partial class InputKar : Form
    {
        public InputKar()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-BCLQG20\\ASIRA;Initial Catalog=UTS;Integrated Security=True";

        private static Regex email_validation()
        {
            string pattern = @"^[a-zA-Z0-9\w.]+[@]+[a-zA-Z0-9\w]+[.]+[a-zA-Z0-9\w]*$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex validate_emailaddress = email_validation();

        private void InputKar_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDB(string cmd)
        {
            //exception handler
            try
            {
                //connection string digunakan untuk koneksi ke basisdata P5_06.
                //perhatikan data source berisi "." menunjukkan komputer localhost,
                //pada kenyataannya Anda akan menggantinya dengan alamat IP komputer server basisdata.

                //membuat object dengan nama myConnection, inisialisasi dengan connecting string
                SqlConnection myConnection = new SqlConnection(con);

                //membuat koneksi, menggunakan object myConnection
                myConnection.Open();

                //membuat object dengan nama myCommand, inisialisasi dari class SqlCommand
                SqlCommand myCommand = new SqlCommand();

                //menetapkan koneksi basisdata yang digunakan, yaitu object myConnection
                myCommand.Connection = myConnection;

                //mengatur query yang digunakan, diambil dari parameter cmd
                myCommand.CommandText = cmd;

                //eksekusi mycommand yang diambil dari parameter cmd
                myCommand.ExecuteNonQuery();

                //menampilkan pesan jika eksekusi berhasil
                MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //penanganan apabila terjadi error pada saat try, exception diset dalam variabel ex
            catch (Exception ex)
            {
                //menampilkan pesan kesalahan
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(tbID.Text == "" || tbNama.Text == "" || tbTelp.Text == "" || tbEmail.Text == "" || tbAlamat.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
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

                string myCmd = "INSERT INTO ms_karyawan Values('"
                + tbID.Text + "','"
                + tbNama.Text + "','"
                + jeniskelamin + "','"
                + tbEmail.Text + "','"
                + tbTelp.Text + "','"
                + tbAlamat.Text + "')";
                    UpdateDB(myCmd);
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to insert: " + ex.Message);
                }

            }
        }

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

        private void tbTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(tbEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbEmail.Focus();
                return;
            }
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
