namespace QuanLyCuaHangTienLoi.Views.HangHoa
{
    partial class frmHangHong
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
            this.dgvHanghong = new System.Windows.Forms.DataGridView();
            this.sMavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaythang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grHanghong = new System.Windows.Forms.GroupBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.nmSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtMavach = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimHangHong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.btnTimHangHong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghong)).BeginInit();
            this.grHanghong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHanghong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hàng Hỏng / Lỗi";
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
            this.dgvHanghong.Location = new System.Drawing.Point(7, 30);
            this.dgvHanghong.Name = "dgvHanghong";
            this.dgvHanghong.ReadOnly = true;
            this.dgvHanghong.Size = new System.Drawing.Size(775, 426);
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
            // grHanghong
            // 
            this.grHanghong.Controls.Add(this.txtMota);
            this.grHanghong.Controls.Add(this.nmSoluong);
            this.grHanghong.Controls.Add(this.txtMavach);
            this.grHanghong.Controls.Add(this.txtTenhang);
            this.grHanghong.Controls.Add(this.btnLuu);
            this.grHanghong.Controls.Add(this.btnHuy);
            this.grHanghong.Controls.Add(this.label4);
            this.grHanghong.Controls.Add(this.label3);
            this.grHanghong.Controls.Add(this.label2);
            this.grHanghong.Controls.Add(this.label1);
            this.grHanghong.Enabled = false;
            this.grHanghong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHanghong.Location = new System.Drawing.Point(807, 67);
            this.grHanghong.Name = "grHanghong";
            this.grHanghong.Size = new System.Drawing.Size(510, 462);
            this.grHanghong.TabIndex = 4;
            this.grHanghong.TabStop = false;
            this.grHanghong.Text = "Quản lý hàng hỏng / lỗi";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(160, 172);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(309, 122);
            this.txtMota.TabIndex = 5;
            // 
            // nmSoluong
            // 
            this.nmSoluong.Location = new System.Drawing.Point(160, 124);
            this.nmSoluong.Name = "nmSoluong";
            this.nmSoluong.Size = new System.Drawing.Size(309, 26);
            this.nmSoluong.TabIndex = 4;
            // 
            // txtMavach
            // 
            this.txtMavach.AcceptsTab = true;
            this.txtMavach.Location = new System.Drawing.Point(160, 37);
            this.txtMavach.Name = "txtMavach";
            this.txtMavach.Size = new System.Drawing.Size(309, 26);
            this.txtMavach.TabIndex = 2;
            this.txtMavach.Leave += new System.EventHandler(this.txtMavach_Leave);
            // 
            // txtTenhang
            // 
            this.txtTenhang.Enabled = false;
            this.txtTenhang.Location = new System.Drawing.Point(160, 76);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(309, 26);
            this.txtTenhang.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_save_all_3017;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(204, 314);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 39);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "         Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_delete_309;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(315, 314);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 39);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "         Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô Tả :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng Hỏng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Vạch :";
            // 
            // txtTimHangHong
            // 
            this.txtTimHangHong.AcceptsTab = true;
            this.txtTimHangHong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimHangHong.Location = new System.Drawing.Point(159, 18);
            this.txtTimHangHong.Name = "txtTimHangHong";
            this.txtTimHangHong.Size = new System.Drawing.Size(280, 26);
            this.txtTimHangHong.TabIndex = 2;
            this.txtTimHangHong.TextChanged += new System.EventHandler(this.txtTimHangHong_TextChanged);
            this.txtTimHangHong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimHangHong_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm Kiếm Hàng Hỏng :";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_delete_308;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(995, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 36);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "       Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_update_303;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Location = new System.Drawing.Point(894, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 36);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "        Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons_insert3;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(795, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "       Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_refresh_3010;
            this.bntHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuy.Location = new System.Drawing.Point(571, 12);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(91, 36);
            this.bntHuy.TabIndex = 3;
            this.bntHuy.Text = "        Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // btnTimHangHong
            // 
            this.btnTimHangHong.BackgroundImage = global::QuanLyBanHangSieuThiMini.Properties.Resources.icons8_search_307;
            this.btnTimHangHong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimHangHong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHangHong.Location = new System.Drawing.Point(454, 12);
            this.btnTimHangHong.Name = "btnTimHangHong";
            this.btnTimHangHong.Size = new System.Drawing.Size(92, 36);
            this.btnTimHangHong.TabIndex = 3;
            this.btnTimHangHong.Text = "Tìm Kiếm";
            this.btnTimHangHong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimHangHong.UseVisualStyleBackColor = true;
            this.btnTimHangHong.Click += new System.EventHandler(this.btnTimHangHong_Click);
            // 
            // frmHangHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grHanghong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimHangHong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.btnTimHangHong);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmHangHong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hỏng / lỗi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghong)).EndInit();
            this.grHanghong.ResumeLayout(false);
            this.grHanghong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHanghong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grHanghong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmSoluong;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtTimHangHong;
        private System.Windows.Forms.Button btnTimHangHong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaythang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMavach;
    }
}