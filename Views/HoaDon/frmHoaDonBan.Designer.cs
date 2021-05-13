namespace QuanLyCuaHangTienLoi.Views
{
    partial class frmHoaDonBan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietBan = new System.Windows.Forms.DataGridView();
            this.sMavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDonvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.sMahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaythang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTen = new System.Windows.Forms.Label();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            this.cboTenNv = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tìmKiếmTheoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoTênNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiemTen = new System.Windows.Forms.Button();
            this.btnTimKiemAll = new System.Windows.Forms.Button();
            this.btnTimKiemNgay = new System.Windows.Forms.Button();
            this.btnXemAll = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietBan);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(532, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 458);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgvChiTietBan
            // 
            this.dgvChiTietBan.AllowUserToAddRows = false;
            this.dgvChiTietBan.AllowUserToDeleteRows = false;
            this.dgvChiTietBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTietBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMavach,
            this.sTenhang,
            this.sGiaban,
            this.sSoluong,
            this.sDonvitinh,
            this.sThanhtien});
            this.dgvChiTietBan.Location = new System.Drawing.Point(6, 19);
            this.dgvChiTietBan.Name = "dgvChiTietBan";
            this.dgvChiTietBan.ReadOnly = true;
            this.dgvChiTietBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBan.Size = new System.Drawing.Size(773, 433);
            this.dgvChiTietBan.TabIndex = 3;
            // 
            // sMavach
            // 
            this.sMavach.DataPropertyName = "sMavach";
            this.sMavach.HeaderText = "Mã Vạch";
            this.sMavach.Name = "sMavach";
            this.sMavach.ReadOnly = true;
            // 
            // sTenhang
            // 
            this.sTenhang.DataPropertyName = "sTenhang";
            this.sTenhang.HeaderText = "Tên Hàng";
            this.sTenhang.Name = "sTenhang";
            this.sTenhang.ReadOnly = true;
            // 
            // sGiaban
            // 
            this.sGiaban.DataPropertyName = "dGiaban";
            this.sGiaban.HeaderText = "Giá";
            this.sGiaban.Name = "sGiaban";
            this.sGiaban.ReadOnly = true;
            // 
            // sSoluong
            // 
            this.sSoluong.DataPropertyName = "iSoluong";
            this.sSoluong.HeaderText = "Số Lượng Bán";
            this.sSoluong.Name = "sSoluong";
            this.sSoluong.ReadOnly = true;
            // 
            // sDonvitinh
            // 
            this.sDonvitinh.DataPropertyName = "sDonvitinh";
            this.sDonvitinh.HeaderText = "Đơn Vị Tính";
            this.sDonvitinh.Name = "sDonvitinh";
            this.sDonvitinh.ReadOnly = true;
            // 
            // sThanhtien
            // 
            this.sThanhtien.DataPropertyName = "sThanhtien";
            this.sThanhtien.HeaderText = "Thành Tiền (VND)";
            this.sThanhtien.Name = "sThanhtien";
            this.sThanhtien.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemAll);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 458);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMahoadon,
            this.sNhanvien,
            this.sNgaythang,
            this.sTongtien});
            this.dgvHoaDon.Location = new System.Drawing.Point(6, 55);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(489, 397);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // sMahoadon
            // 
            this.sMahoadon.DataPropertyName = "PK_iMahoadonbanID";
            this.sMahoadon.FillWeight = 85.95601F;
            this.sMahoadon.HeaderText = "Mã Hóa Đơn";
            this.sMahoadon.Name = "sMahoadon";
            this.sMahoadon.ReadOnly = true;
            // 
            // sNhanvien
            // 
            this.sNhanvien.DataPropertyName = "sHoten";
            this.sNhanvien.FillWeight = 142.132F;
            this.sNhanvien.HeaderText = "Nhân Viên";
            this.sNhanvien.Name = "sNhanvien";
            this.sNhanvien.ReadOnly = true;
            this.sNhanvien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sNgaythang
            // 
            this.sNgaythang.DataPropertyName = "dNgaythang";
            this.sNgaythang.FillWeight = 85.95601F;
            this.sNgaythang.HeaderText = "Ngày Lập";
            this.sNgaythang.Name = "sNgaythang";
            this.sNgaythang.ReadOnly = true;
            // 
            // sTongtien
            // 
            this.sTongtien.DataPropertyName = "sThanhtien";
            this.sTongtien.FillWeight = 85.95601F;
            this.sTongtien.HeaderText = "Tổng Tiền";
            this.sTongtien.Name = "sTongtien";
            this.sTongtien.ReadOnly = true;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(8, 42);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(39, 19);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên :";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "";
            this.dtNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(410, 36);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtNgayBatDau.Size = new System.Drawing.Size(103, 26);
            this.dtNgayBatDau.TabIndex = 3;
            this.dtNgayBatDau.Visible = false;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(612, 36);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(103, 26);
            this.dtNgayKetThuc.TabIndex = 4;
            this.dtNgayKetThuc.Visible = false;
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.Location = new System.Drawing.Point(339, 42);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(71, 19);
            this.lblTu.TabIndex = 5;
            this.lblTu.Text = "Từ Ngày :";
            this.lblTu.Visible = false;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.Location = new System.Drawing.Point(528, 42);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(78, 19);
            this.lblDen.TabIndex = 5;
            this.lblDen.Text = "Đến Ngày :";
            this.lblDen.Visible = false;
            // 
            // cboTenNv
            // 
            this.cboTenNv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenNv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenNv.FormattingEnabled = true;
            this.cboTenNv.Location = new System.Drawing.Point(53, 33);
            this.cboTenNv.Name = "cboTenNv";
            this.cboTenNv.Size = new System.Drawing.Size(176, 27);
            this.cboTenNv.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmTheoTênToolStripMenuItem,
            this.tìmKiếmTheoNgàyToolStripMenuItem,
            this.tìmKiếmTheoTênNgàyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tìmKiếmTheoTênToolStripMenuItem
            // 
            this.tìmKiếmTheoTênToolStripMenuItem.Name = "tìmKiếmTheoTênToolStripMenuItem";
            this.tìmKiếmTheoTênToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.tìmKiếmTheoTênToolStripMenuItem.Text = "Tìm Kiếm Theo Tên";
            this.tìmKiếmTheoTênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoTênToolStripMenuItem_Click);
            // 
            // tìmKiếmTheoNgàyToolStripMenuItem
            // 
            this.tìmKiếmTheoNgàyToolStripMenuItem.Name = "tìmKiếmTheoNgàyToolStripMenuItem";
            this.tìmKiếmTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.tìmKiếmTheoNgàyToolStripMenuItem.Text = "Tìm Kiếm Theo Ngày";
            this.tìmKiếmTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoNgàyToolStripMenuItem_Click);
            // 
            // tìmKiếmTheoTênNgàyToolStripMenuItem
            // 
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Name = "tìmKiếmTheoTênNgàyToolStripMenuItem";
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Text = "Tìm Kiếm Theo Tên, Ngày";
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoTênNgàyToolStripMenuItem_Click);
            // 
            // btnTimKiemTen
            // 
            this.btnTimKiemTen.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_search_306;
            this.btnTimKiemTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiemTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTen.Location = new System.Drawing.Point(235, 27);
            this.btnTimKiemTen.Name = "btnTimKiemTen";
            this.btnTimKiemTen.Size = new System.Drawing.Size(98, 34);
            this.btnTimKiemTen.TabIndex = 2;
            this.btnTimKiemTen.Text = "Tìm Kiếm";
            this.btnTimKiemTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemTen.UseVisualStyleBackColor = true;
            this.btnTimKiemTen.Click += new System.EventHandler(this.btnTimKiemTen_Click);
            // 
            // btnTimKiemAll
            // 
            this.btnTimKiemAll.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_search_306;
            this.btnTimKiemAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiemAll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemAll.Location = new System.Drawing.Point(830, 27);
            this.btnTimKiemAll.Name = "btnTimKiemAll";
            this.btnTimKiemAll.Size = new System.Drawing.Size(94, 35);
            this.btnTimKiemAll.TabIndex = 6;
            this.btnTimKiemAll.Text = "Tìm Kiếm";
            this.btnTimKiemAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemAll.UseVisualStyleBackColor = true;
            this.btnTimKiemAll.Visible = false;
            this.btnTimKiemAll.Click += new System.EventHandler(this.btnTimKiemAll_Click);
            // 
            // btnTimKiemNgay
            // 
            this.btnTimKiemNgay.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_search_306;
            this.btnTimKiemNgay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiemNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNgay.Location = new System.Drawing.Point(730, 27);
            this.btnTimKiemNgay.Name = "btnTimKiemNgay";
            this.btnTimKiemNgay.Size = new System.Drawing.Size(94, 38);
            this.btnTimKiemNgay.TabIndex = 5;
            this.btnTimKiemNgay.Text = "Tìm Kiếm";
            this.btnTimKiemNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemNgay.UseVisualStyleBackColor = true;
            this.btnTimKiemNgay.Visible = false;
            this.btnTimKiemNgay.Click += new System.EventHandler(this.btnTimKiemNgay_Click);
            // 
            // btnXemAll
            // 
            this.btnXemAll.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.search_blue2;
            this.btnXemAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXemAll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemAll.Location = new System.Drawing.Point(262, 16);
            this.btnXemAll.Name = "btnXemAll";
            this.btnXemAll.Size = new System.Drawing.Size(113, 33);
            this.btnXemAll.TabIndex = 7;
            this.btnXemAll.Text = "Xem Tất Cả";
            this.btnXemAll.UseVisualStyleBackColor = true;
            this.btnXemAll.Click += new System.EventHandler(this.btnXemAll_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_print_301;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(382, 16);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(113, 33);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "          In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.cboTenNv);
            this.Controls.Add(this.btnTimKiemTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.dtNgayKetThuc);
            this.Controls.Add(this.dtNgayBatDau);
            this.Controls.Add(this.btnTimKiemAll);
            this.Controls.Add(this.btnTimKiemNgay);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChiTietBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnTimKiemNgay;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Button btnTimKiemTen;
        private System.Windows.Forms.ComboBox cboTenNv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoTênNgàyToolStripMenuItem;
        private System.Windows.Forms.Button btnTimKiemAll;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoTênToolStripMenuItem;
        private System.Windows.Forms.Button btnXemAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sThanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaythang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTongtien;
    }
}