namespace QuanLyCuaHangTienLoi.Views
{
    partial class frmNhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoSeller = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.sMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimNhanVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bntHuyTim = new System.Windows.Forms.Button();
            this.btnTimNhanVien = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1304, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgaysinh);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.txtSdt);
            this.groupBox2.Controls.Add(this.txtHoten);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(891, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 431);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.Location = new System.Drawing.Point(127, 103);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(256, 26);
            this.dtNgaysinh.TabIndex = 17;
            this.dtNgaysinh.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoAdmin);
            this.panel2.Controls.Add(this.rdoSeller);
            this.panel2.Location = new System.Drawing.Point(133, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 29);
            this.panel2.TabIndex = 8;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(3, 5);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(104, 23);
            this.rdoAdmin.TabIndex = 18;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Quản trị viên";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoSeller
            // 
            this.rdoSeller.AutoSize = true;
            this.rdoSeller.Checked = true;
            this.rdoSeller.Location = new System.Drawing.Point(106, 5);
            this.rdoSeller.Name = "rdoSeller";
            this.rdoSeller.Size = new System.Drawing.Size(88, 23);
            this.rdoSeller.TabIndex = 17;
            this.rdoSeller.TabStop = true;
            this.rdoSeller.Text = "Nhân viên";
            this.rdoSeller.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNu);
            this.panel1.Controls.Add(this.rdoNam);
            this.panel1.Location = new System.Drawing.Point(127, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 44);
            this.panel1.TabIndex = 2;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Checked = true;
            this.rdoNu.Location = new System.Drawing.Point(102, 8);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(48, 23);
            this.rdoNu.TabIndex = 17;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(2, 8);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 23);
            this.rdoNam.TabIndex = 18;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quyền Quản Trị :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mật Khẩu :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(131, 247);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(256, 26);
            this.txtUser.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Đăng Nhập :";
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_save_all_301;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(153, 370);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 39);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "       Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_3010;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(252, 370);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(81, 39);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "         Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(129, 143);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(256, 26);
            this.txtDiachi.TabIndex = 4;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(129, 181);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(256, 26);
            this.txtSdt.TabIndex = 5;
            this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
            this.txtSdt.Leave += new System.EventHandler(this.txtSdt_Leave);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(127, 18);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(256, 26);
            this.txtHoten.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày Sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gới Tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Và Tên :";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMa,
            this.sHoten,
            this.bGioiTinh,
            this.dNgaysinh,
            this.sSdt,
            this.sDiachi,
            this.sEmail,
            this.sUser,
            this.sPass,
            this.bQuyen});
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 19);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(861, 425);
            this.dgvNhanVien.TabIndex = 2;
            // 
            // sMa
            // 
            this.sMa.DataPropertyName = "PK_iManhanvienID";
            this.sMa.HeaderText = "Mã Người Dùng";
            this.sMa.Name = "sMa";
            this.sMa.ReadOnly = true;
            this.sMa.Width = 80;
            // 
            // sHoten
            // 
            this.sHoten.DataPropertyName = "sHoten";
            this.sHoten.HeaderText = "Họ Và Tên";
            this.sHoten.Name = "sHoten";
            this.sHoten.ReadOnly = true;
            this.sHoten.Width = 120;
            // 
            // bGioiTinh
            // 
            this.bGioiTinh.DataPropertyName = "bGioitinh";
            this.bGioiTinh.HeaderText = "Giới Tính";
            this.bGioiTinh.Name = "bGioiTinh";
            this.bGioiTinh.ReadOnly = true;
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.DataPropertyName = "dNgaysinh";
            this.dNgaysinh.HeaderText = "Ngày Sinh";
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.ReadOnly = true;
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
            this.sDiachi.Width = 120;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.ReadOnly = true;
            // 
            // sUser
            // 
            this.sUser.DataPropertyName = "sUser";
            this.sUser.HeaderText = "Tên Đăng Nhập";
            this.sUser.Name = "sUser";
            this.sUser.ReadOnly = true;
            // 
            // sPass
            // 
            this.sPass.DataPropertyName = "sPass";
            this.sPass.HeaderText = "Mật Khẩu";
            this.sPass.Name = "sPass";
            this.sPass.ReadOnly = true;
            // 
            // bQuyen
            // 
            this.bQuyen.DataPropertyName = "sQuyen";
            this.bQuyen.HeaderText = "Quyền Quản Trị";
            this.bQuyen.Name = "bQuyen";
            this.bQuyen.ReadOnly = true;
            // 
            // txtTimNhanVien
            // 
            this.txtTimNhanVien.AcceptsTab = true;
            this.txtTimNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNhanVien.Location = new System.Drawing.Point(148, 22);
            this.txtTimNhanVien.Name = "txtTimNhanVien";
            this.txtTimNhanVien.Size = new System.Drawing.Size(240, 26);
            this.txtTimNhanVien.TabIndex = 5;
            this.txtTimNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimNhanVien_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tìm kiếm nhân viên:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_delete_303;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(1133, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 42);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "       Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // bntHuyTim
            // 
            this.bntHuyTim.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_3010;
            this.bntHuyTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntHuyTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuyTim.Location = new System.Drawing.Point(495, 12);
            this.bntHuyTim.Name = "bntHuyTim";
            this.bntHuyTim.Size = new System.Drawing.Size(92, 36);
            this.bntHuyTim.TabIndex = 7;
            this.bntHuyTim.Text = "         Hủy";
            this.bntHuyTim.UseVisualStyleBackColor = true;
            this.bntHuyTim.Click += new System.EventHandler(this.bntHuyTim_Click);
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_search_302;
            this.btnTimNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimNhanVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimNhanVien.Location = new System.Drawing.Point(397, 12);
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            this.btnTimNhanVien.Size = new System.Drawing.Size(92, 36);
            this.btnTimNhanVien.TabIndex = 6;
            this.btnTimNhanVien.Text = "Tìm Kiếm";
            this.btnTimNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimNhanVien.UseVisualStyleBackColor = true;
            this.btnTimNhanVien.Click += new System.EventHandler(this.btnTimNhanVien_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_update_301;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1018, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "      Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons_insert;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(904, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTimNhanVien);
            this.Controls.Add(this.bntHuyTim);
            this.Controls.Add(this.btnTimNhanVien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên - Người Dùng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.RadioButton rdoSeller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimNhanVien;
        private System.Windows.Forms.Button bntHuyTim;
        private System.Windows.Forms.Button btnTimNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn bQuyen;
        private System.Windows.Forms.Button btnXoa;
    }
}