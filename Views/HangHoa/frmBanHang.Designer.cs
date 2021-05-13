namespace QuanLyCuaHangTienLoi.Views
{
    partial class frmBanHang
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
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienphaitra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lvCTB = new System.Windows.Forms.ListView();
            this.sStt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sTenhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sDonvitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sGiaban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sThanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sMahang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSoluong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTientralai = new System.Windows.Forms.TextBox();
            this.txtNhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.txtMavach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTienkhachdua = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTienphaitra);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lvCTB);
            this.groupBox2.Controls.Add(this.lblSoluong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(531, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 510);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hàng Sẽ Bán";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Enabled = false;
            this.txtThanhtien.Location = new System.Drawing.Point(550, 416);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(194, 26);
            this.txtThanhtien.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(427, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Thành Tiền:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Location = new System.Drawing.Point(139, 416);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.ReadOnly = true;
            this.txtGiamGia.Size = new System.Drawing.Size(194, 26);
            this.txtGiamGia.TabIndex = 9;
            this.txtGiamGia.Text = "0";
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Giảm Giá (%) :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(139, 448);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(194, 26);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "0";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Thuế :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTienphaitra
            // 
            this.txtTienphaitra.Enabled = false;
            this.txtTienphaitra.Location = new System.Drawing.Point(139, 479);
            this.txtTienphaitra.Name = "txtTienphaitra";
            this.txtTienphaitra.ReadOnly = true;
            this.txtTienphaitra.Size = new System.Drawing.Size(194, 26);
            this.txtTienphaitra.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tiền Phải Trả :";
            // 
            // lvCTB
            // 
            this.lvCTB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sStt,
            this.sTenhang,
            this.sSoluong,
            this.sDonvitinh,
            this.sGiaban,
            this.sThanhtien,
            this.sMahang});
            this.lvCTB.FullRowSelect = true;
            this.lvCTB.GridLines = true;
            this.lvCTB.HideSelection = false;
            this.lvCTB.Location = new System.Drawing.Point(13, 28);
            this.lvCTB.MultiSelect = false;
            this.lvCTB.Name = "lvCTB";
            this.lvCTB.Scrollable = false;
            this.lvCTB.Size = new System.Drawing.Size(731, 373);
            this.lvCTB.TabIndex = 0;
            this.lvCTB.UseCompatibleStateImageBehavior = false;
            this.lvCTB.View = System.Windows.Forms.View.Details;
            // 
            // sStt
            // 
            this.sStt.Text = "STT";
            this.sStt.Width = 35;
            // 
            // sTenhang
            // 
            this.sTenhang.Text = "Tên Hàng Hóa";
            this.sTenhang.Width = 188;
            // 
            // sSoluong
            // 
            this.sSoluong.Text = "Số Lượng Bán";
            this.sSoluong.Width = 114;
            // 
            // sDonvitinh
            // 
            this.sDonvitinh.Text = "Đơn Vị Tính";
            this.sDonvitinh.Width = 124;
            // 
            // sGiaban
            // 
            this.sGiaban.Text = "Giá Bán";
            this.sGiaban.Width = 141;
            // 
            // sThanhtien
            // 
            this.sThanhtien.Text = "Thành Tiền";
            this.sThanhtien.Width = 121;
            // 
            // sMahang
            // 
            this.sMahang.Text = "Mã Hàng";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(555, 455);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(17, 19);
            this.lblSoluong.TabIndex = 8;
            this.lblSoluong.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Lượng Hàng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền Khách Đưa :";
            // 
            // txtTientralai
            // 
            this.txtTientralai.Enabled = false;
            this.txtTientralai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTientralai.Location = new System.Drawing.Point(207, 356);
            this.txtTientralai.Name = "txtTientralai";
            this.txtTientralai.ReadOnly = true;
            this.txtTientralai.Size = new System.Drawing.Size(194, 26);
            this.txtTientralai.TabIndex = 3;
            // 
            // txtNhanvien
            // 
            this.txtNhanvien.Enabled = false;
            this.txtNhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanvien.Location = new System.Drawing.Point(207, 231);
            this.txtNhanvien.Name = "txtNhanvien";
            this.txtNhanvien.ReadOnly = true;
            this.txtNhanvien.Size = new System.Drawing.Size(194, 26);
            this.txtNhanvien.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Lập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 20;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numSL
            // 
            this.numSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSL.Location = new System.Drawing.Point(367, 152);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(39, 26);
            this.numSL.TabIndex = 2;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMavach
            // 
            this.txtMavach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMavach.Location = new System.Drawing.Point(207, 152);
            this.txtMavach.Name = "txtMavach";
            this.txtMavach.Size = new System.Drawing.Size(148, 26);
            this.txtMavach.TabIndex = 1;
            this.txtMavach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMavach_KeyDown);
            this.txtMavach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMavach_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cửa Hàng Tiện Lợi HoaMart";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(126, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 20;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã Vạch:";
            // 
            // txtNgaylap
            // 
            this.txtNgaylap.Enabled = false;
            this.txtNgaylap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaylap.Location = new System.Drawing.Point(207, 189);
            this.txtNgaylap.Name = "txtNgaylap";
            this.txtNgaylap.Size = new System.Drawing.Size(194, 26);
            this.txtNgaylap.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(90, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tiền Trả Lại :";
            // 
            // txtTienkhachdua
            // 
            this.txtTienkhachdua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienkhachdua.Location = new System.Drawing.Point(207, 321);
            this.txtTienkhachdua.Name = "txtTienkhachdua";
            this.txtTienkhachdua.Size = new System.Drawing.Size(194, 26);
            this.txtTienkhachdua.TabIndex = 4;
            this.txtTienkhachdua.Leave += new System.EventHandler(this.txtTienkhachdua_Leave);
            // 
            // btnIn
            // 
            this.btnIn.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_save_all_3018;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(172, 421);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(118, 40);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "        In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_3010;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(329, 421);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 40);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "      Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.add12;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(435, 148);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 28);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "      Nhập";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 543);
            this.ControlBox = false;
            this.Controls.Add(this.txtNgaylap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTientralai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNhanvien);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTienkhachdua);
            this.Controls.Add(this.txtMavach);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvCTB;
        private System.Windows.Forms.ColumnHeader sTenhang;
        private System.Windows.Forms.ColumnHeader sSoluong;
        private System.Windows.Forms.ColumnHeader sDonvitinh;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTientralai;
        private System.Windows.Forms.TextBox txtNhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader sGiaban;
        private System.Windows.Forms.ColumnHeader sThanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.TextBox txtMavach;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTienphaitra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtNgaylap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader sStt;
        private System.Windows.Forms.TextBox txtTienkhachdua;
        private System.Windows.Forms.ColumnHeader sMahang;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label label2;
    }
}