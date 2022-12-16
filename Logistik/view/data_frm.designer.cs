namespace logistik.view
{
    partial class data_frm
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
            this.simpan_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.id_client = new System.Windows.Forms.TextBox();
            this.no_telp = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cek_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(147, 141);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(50, 21);
            this.simpan_btn.TabIndex = 0;
            this.simpan_btn.Text = "simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.Location = new System.Drawing.Point(201, 141);
            this.ubah_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(50, 21);
            this.ubah_btn.TabIndex = 1;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = true;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(255, 141);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(50, 21);
            this.hapus_btn.TabIndex = 2;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // id_client
            // 
            this.id_client.Location = new System.Drawing.Point(196, 32);
            this.id_client.Margin = new System.Windows.Forms.Padding(2);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(68, 20);
            this.id_client.TabIndex = 3;
            this.id_client.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // no_telp
            // 
            this.no_telp.Location = new System.Drawing.Point(203, 116);
            this.no_telp.Margin = new System.Windows.Forms.Padding(2);
            this.no_telp.Name = "no_telp";
            this.no_telp.Size = new System.Drawing.Size(68, 20);
            this.no_telp.TabIndex = 4;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(203, 88);
            this.alamat.Margin = new System.Windows.Forms.Padding(2);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(68, 20);
            this.alamat.TabIndex = 5;
            this.alamat.TextChanged += new System.EventHandler(this.harga_TextChanged);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(203, 60);
            this.nama.Margin = new System.Windows.Forms.Padding(2);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(68, 20);
            this.nama.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "No Telp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid});
            this.dataGridView1.Location = new System.Drawing.Point(8, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(489, 88);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id_client";
            this.cid.HeaderText = "id client";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cek_btn
            // 
            this.cek_btn.Location = new System.Drawing.Point(267, 34);
            this.cek_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cek_btn.Name = "cek_btn";
            this.cek_btn.Size = new System.Drawing.Size(50, 22);
            this.cek_btn.TabIndex = 12;
            this.cek_btn.Text = "cek";
            this.cek_btn.UseVisualStyleBackColor = true;
            this.cek_btn.Click += new System.EventHandler(this.cek_btn_Click);
            // 
            // data_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 271);
            this.Controls.Add(this.cek_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.no_telp);
            this.Controls.Add(this.id_client);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.simpan_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "data_frm";
            this.Text = "barang_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.barang_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.TextBox id_client;
        private System.Windows.Forms.TextBox no_telp;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cek_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
    }
}