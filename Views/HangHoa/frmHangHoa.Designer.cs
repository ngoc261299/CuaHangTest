namespace QuanLyCuaHangTienLoi.Views
{
    partial class frmHangHoa
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
            this.pnlLoaiHang = new System.Windows.Forms.Panel();
            this.grpLoaiHang = new System.Windows.Forms.GroupBox();
            this.txtTimLoaiHang = new System.Windows.Forms.TextBox();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHangHoa = new System.Windows.Forms.Panel();
            this.grpHangHoa = new System.Windows.Forms.GroupBox();
            this.txtTimMatHang = new System.Windows.Forms.TextBox();
            this.btnTimMatHang = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.sMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLoaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDonvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaHangHoa = new System.Windows.Forms.Button();
            this.btnXemAll = new System.Windows.Forms.Button();
            this.btnSuaHangHoa = new System.Windows.Forms.Button();
            this.btnThemHangHoa = new System.Windows.Forms.Button();
            this.btnXoaLoaiHang = new System.Windows.Forms.Button();
            this.btnXemLoaiHang = new System.Windows.Forms.Button();
            this.btnTimLoaiHang = new System.Windows.Forms.Button();
            this.btnSuaLoaiHang = new System.Windows.Forms.Button();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.pnlLoaiHang.SuspendLayout();
            this.grpLoaiHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.pnlHangHoa.SuspendLayout();
            this.grpHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoaiHang
            // 
            this.pnlLoaiHang.BackColor = System.Drawing.Color.White;
            this.pnlLoaiHang.Controls.Add(this.grpLoaiHang);
            this.pnlLoaiHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoaiHang.Location = new System.Drawing.Point(0, 0);
            this.pnlLoaiHang.Name = "pnlLoaiHang";
            this.pnlLoaiHang.Size = new System.Drawing.Size(346, 541);
            this.pnlLoaiHang.TabIndex = 0;
            // 
            // grpLoaiHang
            // 
            this.grpLoaiHang.BackColor = System.Drawing.Color.White;
            this.grpLoaiHang.Controls.Add(this.btnXoaLoaiHang);
            this.grpLoaiHang.Controls.Add(this.txtTimLoaiHang);
            this.grpLoaiHang.Controls.Add(this.btnXemLoaiHang);
            this.grpLoaiHang.Controls.Add(this.btnTimLoaiHang);
            this.grpLoaiHang.Controls.Add(this.btnSuaLoaiHang);
            this.grpLoaiHang.Controls.Add(this.btnThemLoaiHang);
            this.grpLoaiHang.Controls.Add(this.dgvLoaiHang);
            this.grpLoaiHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoaiHang.Location = new System.Drawing.Point(13, 13);
            this.grpLoaiHang.Name = "grpLoaiHang";
            this.grpLoaiHang.Size = new System.Drawing.Size(323, 516);
            this.grpLoaiHang.TabIndex = 0;
            this.grpLoaiHang.TabStop = false;
            this.grpLoaiHang.Text = "Loại Hàng";
            // 
            // txtTimLoaiHang
            // 
            this.txtTimLoaiHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimLoaiHang.Location = new System.Drawing.Point(7, 26);
            this.txtTimLoaiHang.Name = "txtTimLoaiHang";
            this.txtTimLoaiHang.Size = new System.Drawing.Size(194, 26);
            this.txtTimLoaiHang.TabIndex = 3;
            this.txtTimLoaiHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimLoaiHang_KeyDown);
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
            this.dgvLoaiHang.Location = new System.Drawing.Point(7, 106);
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.ReadOnly = true;
            this.dgvLoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiHang.Size = new System.Drawing.Size(310, 404);
            this.dgvLoaiHang.TabIndex = 0;
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
            // pnlHangHoa
            // 
            this.pnlHangHoa.BackColor = System.Drawing.Color.White;
            this.pnlHangHoa.Controls.Add(this.grpHangHoa);
            this.pnlHangHoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHangHoa.Location = new System.Drawing.Point(352, 0);
            this.pnlHangHoa.Name = "pnlHangHoa";
            this.pnlHangHoa.Size = new System.Drawing.Size(977, 541);
            this.pnlHangHoa.TabIndex = 1;
            // 
            // grpHangHoa
            // 
            this.grpHangHoa.Controls.Add(this.btnXoaHangHoa);
            this.grpHangHoa.Controls.Add(this.txtTimMatHang);
            this.grpHangHoa.Controls.Add(this.btnXemAll);
            this.grpHangHoa.Controls.Add(this.btnTimMatHang);
            this.grpHangHoa.Controls.Add(this.btnSuaHangHoa);
            this.grpHangHoa.Controls.Add(this.btnThemHangHoa);
            this.grpHangHoa.Controls.Add(this.dgvHangHoa);
            this.grpHangHoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHangHoa.Location = new System.Drawing.Point(3, 13);
            this.grpHangHoa.Name = "grpHangHoa";
            this.grpHangHoa.Size = new System.Drawing.Size(968, 516);
            this.grpHangHoa.TabIndex = 0;
            this.grpHangHoa.TabStop = false;
            this.grpHangHoa.Text = "Hàng Hóa";
            // 
            // txtTimMatHang
            // 
            this.txtTimMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMatHang.Location = new System.Drawing.Point(495, 22);
            this.txtTimMatHang.Name = "txtTimMatHang";
            this.txtTimMatHang.Size = new System.Drawing.Size(381, 26);
            this.txtTimMatHang.TabIndex = 4;
            this.txtTimMatHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimMatHang_KeyDown);
            // 
            // btnTimMatHang
            // 
            this.btnTimMatHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMatHang.Location = new System.Drawing.Point(882, 23);
            this.btnTimMatHang.Name = "btnTimMatHang";
            this.btnTimMatHang.Size = new System.Drawing.Size(80, 25);
            this.btnTimMatHang.TabIndex = 5;
            this.btnTimMatHang.Text = "Tìm Kiếm";
            this.btnTimMatHang.UseVisualStyleBackColor = true;
            this.btnTimMatHang.Click += new System.EventHandler(this.btnTimMatHang_Click);
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
            this.sMavach,
            this.sLoaihang,
            this.sTenhang,
            this.sSoluong,
            this.sDonvitinh,
            this.sGiaban});
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 70);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(950, 440);
            this.dgvHangHoa.TabIndex = 1;
            // 
            // sMa
            // 
            this.sMa.DataPropertyName = "PK_iMamathangID";
            this.sMa.HeaderText = "Mã Hàng Hóa";
            this.sMa.Name = "sMa";
            this.sMa.ReadOnly = true;
            // 
            // sMavach
            // 
            this.sMavach.DataPropertyName = "sMavach";
            this.sMavach.HeaderText = "Mã Vạch";
            this.sMavach.Name = "sMavach";
            this.sMavach.ReadOnly = true;
            // 
            // sLoaihang
            // 
            this.sLoaihang.DataPropertyName = "loaihang";
            this.sLoaihang.HeaderText = "Loại Hàng";
            this.sLoaihang.Name = "sLoaihang";
            this.sLoaihang.ReadOnly = true;
            // 
            // sTenhang
            // 
            this.sTenhang.DataPropertyName = "sTenhang";
            this.sTenhang.HeaderText = "Tên Hàng Hóa";
            this.sTenhang.Name = "sTenhang";
            this.sTenhang.ReadOnly = true;
            // 
            // sSoluong
            // 
            this.sSoluong.DataPropertyName = "iSoluong";
            this.sSoluong.HeaderText = "Số Lượng";
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
            // sGiaban
            // 
            this.sGiaban.DataPropertyName = "dGiaban";
            this.sGiaban.HeaderText = "Giá Bán (Nghìn VND)";
            this.sGiaban.Name = "sGiaban";
            this.sGiaban.ReadOnly = true;
            // 
            // btnXoaHangHoa
            // 
            this.btnXoaHangHoa.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_delete_3010;
            this.btnXoaHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaHangHoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHangHoa.Location = new System.Drawing.Point(329, 26);
            this.btnXoaHangHoa.Name = "btnXoaHangHoa";
            this.btnXoaHangHoa.Size = new System.Drawing.Size(91, 38);
            this.btnXoaHangHoa.TabIndex = 6;
            this.btnXoaHangHoa.Text = "         Xóa";
            this.btnXoaHangHoa.UseVisualStyleBackColor = true;
            // 
            // btnXemAll
            // 
            this.btnXemAll.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.search_blue4;
            this.btnXemAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXemAll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemAll.Location = new System.Drawing.Point(23, 26);
            this.btnXemAll.Name = "btnXemAll";
            this.btnXemAll.Size = new System.Drawing.Size(99, 38);
            this.btnXemAll.TabIndex = 1;
            this.btnXemAll.Text = "Xem Tất Cả";
            this.btnXemAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemAll.UseVisualStyleBackColor = true;
            this.btnXemAll.Click += new System.EventHandler(this.btnXemAll_Click);
            // 
            // btnSuaHangHoa
            // 
            this.btnSuaHangHoa.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_update_305;
            this.btnSuaHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaHangHoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHangHoa.Location = new System.Drawing.Point(229, 26);
            this.btnSuaHangHoa.Name = "btnSuaHangHoa";
            this.btnSuaHangHoa.Size = new System.Drawing.Size(94, 38);
            this.btnSuaHangHoa.TabIndex = 3;
            this.btnSuaHangHoa.Text = "        Sửa";
            this.btnSuaHangHoa.UseVisualStyleBackColor = true;
            this.btnSuaHangHoa.Click += new System.EventHandler(this.btnSuaHangHoa_Click);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons_insert5;
            this.btnThemHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemHangHoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHangHoa.Location = new System.Drawing.Point(128, 26);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(95, 38);
            this.btnThemHangHoa.TabIndex = 2;
            this.btnThemHangHoa.Text = "       Thêm";
            this.btnThemHangHoa.UseVisualStyleBackColor = true;
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // btnXoaLoaiHang
            // 
            this.btnXoaLoaiHang.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_delete_3010;
            this.btnXoaLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaLoaiHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiHang.Location = new System.Drawing.Point(249, 62);
            this.btnXoaLoaiHang.Name = "btnXoaLoaiHang";
            this.btnXoaLoaiHang.Size = new System.Drawing.Size(68, 38);
            this.btnXoaLoaiHang.TabIndex = 5;
            this.btnXoaLoaiHang.Text = "Xóa";
            this.btnXoaLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLoaiHang.UseVisualStyleBackColor = true;
            // 
            // btnXemLoaiHang
            // 
            this.btnXemLoaiHang.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.search_blue3;
            this.btnXemLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXemLoaiHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLoaiHang.Location = new System.Drawing.Point(6, 58);
            this.btnXemLoaiHang.Name = "btnXemLoaiHang";
            this.btnXemLoaiHang.Size = new System.Drawing.Size(82, 42);
            this.btnXemLoaiHang.TabIndex = 1;
            this.btnXemLoaiHang.Text = "Xem Tất Cả";
            this.btnXemLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemLoaiHang.UseVisualStyleBackColor = true;
            this.btnXemLoaiHang.Click += new System.EventHandler(this.btnXemLoaiHang_Click);
            // 
            // btnTimLoaiHang
            // 
            this.btnTimLoaiHang.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_search_308;
            this.btnTimLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimLoaiHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLoaiHang.Location = new System.Drawing.Point(207, 17);
            this.btnTimLoaiHang.Name = "btnTimLoaiHang";
            this.btnTimLoaiHang.Size = new System.Drawing.Size(94, 36);
            this.btnTimLoaiHang.TabIndex = 4;
            this.btnTimLoaiHang.Text = "Tìm Kiếm";
            this.btnTimLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimLoaiHang.UseVisualStyleBackColor = true;
            this.btnTimLoaiHang.Click += new System.EventHandler(this.btnTimLoaiHang_Click);
            // 
            // btnSuaLoaiHang
            // 
            this.btnSuaLoaiHang.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_update_304;
            this.btnSuaLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaLoaiHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiHang.Location = new System.Drawing.Point(170, 62);
            this.btnSuaLoaiHang.Name = "btnSuaLoaiHang";
            this.btnSuaLoaiHang.Size = new System.Drawing.Size(73, 39);
            this.btnSuaLoaiHang.TabIndex = 2;
            this.btnSuaLoaiHang.Text = "Sửa";
            this.btnSuaLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaLoaiHang.UseVisualStyleBackColor = true;
            this.btnSuaLoaiHang.Click += new System.EventHandler(this.btnSuaLoaiHang_Click);
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons_insert4;
            this.btnThemLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemLoaiHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiHang.Location = new System.Drawing.Point(94, 61);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(70, 41);
            this.btnThemLoaiHang.TabIndex = 1;
            this.btnThemLoaiHang.Text = "Thêm";
            this.btnThemLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLoaiHang.UseVisualStyleBackColor = true;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHangHoa);
            this.Controls.Add(this.pnlLoaiHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.pnlLoaiHang.ResumeLayout(false);
            this.grpLoaiHang.ResumeLayout(false);
            this.grpLoaiHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.pnlHangHoa.ResumeLayout(false);
            this.grpHangHoa.ResumeLayout(false);
            this.grpHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoaiHang;
        private System.Windows.Forms.Panel pnlHangHoa;
        private System.Windows.Forms.GroupBox grpLoaiHang;
        private System.Windows.Forms.GroupBox grpHangHoa;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Button btnSuaLoaiHang;
        private System.Windows.Forms.Button btnThemLoaiHang;
        private System.Windows.Forms.Button btnSuaHangHoa;
        private System.Windows.Forms.Button btnThemHangHoa;
        private System.Windows.Forms.Button btnXemAll;
        private System.Windows.Forms.TextBox txtTimLoaiHang;
        private System.Windows.Forms.Button btnTimLoaiHang;
        private System.Windows.Forms.TextBox txtTimMatHang;
        private System.Windows.Forms.Button btnTimMatHang;
        private System.Windows.Forms.Button btnXemLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLoaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGiaban;
        private System.Windows.Forms.Button btnXoaLoaiHang;
        private System.Windows.Forms.Button btnXoaHangHoa;
    }
}