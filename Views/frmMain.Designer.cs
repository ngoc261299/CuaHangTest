namespace QuanLyCuaHangTienLoi.Views
{
    partial class frmMain
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
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grQldh = new System.Windows.Forms.GroupBox();
            this.grNcc = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grTk = new System.Windows.Forms.GroupBox();
            this.grQlnv = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            this.btnHoaDonBan = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnHangHong = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.pnlmenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grQldh.SuspendLayout();
            this.grNcc.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grTk.SuspendLayout();
            this.grQlnv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.Controls.Add(this.tabMenu);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(1329, 111);
            this.pnlmenu.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage2);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Multiline = true;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1329, 111);
            this.tabMenu.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChangePass);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblUserName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.grQldh);
            this.tabPage2.Controls.Add(this.grNcc);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.grTk);
            this.tabPage2.Controls.Add(this.grQlnv);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1321, 85);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nghiệp vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(1191, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 20);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "label1";
            this.lblUserName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1078, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xin Chào : ";
            // 
            // grQldh
            // 
            this.grQldh.Controls.Add(this.btnHoaDonNhap);
            this.grQldh.Controls.Add(this.btnHoaDonBan);
            this.grQldh.Location = new System.Drawing.Point(361, 10);
            this.grQldh.Name = "grQldh";
            this.grQldh.Size = new System.Drawing.Size(139, 79);
            this.grQldh.TabIndex = 1;
            this.grQldh.TabStop = false;
            this.grQldh.Text = "Quản Lý Hóa Đơn";
            this.grQldh.Visible = false;
            // 
            // grNcc
            // 
            this.grNcc.Controls.Add(this.btnNhaCungCap);
            this.grNcc.Location = new System.Drawing.Point(593, 10);
            this.grNcc.Name = "grNcc";
            this.grNcc.Size = new System.Drawing.Size(76, 79);
            this.grNcc.TabIndex = 5;
            this.grNcc.TabStop = false;
            this.grNcc.Text = "QL NCC";
            this.grNcc.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDangXuat);
            this.groupBox5.Location = new System.Drawing.Point(-4, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(81, 79);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hệ Thống";
            // 
            // grTk
            // 
            this.grTk.Controls.Add(this.btnThongKe);
            this.grTk.Location = new System.Drawing.Point(675, 10);
            this.grTk.Name = "grTk";
            this.grTk.Size = new System.Drawing.Size(77, 79);
            this.grTk.TabIndex = 3;
            this.grTk.TabStop = false;
            this.grTk.Text = "Thống Kê";
            this.grTk.Visible = false;
            // 
            // grQlnv
            // 
            this.grQlnv.Controls.Add(this.btnNhanVien);
            this.grQlnv.Location = new System.Drawing.Point(506, 10);
            this.grQlnv.Name = "grQlnv";
            this.grQlnv.Size = new System.Drawing.Size(81, 79);
            this.grQlnv.TabIndex = 2;
            this.grQlnv.TabStop = false;
            this.grQlnv.Text = "QL NV";
            this.grQlnv.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBanHang);
            this.groupBox1.Controls.Add(this.btnHangHong);
            this.groupBox1.Controls.Add(this.btnHangHoa);
            this.groupBox1.Controls.Add(this.btnNhapHang);
            this.groupBox1.Location = new System.Drawing.Point(83, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Hàng Hóa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_key_30;
            this.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangePass.Location = new System.Drawing.Point(1138, 42);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(114, 36);
            this.btnChangePass.TabIndex = 8;
            this.btnChangePass.Text = "Đổi Mật khẩu";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.acc1;
            this.label2.Location = new System.Drawing.Point(1162, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "     ";
            this.label2.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btnHoaDonNhap.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.billnhap;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(6, 13);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(60, 60);
            this.btnHoaDonNhap.TabIndex = 5;
            this.btnHoaDonNhap.Text = "HĐ Nhập";
            this.btnHoaDonNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHoaDonNhap.UseVisualStyleBackColor = false;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.BackColor = System.Drawing.SystemColors.Control;
            this.btnHoaDonBan.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.billban;
            this.btnHoaDonBan.Location = new System.Drawing.Point(72, 13);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Size = new System.Drawing.Size(61, 60);
            this.btnHoaDonBan.TabIndex = 2;
            this.btnHoaDonBan.Text = "HĐ Bán";
            this.btnHoaDonBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHoaDonBan.UseVisualStyleBackColor = false;
            this.btnHoaDonBan.Click += new System.EventHandler(this.btnHoaDonBan_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhaCungCap.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.ncc;
            this.btnNhaCungCap.Location = new System.Drawing.Point(6, 14);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(65, 60);
            this.btnNhaCungCap.TabIndex = 1;
            this.btnNhaCungCap.Text = "NCC";
            this.btnNhaCungCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangXuat.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.shutdown1;
            this.btnDangXuat.Location = new System.Drawing.Point(10, 16);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(65, 56);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.Control;
            this.btnThongKe.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.thongke;
            this.btnThongKe.Location = new System.Drawing.Point(6, 14);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(65, 58);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.nv;
            this.btnNhanVien.Location = new System.Drawing.Point(6, 14);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(67, 60);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnBanHang.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.banhang;
            this.btnBanHang.Location = new System.Drawing.Point(6, 13);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(60, 60);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnHangHong
            // 
            this.btnHangHong.BackColor = System.Drawing.SystemColors.Control;
            this.btnHangHong.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.hanghong1;
            this.btnHangHong.Location = new System.Drawing.Point(204, 13);
            this.btnHangHong.Name = "btnHangHong";
            this.btnHangHong.Size = new System.Drawing.Size(60, 60);
            this.btnHangHong.TabIndex = 5;
            this.btnHangHong.Text = "Hàng Hỏng";
            this.btnHangHong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHangHong.UseVisualStyleBackColor = false;
            this.btnHangHong.Click += new System.EventHandler(this.btnHangHong_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnHangHoa.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.hanghoa;
            this.btnHangHoa.Location = new System.Drawing.Point(138, 13);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(60, 60);
            this.btnHangHoa.TabIndex = 3;
            this.btnHangHoa.Text = "Hàng Hóa";
            this.btnHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHangHoa.UseVisualStyleBackColor = false;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhapHang.Image = global::QuanLyBanHangSieuThiMini.Properties.Resources.nhaphang;
            this.btnNhapHang.Location = new System.Drawing.Point(72, 13);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(60, 60);
            this.btnNhapHang.TabIndex = 1;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 657);
            this.Controls.Add(this.pnlmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Tiện Lợi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlmenu.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grQldh.ResumeLayout(false);
            this.grNcc.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.grTk.ResumeLayout(false);
            this.grQlnv.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox grTk;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox grQlnv;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.GroupBox grQldh;
        private System.Windows.Forms.Button btnHoaDonBan;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.GroupBox grNcc;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnHangHong;
        private System.Windows.Forms.Button btnHoaDonNhap;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label2;
    }
}