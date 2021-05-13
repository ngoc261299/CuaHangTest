namespace QuanLyCuaHangTienLoi.Views.ThongKe
{
    partial class frmThongKe
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.sMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimNcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTKKhiLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTimHangHong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHanghong = new System.Windows.Forms.DataGridView();
            this.sMavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaythang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuyTim = new System.Windows.Forms.Button();
            this.btnTimNcc = new System.Windows.Forms.Button();
            this.btnTkKhiLogin = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.btnTimHangHong = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHuyTim);
            this.tabPage2.Controls.Add(this.btnTimNcc);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtTimNcc);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1319, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống Kê Nhà Cung Cấp";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhaCC);
            this.groupBox1.Location = new System.Drawing.Point(10, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1289, 445);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.AllowUserToAddRows = false;
            this.dgvNhaCC.AllowUserToDeleteRows = false;
            this.dgvNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMa,
            this.sTen,
            this.sSdt,
            this.sDiachi});
            this.dgvNhaCC.Location = new System.Drawing.Point(6, 19);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.ReadOnly = true;
            this.dgvNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCC.Size = new System.Drawing.Size(1280, 418);
            this.dgvNhaCC.TabIndex = 1;
            this.dgvNhaCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCC_CellContentClick);
            // 
            // sMa
            // 
            this.sMa.DataPropertyName = "PK_iManhacungcapID";
            this.sMa.HeaderText = "Mã Nhà Cung Cấp";
            this.sMa.Name = "sMa";
            this.sMa.ReadOnly = true;
            // 
            // sTen
            // 
            this.sTen.DataPropertyName = "sTennhacungcap";
            this.sTen.HeaderText = "Tên Nhà Cung Cấp";
            this.sTen.Name = "sTen";
            this.sTen.ReadOnly = true;
            // 
            // sSdt
            // 
            this.sSdt.DataPropertyName = "sSDT";
            this.sSdt.HeaderText = "Số Điện Thoại";
            this.sSdt.Name = "sSdt";
            this.sSdt.ReadOnly = true;
            // 
            // sDiachi
            // 
            this.sDiachi.DataPropertyName = "sDiachi";
            this.sDiachi.HeaderText = "Địa Chỉ";
            this.sDiachi.Name = "sDiachi";
            this.sDiachi.ReadOnly = true;
            // 
            // txtTimNcc
            // 
            this.txtTimNcc.Location = new System.Drawing.Point(121, 19);
            this.txtTimNcc.Name = "txtTimNcc";
            this.txtTimNcc.Size = new System.Drawing.Size(250, 26);
            this.txtTimNcc.TabIndex = 13;
            this.txtTimNcc.TextChanged += new System.EventHandler(this.txtTimNcc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhà Cung Cấp :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTKKhiLogin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnTkKhiLogin);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1319, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống Kê Hàng Tồn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTKKhiLogin
            // 
            this.txtTKKhiLogin.Enabled = false;
            this.txtTKKhiLogin.Location = new System.Drawing.Point(369, 59);
            this.txtTKKhiLogin.Name = "txtTKKhiLogin";
            this.txtTKKhiLogin.Size = new System.Drawing.Size(140, 26);
            this.txtTKKhiLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Đã Thanh Toán Từ Khi Đăng Nhập Vào Hệ Thống:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1327, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bntHuy);
            this.tabPage3.Controls.Add(this.txtTimHangHong);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnTimHangHong);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1319, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống Kê Hàng Hàng Hỏng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTimHangHong
            // 
            this.txtTimHangHong.AcceptsTab = true;
            this.txtTimHangHong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimHangHong.Location = new System.Drawing.Point(179, 35);
            this.txtTimHangHong.Name = "txtTimHangHong";
            this.txtTimHangHong.Size = new System.Drawing.Size(280, 26);
            this.txtTimHangHong.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHanghong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 462);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hàng Hỏng / Lỗi";
            // 
            // dgvHanghong
            // 
            this.dgvHanghong.AllowUserToAddRows = false;
            this.dgvHanghong.AllowUserToDeleteRows = false;
            this.dgvHanghong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanghong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHanghong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMavach,
            this.sTenhang,
            this.sSoluong,
            this.sMota,
            this.sNgaythang});
            this.dgvHanghong.Location = new System.Drawing.Point(6, 25);
            this.dgvHanghong.Name = "dgvHanghong";
            this.dgvHanghong.ReadOnly = true;
            this.dgvHanghong.Size = new System.Drawing.Size(775, 444);
            this.dgvHanghong.TabIndex = 0;
            // 
            // sMavach
            // 
            this.sMavach.DataPropertyName = "sMavach";
            this.sMavach.HeaderText = "Mã  Vạch";
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
            // sSoluong
            // 
            this.sSoluong.DataPropertyName = "iSoluong";
            this.sSoluong.HeaderText = "Số Lượng Hỏng";
            this.sSoluong.Name = "sSoluong";
            this.sSoluong.ReadOnly = true;
            // 
            // sMota
            // 
            this.sMota.DataPropertyName = "sMota";
            this.sMota.HeaderText = "Mô Tả";
            this.sMota.Name = "sMota";
            this.sMota.ReadOnly = true;
            // 
            // sNgaythang
            // 
            this.sNgaythang.DataPropertyName = "dNgaythang";
            this.sNgaythang.HeaderText = "Ngày Lưu";
            this.sNgaythang.Name = "sNgaythang";
            this.sNgaythang.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm Kiếm Hàng Hỏng :";
            // 
            // btnHuyTim
            // 
            this.btnHuyTim.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_3010;
            this.btnHuyTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTim.Location = new System.Drawing.Point(498, 6);
            this.btnHuyTim.Name = "btnHuyTim";
            this.btnHuyTim.Size = new System.Drawing.Size(95, 39);
            this.btnHuyTim.TabIndex = 21;
            this.btnHuyTim.Text = "        Hủy";
            this.btnHuyTim.UseVisualStyleBackColor = true;
            this.btnHuyTim.Click += new System.EventHandler(this.btnHuyTim_Click);
            // 
            // btnTimNcc
            // 
            this.btnTimNcc.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.search_blue5;
            this.btnTimNcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimNcc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNcc.Location = new System.Drawing.Point(397, 6);
            this.btnTimNcc.Name = "btnTimNcc";
            this.btnTimNcc.Size = new System.Drawing.Size(95, 39);
            this.btnTimNcc.TabIndex = 20;
            this.btnTimNcc.Text = "Xem";
            this.btnTimNcc.UseVisualStyleBackColor = true;
            this.btnTimNcc.Click += new System.EventHandler(this.btnTimNcc_Click);
            // 
            // btnTkKhiLogin
            // 
            this.btnTkKhiLogin.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.search_blue;
            this.btnTkKhiLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTkKhiLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTkKhiLogin.Location = new System.Drawing.Point(386, 101);
            this.btnTkKhiLogin.Name = "btnTkKhiLogin";
            this.btnTkKhiLogin.Size = new System.Drawing.Size(107, 33);
            this.btnTkKhiLogin.TabIndex = 0;
            this.btnTkKhiLogin.Text = "Thống Kê";
            this.btnTkKhiLogin.UseVisualStyleBackColor = true;
            this.btnTkKhiLogin.Click += new System.EventHandler(this.btnTkKhiLogin_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_3010;
            this.bntHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuy.Location = new System.Drawing.Point(574, 21);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(92, 38);
            this.bntHuy.TabIndex = 6;
            this.bntHuy.Text = "       Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // btnTimHangHong
            // 
            this.btnTimHangHong.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.search_blue6;
            this.btnTimHangHong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimHangHong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHangHong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimHangHong.Location = new System.Drawing.Point(473, 21);
            this.btnTimHangHong.Name = "btnTimHangHong";
            this.btnTimHangHong.Size = new System.Drawing.Size(95, 38);
            this.btnTimHangHong.TabIndex = 7;
            this.btnTimHangHong.Text = "Xem";
            this.btnTimHangHong.UseVisualStyleBackColor = true;
            this.btnTimHangHong.Click += new System.EventHandler(this.btnTimHangHong_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTKKhiLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTkKhiLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimNcc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnHuyTim;
        private System.Windows.Forms.Button btnTimNcc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHanghong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaythang;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.TextBox txtTimHangHong;
        private System.Windows.Forms.Button btnTimHangHong;
        private System.Windows.Forms.Label label2;
    }
}