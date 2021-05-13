using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangTienLoi.Controls;
using System.Drawing.Printing;

namespace QuanLyCuaHangTienLoi.Views
{
    public partial class frmHoaDonNhap : Form
    {
        QuanLyHoaDonCtrl hodonCtrl = new QuanLyHoaDonCtrl();
        QuanLyNhanVienCtrl nvCtrl = new QuanLyNhanVienCtrl();

        public frmHoaDonNhap()
        {
            InitializeComponent();
            LoadHoaDonNhap();
            LoadChiTietNhap();
            dgvHoaDon.Columns["sNgaythang"].DefaultCellStyle.Format = "dd/MM/yyyy";

            DataTable dt = nvCtrl.GetData();
            cboTenNv.DataSource = dt;
            cboTenNv.DisplayMember = "sHoten";
            cboTenNv.ValueMember = "PK_iManhanvienID";
        }

        void LoadHoaDonNhap()
        {
            DataTable dt = hodonCtrl.GetDataHoaDonNhap();
            dgvHoaDon.DataSource = dt;
        }

        void LoadChiTietNhap()
        {
            DataTable dt = hodonCtrl.GetDataChiTietNhap();
            dgvChiTietNhap.DataSource = dt;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahoadon;
            Objects.HoaDonNhap hoadonnhapObj = new Objects.HoaDonNhap();

            mahoadon = dgvHoaDon.CurrentRow.Cells["sMahoadon"].Value.ToString();
            
            hoadonnhapObj.Mahoadon = int.Parse(mahoadon);

            DataTable dt = hodonCtrl.GetDataChiTietNhap_byHoaDon(hoadonnhapObj);
            dgvChiTietNhap.DataSource = dt;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();
                _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                //DialogResult result = _PrintDialog.ShowDialog();

                //if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void MenuShow(bool e)
        {
            lblTen.Visible = e;
            cboTenNv.Visible = e;
            btnTimKiemTen.Visible = e;

            lblDen.Visible = !e;
            lblTu.Visible = !e;
            dtNgayBatDau.Visible = !e;
            dtNgayKetThuc.Visible = !e;
            btnTimKiemNgay.Visible = !e;

            btnTimKiemAll.Visible = false;
        }

        private void tìmKiếmTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuShow(false);
        }

        private void tìmKiếmTheoTênNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTen.Visible = true;
            cboTenNv.Visible = true;
            btnTimKiemTen.Visible = false;

            lblDen.Visible = true;
            lblTu.Visible = true;
            dtNgayBatDau.Visible = true;
            dtNgayKetThuc.Visible = true;
            btnTimKiemNgay.Visible = false;

            btnTimKiemAll.Visible = true;
        }

        private void tìmKiếmTheoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuShow(true);
        }

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            Objects.HoaDonNhap hoadonnhapObj = new Objects.HoaDonNhap();

            hoadonnhapObj.MaNV = int.Parse(cboTenNv.SelectedValue.ToString());

            DataTable dt = hodonCtrl.GetDataHoaDonNhapByTenNV(hoadonnhapObj);
            dgvHoaDon.DataSource = dt;
        }

        string ngaybatdau, ngayketthuc;

        private void btnTimKiemNgay_Click(object sender, EventArgs e)
        {
            DateTime dtBatdau = dtNgayBatDau.Value;
            ngaybatdau = dtBatdau.ToString("dd/MM/yyyy");

            DateTime dtKetthuc = dtNgayKetThuc.Value;
            ngayketthuc = dtKetthuc.ToString("dd/MM/yyyy");

            DataTable dt = hodonCtrl.GetDataHoaDonNhapByNgayLap(ngaybatdau, ngayketthuc);
            dgvHoaDon.DataSource = dt;
        }

        private void btnTimKiemAll_Click(object sender, EventArgs e)
        {
            Objects.HoaDonNhap hodonnhapObj = new Objects.HoaDonNhap();

            hodonnhapObj.MaNV = int.Parse(cboTenNv.SelectedValue.ToString());

            DateTime dtBatdau = dtNgayBatDau.Value;
            ngaybatdau = dtBatdau.ToString("dd/MM/yyyy");

            DateTime dtKetthuc = dtNgayKetThuc.Value;
            ngayketthuc = dtKetthuc.ToString("dd/MM/yyyy");

            DataTable dt = hodonCtrl.GetDataHoaDonNhapByTenANDngay(hodonnhapObj, ngaybatdau, ngayketthuc);
            dgvHoaDon.DataSource = dt;
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            LoadHoaDonNhap();
        }

        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Siêu thị Linkmart", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Tên sản phẩm".PadRight(18) + "Số lượng".PadRight(10) + "Giá".PadRight(10) + "Thành tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            //int index = 0;
            int tongtien = 0;
            foreach (DataGridViewRow row in dgvChiTietNhap.Rows)
            {
                string item = row.Cells["sTenhang"].Value.ToString().PadRight(18) + row.Cells["sSoluong"].Value.ToString().PadRight(10) + row.Cells["sGianhap"].Value.ToString().PadRight(10) + (int.Parse(row.Cells["sGianhap"].Value.ToString()) * int.Parse(row.Cells["sSoluong"].Value.ToString())).ToString();
                graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                //graphic.DrawString(lsbProductPrice.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent   
                tongtien += int.Parse(row.Cells["sGianhap"].Value.ToString()) * int.Parse(row.Cells["sSoluong"].Value.ToString());
            }

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Total to pay ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tongtien.ToString(), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            /*offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("CASH ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudCash.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("CHANGE ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudChange.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);*/
        }
    }
}
