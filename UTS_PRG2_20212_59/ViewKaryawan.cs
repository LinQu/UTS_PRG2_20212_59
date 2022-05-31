using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_PRG2_20212_59
{
    public partial class ViewKaryawan : Form
    {
        public ViewKaryawan()
        {
            InitializeComponent();
        }

        private void ViewKaryawan_Load(object sender, EventArgs e)
        {
            

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ms_karyawan' table. You can move, or remove it, as needed.
            this.ms_karyawanTableAdapter.Fill(this.dataSet1.ms_karyawan);
        }
    }
}
