using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UTS_PRG2_20212_59
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BCLQG20\\ASIRA;Initial Catalog=CobaUTS;Integrated Security=True");
        
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {


                var st = (from s in db.ms_karyawans where s.id_karyawan == (tbID.Text) select s).First();
                tbNama.Text = st.nama_karyawan;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Tidak Ditemukan : ");
            }
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ms_golongan' table. You can move, or remove it, as needed.
            this.ms_golonganTableAdapter.Fill(this.dataSet1.ms_golongan);
            cbGolongan.Text = "-- Pilih Golongan --";
        }

        private void cbGolongan_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbGaji.Text = cbGolongan.SelectedValue.ToString();
        }

        int hitung;
        int hasil;

        private void rbIstimewa_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbIstimewa.Checked)
            {
                hitung = Convert.ToInt32(tbGaji.Text);

                hasil = hitung * 4;

                tbBonus.Text = hasil.ToString();
            }
        }

        private void rbBaik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBaik.Checked)
            {
                hitung = Convert.ToInt32(tbGaji.Text);

                hasil = hitung * 3;

                tbBonus.Text = hasil.ToString();
            }
        }

        private void rbCukup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCukup.Checked)
            {
                hitung = Convert.ToInt32(tbGaji.Text);

                hasil = hitung * 2;

                tbBonus.Text = hasil.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                hitung = Convert.ToInt32(tbGaji.Text);

                hasil = hitung * 1;

                tbBonus.Text = hasil.ToString();
            }
        }

        private void tbTagihan_TextChanged(object sender, EventArgs e)
        {
            int hitung1;
            int bonus;
            int tagihan;
            bonus = Convert.ToInt32(tbBonus.Text);
            tagihan = Convert.ToInt32(tbTagihan.Text);
            hitung1 = Convert.ToInt32(tbGaji.Text);
            hasil = hitung1 + bonus - tagihan;
            tbTake.Text = hasil.ToString();
        }

        public string idtrans()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            con.Open();

            SqlCommand cmd = new SqlCommand("select id_transaksi from tr_bonus_karyawan in(select max(id_transaksi) from tr_bonus_karyawan order by desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_transksasi"].ToString().Length - 3,3))+1;
                string kodeurutan = "000" + hitung;
                urutan = "TRS" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
            }
            else
            {
                urutan = "TRS01";
            }
            rd.Close();
            con.Close();
            return idtrans;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "sp_Transaksi";

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@id_transaksi", idtrans());
        }
    }
}
