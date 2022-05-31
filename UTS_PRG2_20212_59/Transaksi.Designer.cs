
namespace UTS_PRG2_20212_59
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.rbBaik = new System.Windows.Forms.RadioButton();
            this.rbIstimewa = new System.Windows.Forms.RadioButton();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbTake = new System.Windows.Forms.TextBox();
            this.tbTagihan = new System.Windows.Forms.TextBox();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGolongan = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbCukup = new System.Windows.Forms.RadioButton();
            this.tbGaji = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataSet1 = new UTS_PRG2_20212_59.DataSet1();
            this.msgolonganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ms_golonganTableAdapter = new UTS_PRG2_20212_59.DataSet1TableAdapters.ms_golonganTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgolonganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaksi Bonus Karyawan";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(288, 71);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 50;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // rbBaik
            // 
            this.rbBaik.AutoSize = true;
            this.rbBaik.Location = new System.Drawing.Point(277, 212);
            this.rbBaik.Name = "rbBaik";
            this.rbBaik.Size = new System.Drawing.Size(46, 17);
            this.rbBaik.TabIndex = 48;
            this.rbBaik.TabStop = true;
            this.rbBaik.Text = "Baik";
            this.rbBaik.UseVisualStyleBackColor = true;
            this.rbBaik.CheckedChanged += new System.EventHandler(this.rbBaik_CheckedChanged);
            // 
            // rbIstimewa
            // 
            this.rbIstimewa.AutoSize = true;
            this.rbIstimewa.Location = new System.Drawing.Point(165, 212);
            this.rbIstimewa.Name = "rbIstimewa";
            this.rbIstimewa.Size = new System.Drawing.Size(66, 17);
            this.rbIstimewa.TabIndex = 47;
            this.rbIstimewa.TabStop = true;
            this.rbIstimewa.Text = "Istimewa";
            this.rbIstimewa.UseVisualStyleBackColor = true;
            this.rbIstimewa.CheckedChanged += new System.EventHandler(this.rbIstimewa_CheckedChanged);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(288, 379);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 46;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(103, 379);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 45;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbTake
            // 
            this.tbTake.Enabled = false;
            this.tbTake.Location = new System.Drawing.Point(184, 320);
            this.tbTake.Name = "tbTake";
            this.tbTake.Size = new System.Drawing.Size(177, 20);
            this.tbTake.TabIndex = 44;
            // 
            // tbTagihan
            // 
            this.tbTagihan.Location = new System.Drawing.Point(184, 290);
            this.tbTagihan.MaxLength = 13;
            this.tbTagihan.Name = "tbTagihan";
            this.tbTagihan.Size = new System.Drawing.Size(177, 20);
            this.tbTagihan.TabIndex = 43;
            this.tbTagihan.TextChanged += new System.EventHandler(this.tbTagihan_TextChanged);
            // 
            // tbBonus
            // 
            this.tbBonus.Enabled = false;
            this.tbBonus.Location = new System.Drawing.Point(184, 260);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(177, 20);
            this.tbBonus.TabIndex = 42;
            // 
            // tbNama
            // 
            this.tbNama.Enabled = false;
            this.tbNama.Location = new System.Drawing.Point(166, 101);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(197, 20);
            this.tbNama.TabIndex = 41;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(166, 71);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(116, 20);
            this.tbID.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "TAKE HOME PAY   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Sisa Tagihan           :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Jumlah Bonus          :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nilai Akhir Tahun     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nama Karyawan      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Karyawan            :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Golongan                 :";
            // 
            // cbGolongan
            // 
            this.cbGolongan.DataSource = this.msgolonganBindingSource;
            this.cbGolongan.DisplayMember = "nama_golongan";
            this.cbGolongan.FormattingEnabled = true;
            this.cbGolongan.Location = new System.Drawing.Point(166, 139);
            this.cbGolongan.Name = "cbGolongan";
            this.cbGolongan.Size = new System.Drawing.Size(197, 21);
            this.cbGolongan.TabIndex = 52;
            this.cbGolongan.ValueMember = "gaji_pokok";
            this.cbGolongan.SelectedIndexChanged += new System.EventHandler(this.cbGolongan_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(277, 237);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kurang";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCukup
            // 
            this.rbCukup.AutoSize = true;
            this.rbCukup.Location = new System.Drawing.Point(165, 237);
            this.rbCukup.Name = "rbCukup";
            this.rbCukup.Size = new System.Drawing.Size(56, 17);
            this.rbCukup.TabIndex = 53;
            this.rbCukup.TabStop = true;
            this.rbCukup.Text = "Cukup";
            this.rbCukup.UseVisualStyleBackColor = true;
            this.rbCukup.CheckedChanged += new System.EventHandler(this.rbCukup_CheckedChanged);
            // 
            // tbGaji
            // 
            this.tbGaji.Enabled = false;
            this.tbGaji.Location = new System.Drawing.Point(186, 171);
            this.tbGaji.Name = "tbGaji";
            this.tbGaji.Size = new System.Drawing.Size(172, 20);
            this.tbGaji.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Gaji Pokok               :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Rp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Rp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Rp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Rp";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // msgolonganBindingSource
            // 
            this.msgolonganBindingSource.DataMember = "ms_golongan";
            this.msgolonganBindingSource.DataSource = this.dataSet1;
            // 
            // ms_golonganTableAdapter
            // 
            this.ms_golonganTableAdapter.ClearBeforeFill = true;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 458);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbGaji);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbCukup);
            this.Controls.Add(this.cbGolongan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.rbBaik);
            this.Controls.Add(this.rbIstimewa);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbTake);
            this.Controls.Add(this.tbTagihan);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgolonganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.RadioButton rbBaik;
        private System.Windows.Forms.RadioButton rbIstimewa;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox tbTake;
        private System.Windows.Forms.TextBox tbTagihan;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGolongan;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbCukup;
        private System.Windows.Forms.TextBox tbGaji;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource msgolonganBindingSource;
        private DataSet1TableAdapters.ms_golonganTableAdapter ms_golonganTableAdapter;
    }
}