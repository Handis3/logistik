namespace logistik.view
{
    partial class MahasiswaFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nim_txt = new System.Windows.Forms.TextBox();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.laki_rdn = new System.Windows.Forms.RadioButton();
            this.perempuan_rdn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alamat_txt = new System.Windows.Forms.TextBox();
            this.kode_cmb = new System.Windows.Forms.ComboBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.tgl_dtp = new System.Windows.Forms.DateTimePicker();
            this.keluar_btn = new System.Windows.Forms.Button();
            this.mahasiswa_GridView = new System.Windows.Forms.DataGridView();
            this.cnim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjns_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctgl_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckode_jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batal_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carimhs_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa_GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nim_txt
            // 
            this.nim_txt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nim_txt.Location = new System.Drawing.Point(175, 51);
            this.nim_txt.Margin = new System.Windows.Forms.Padding(2);
            this.nim_txt.Name = "nim_txt";
            this.nim_txt.Size = new System.Drawing.Size(115, 29);
            this.nim_txt.TabIndex = 0;
            // 
            // nama_txt
            // 
            this.nama_txt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_txt.Location = new System.Drawing.Point(175, 92);
            this.nama_txt.Margin = new System.Windows.Forms.Padding(2);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(230, 29);
            this.nama_txt.TabIndex = 1;
            // 
            // laki_rdn
            // 
            this.laki_rdn.AutoSize = true;
            this.laki_rdn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laki_rdn.Location = new System.Drawing.Point(175, 133);
            this.laki_rdn.Margin = new System.Windows.Forms.Padding(2);
            this.laki_rdn.Name = "laki_rdn";
            this.laki_rdn.Size = new System.Drawing.Size(71, 22);
            this.laki_rdn.TabIndex = 2;
            this.laki_rdn.TabStop = true;
            this.laki_rdn.Text = "Ready";
            this.laki_rdn.UseVisualStyleBackColor = true;
            this.laki_rdn.CheckedChanged += new System.EventHandler(this.laki_rdn_CheckedChanged);
            // 
            // perempuan_rdn
            // 
            this.perempuan_rdn.AutoSize = true;
            this.perempuan_rdn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perempuan_rdn.Location = new System.Drawing.Point(306, 133);
            this.perempuan_rdn.Margin = new System.Windows.Forms.Padding(2);
            this.perempuan_rdn.Name = "perempuan_rdn";
            this.perempuan_rdn.Size = new System.Drawing.Size(70, 22);
            this.perempuan_rdn.TabIndex = 3;
            this.perempuan_rdn.TabStop = true;
            this.perempuan_rdn.Text = "Empty";
            this.perempuan_rdn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID PENGIRIMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAMA BARANG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "STATUS BARANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "ALAMAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "TGL.PENGIRIMAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "KODE BARANG";
            // 
            // alamat_txt
            // 
            this.alamat_txt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_txt.Location = new System.Drawing.Point(175, 171);
            this.alamat_txt.Margin = new System.Windows.Forms.Padding(2);
            this.alamat_txt.Multiline = true;
            this.alamat_txt.Name = "alamat_txt";
            this.alamat_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alamat_txt.Size = new System.Drawing.Size(230, 74);
            this.alamat_txt.TabIndex = 10;
            // 
            // kode_cmb
            // 
            this.kode_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kode_cmb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_cmb.FormattingEnabled = true;
            this.kode_cmb.Location = new System.Drawing.Point(175, 296);
            this.kode_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.kode_cmb.Name = "kode_cmb";
            this.kode_cmb.Size = new System.Drawing.Size(92, 26);
            this.kode_cmb.TabIndex = 11;
            this.kode_cmb.SelectedIndexChanged += new System.EventHandler(this.kode_cmb_SelectedIndexChanged);
            // 
            // simpan_btn
            // 
            this.simpan_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.Location = new System.Drawing.Point(89, 359);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(70, 31);
            this.simpan_btn.TabIndex = 12;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_btn.Location = new System.Drawing.Point(182, 359);
            this.ubah_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(70, 31);
            this.ubah_btn.TabIndex = 13;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = true;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(269, 359);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(70, 31);
            this.hapus_btn.TabIndex = 14;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // tgl_dtp
            // 
            this.tgl_dtp.CustomFormat = "dd MMM yyyy";
            this.tgl_dtp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tgl_dtp.Location = new System.Drawing.Point(175, 262);
            this.tgl_dtp.Margin = new System.Windows.Forms.Padding(2);
            this.tgl_dtp.Name = "tgl_dtp";
            this.tgl_dtp.Size = new System.Drawing.Size(151, 26);
            this.tgl_dtp.TabIndex = 15;
            // 
            // keluar_btn
            // 
            this.keluar_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar_btn.Location = new System.Drawing.Point(352, 359);
            this.keluar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.keluar_btn.Name = "keluar_btn";
            this.keluar_btn.Size = new System.Drawing.Size(70, 31);
            this.keluar_btn.TabIndex = 16;
            this.keluar_btn.Text = "Keluar";
            this.keluar_btn.UseVisualStyleBackColor = true;
            this.keluar_btn.Click += new System.EventHandler(this.keluar_btn_Click);
            // 
            // mahasiswa_GridView
            // 
            this.mahasiswa_GridView.AllowUserToAddRows = false;
            this.mahasiswa_GridView.AllowUserToDeleteRows = false;
            this.mahasiswa_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mahasiswa_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnim,
            this.cnama,
            this.cjns_kelamin,
            this.calamat,
            this.ctgl_lahir,
            this.ckode_jurusan});
            this.mahasiswa_GridView.Location = new System.Drawing.Point(2, 436);
            this.mahasiswa_GridView.Margin = new System.Windows.Forms.Padding(2);
            this.mahasiswa_GridView.Name = "mahasiswa_GridView";
            this.mahasiswa_GridView.ReadOnly = true;
            this.mahasiswa_GridView.RowTemplate.Height = 24;
            this.mahasiswa_GridView.Size = new System.Drawing.Size(748, 187);
            this.mahasiswa_GridView.TabIndex = 17;
            this.mahasiswa_GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mahasiswa_GridView_CellClick);
            this.mahasiswa_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mahasiswa_GridView_CellContentClick);
            // 
            // cnim
            // 
            this.cnim.DataPropertyName = "id_pengiriman";
            this.cnim.HeaderText = "NIM";
            this.cnim.Name = "cnim";
            this.cnim.ReadOnly = true;
            // 
            // cnama
            // 
            this.cnama.DataPropertyName = "nama_barang";
            this.cnama.HeaderText = "NAMA MAHASISWA";
            this.cnama.Name = "cnama";
            this.cnama.ReadOnly = true;
            this.cnama.Width = 200;
            // 
            // cjns_kelamin
            // 
            this.cjns_kelamin.DataPropertyName = "status_barang";
            this.cjns_kelamin.HeaderText = "JENIS KELAMIN";
            this.cjns_kelamin.Name = "cjns_kelamin";
            this.cjns_kelamin.ReadOnly = true;
            this.cjns_kelamin.Width = 150;
            // 
            // calamat
            // 
            this.calamat.DataPropertyName = "alamat";
            this.calamat.HeaderText = "ALAMAT";
            this.calamat.Name = "calamat";
            this.calamat.ReadOnly = true;
            this.calamat.Width = 200;
            // 
            // ctgl_lahir
            // 
            this.ctgl_lahir.DataPropertyName = "tangggal_pengiriman";
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.ctgl_lahir.DefaultCellStyle = dataGridViewCellStyle2;
            this.ctgl_lahir.HeaderText = "TANGGAL LAHIR";
            this.ctgl_lahir.Name = "ctgl_lahir";
            this.ctgl_lahir.ReadOnly = true;
            this.ctgl_lahir.Width = 150;
            // 
            // ckode_jurusan
            // 
            this.ckode_jurusan.DataPropertyName = "nama_barang";
            this.ckode_jurusan.HeaderText = "KODE_JURUSAN";
            this.ckode_jurusan.Name = "ckode_jurusan";
            this.ckode_jurusan.ReadOnly = true;
            this.ckode_jurusan.Width = 150;
            // 
            // batal_btn
            // 
            this.batal_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.Location = new System.Drawing.Point(436, 359);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(2);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(70, 31);
            this.batal_btn.TabIndex = 18;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carimhs_txt);
            this.groupBox1.Location = new System.Drawing.Point(20, 636);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(371, 70);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari dengan nama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // carimhs_txt
            // 
            this.carimhs_txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carimhs_txt.Location = new System.Drawing.Point(0, 28);
            this.carimhs_txt.Margin = new System.Windows.Forms.Padding(2);
            this.carimhs_txt.Name = "carimhs_txt";
            this.carimhs_txt.Size = new System.Drawing.Size(276, 26);
            this.carimhs_txt.TabIndex = 0;
            this.carimhs_txt.TextChanged += new System.EventHandler(this.carimhs_txt_TextChanged);
            // 
            // MahasiswaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.mahasiswa_GridView);
            this.Controls.Add(this.keluar_btn);
            this.Controls.Add(this.tgl_dtp);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.kode_cmb);
            this.Controls.Add(this.alamat_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perempuan_rdn);
            this.Controls.Add(this.laki_rdn);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.nim_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MahasiswaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATA PENGIRIMAN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MahasiswaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa_GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nim_txt;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.RadioButton laki_rdn;
        private System.Windows.Forms.RadioButton perempuan_rdn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alamat_txt;
        private System.Windows.Forms.ComboBox kode_cmb;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.DateTimePicker tgl_dtp;
        private System.Windows.Forms.Button keluar_btn;
        private System.Windows.Forms.DataGridView mahasiswa_GridView;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox carimhs_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjns_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn calamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgl_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckode_jurusan;
    }
}