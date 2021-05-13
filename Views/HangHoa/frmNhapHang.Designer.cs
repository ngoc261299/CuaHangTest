namespace QuanLyCuaHangTienLoi
{
    partial class frmNhapHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNcc = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.sMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyChonLoai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvCTN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMahang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTenhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGianhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sThanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnHuyNhap = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNcc);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 465);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng Đã Có";
            // 
            // cboNcc
            // 
            this.cboNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNcc.FormattingEnabled = true;
            this.cboNcc.Location = new System.Drawing.Point(115, 28);
            this.cboNcc.Name = "cboNcc";
            this.cboNcc.Size = new System.Drawing.Size(247, 27);
            this.cboNcc.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHangHoa);
            this.groupBox4.Location = new System.Drawing.Point(285, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 391);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mặt Hàng";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMa,
            this.sTenhang,
            this.sSoluong});
            this.dgvHangHoa.Location = new System.Drawing.Point(6, 19);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(343, 366);
            this.dgvHangHoa.TabIndex = 2;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // sMa
            // 
            this.sMa.DataPropertyName = "PK_iMamathangID";
            this.sMa.FillWeight = 102.2701F;
            this.sMa.HeaderText = "Mã Hàng Hóa";
            this.sMa.Name = "sMa";
            this.sMa.ReadOnly = true;
            // 
            // sTenhang
            // 
            this.sTenhang.DataPropertyName = "sTenhang";
            this.sTenhang.FillWeight = 121.5877F;
            this.sTenhang.HeaderText = "Tên Hàng Hóa";
            this.sTenhang.Name = "sTenhang";
            this.sTenhang.ReadOnly = true;
            // 
            // sSoluong
            // 
            this.sSoluong.DataPropertyName = "iSoluong";
            this.sSoluong.FillWeight = 76.14212F;
            this.sSoluong.HeaderText = "Số Lượng";
            this.sSoluong.Name = "sSoluong";
            this.sSoluong.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà Cung Cấp :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLoaiHang);
            this.groupBox3.Controls.Add(this.btnHuyChonLoai);
            this.groupBox3.Location = new System.Drawing.Point(23, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 391);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Hàng";
            // 
            // dgvLoaiHang
            // 
            this.dgvLoaiHang.AllowUserToAddRows = false;
            this.dgvLoaiHang.AllowUserToDeleteRows = false;
            this.dgvLoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvLoaiHang.Location = new System.Drawing.Point(6, 19);
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.ReadOnly = true;
            this.dgvLoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiHang.Size = new System.Drawing.Size(228, 320);
            this.dgvLoaiHang.TabIndex = 1;
            this.dgvLoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_iMaloaihangID";
            this.Column1.HeaderText = "Mã Loại Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenloaihang";
            this.Column2.HeaderText = "Tên Loại Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnHuyChonLoai
            // 
            this.btnHuyChonLoai.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_3010;
            this.btnHuyChonLoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyChonLoai.Location = new System.Drawing.Point(139, 348);
            this.btnHuyChonLoai.Name = "btnHuyChonLoai";
            this.btnHuyChonLoai.Size = new System.Drawing.Size(95, 37);
            this.btnHuyChonLoai.TabIndex = 5;
            this.btnHuyChonLoai.Text = "         Hủy";
            this.btnHuyChonLoai.UseVisualStyleBackColor = true;
            this.btnHuyChonLoai.Click += new System.EventHandler(this.btnHuyChonLoai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvCTN);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.btnNhap);
            this.groupBox2.Controls.Add(this.btnHuyNhap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(701, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 465);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hàng Sẽ Nhập Thêm";
            // 
            // lvCTN
            // 
            this.lvCTN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.lvMahang,
            this.lvTenhang,
            this.lvSoluong,
            this.lvGianhap,
            this.sThanhtien});
            this.lvCTN.HideSelection = false;
            this.lvCTN.Location = new System.Drawing.Point(21, 31);
            this.lvCTN.Name = "lvCTN";
            this.lvCTN.Size = new System.Drawing.Size(565, 376);
            this.lvCTN.TabIndex = 12;
            this.lvCTN.UseCompatibleStateImageBehavior = false;
            this.lvCTN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 38;
            // 
            // lvMahang
            // 
            this.lvMahang.Text = "Mã Hàng";
            this.lvMahang.Width = 66;
            // 
            // lvTenhang
            // 
            this.lvTenhang.Text = "Tên Hàng";
            this.lvTenhang.Width = 142;
            // 
            // lvSoluong
            // 
            this.lvSoluong.Text = "Số Lượng";
            this.lvSoluong.Width = 81;
            // 
            // lvGianhap
            // 
            this.lvGianhap.Text = "Giá Nhập";
            this.lvGianhap.Width = 112;
            // 
            // sThanhtien
            // 
            this.sThanhtien.Text = "Thành Tiền";
            this.sThanhtien.Width = 125;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(132, 431);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(178, 26);
            this.txtTongtien.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng tiền (VND) :";
            // 
            // btnNhap
            // 
            this.btnNhap.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons_insert2;
            this.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhap.Location = new System.Drawing.Point(391, 422);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(114, 35);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập Hàng";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnHuyNhap
            // 
            this.btnHuyNhap.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_309;
            this.btnHuyNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyNhap.Location = new System.Drawing.Point(511, 422);
            this.btnHuyNhap.Name = "btnHuyNhap";
            this.btnHuyNhap.Size = new System.Drawing.Size(99, 37);
            this.btnHuyNhap.TabIndex = 1;
            this.btnHuyNhap.Text = "        Hủy";
            this.btnHuyNhap.UseVisualStyleBackColor = true;
            this.btnHuyNhap.Click += new System.EventHandler(this.btnHuyNhap_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_308;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(489, 27);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 35);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "       Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.add11;
            this.btnChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(401, 28);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(82, 34);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "   Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuyNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.ComboBox cboNcc;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHuyChonLoai;
        private System.Windows.Forms.ListView lvCTN;
        private System.Windows.Forms.ColumnHeader lvMahang;
        private System.Windows.Forms.ColumnHeader lvTenhang;
        private System.Windows.Forms.ColumnHeader lvSoluong;
        private System.Windows.Forms.ColumnHeader lvGianhap;
        private System.Windows.Forms.ColumnHeader sThanhtien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}