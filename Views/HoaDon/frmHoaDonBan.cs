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
    public partial class frmHoaDonBan : Form
    {
        QuanLyHoaDonCtrl hodonCtrl = new QuanLyHoaDonCtrl();
        QuanLyNhanVienCtrl nvCtrl = new QuanLyNhanVienCtrl();
        public frmHoaDonBan()
        {
            InitializeComponent();
            LoadHoaDonBan();
            LoadChiTietBan();
            dgvHoaDon.Columns["sNgaythang"].DefaultCellStyle.Format = "dd/MM/yyyy";

            DataTable dt = nvCtrl.GetData();
            cboTenNv.DataSource = dt;
            cboTenNv.DisplayMember = "sHoten";
            cboTenNv.ValueMember = "PK_iManhanvienID";
        }

        void LoadHoaDonBan()
        {
            DataTable dt = hodonCtrl.GetDataHoaDon();
            dgvHoaDon.DataSource = dt;
        }

        void LoadChiTietBan()
        {
            DataTable dt = hodonCtrl.GetDataChiTietBan();
            dgvChiTietBan.DataSource = dt;
        }

        string mahoadon;
        Objects.HoaDonBan hoadonbanObj = new Objects.HoaDonBan();

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mahoadon = dgvHoaDon.CurrentRow.Cells["sMahoadon"].Value.ToString();

            hoadonbanObj.Mahoadon = int.Parse(mahoadon);

            DataTable dt = hodonCtrl.GetDataChiTietBan_byHoaDon(hoadonbanObj);
            dgvChiTietBan.DataSource = dt;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("chưa in được");
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
            catch (Exception)
            {

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

        Objects.HoaDonBan hodonbanObj = new Objects.HoaDonBan();

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            hodonbanObj.Manhanvien = int.Parse(cboTenNv.SelectedValue.ToString());

            DataTable dt = hodonCtrl.GetDataHoaDonByTenNV(hodonbanObj);
            dgvHoaDon.DataSource = dt;
        }

        string ngaybatdau, ngayketthuc;

        private void btnTimKiemNgay_Click(object sender, EventArgs e)
        {
            DateTime dtBatdau = dtNgayBatDau.Value;
            ngaybatdau = dtBatdau.ToString("dd/MM/yyyy");

            DateTime dtKetthuc = dtNgayKetThuc.Value;
            ngayketthuc = dtKetthuc.ToString("dd/MM/yyyy");

            DataTable dt = hodonCtrl.GetDataHoaDonByNgayLap(ngaybatdau, ngayketthuc);
            dgvHoaDon.DataSource = dt;
        }

        private void btnTimKiemAll_Click(object sender, EventArgs e)
        {
            
            hodonbanObj.Manhanvien = int.Parse(cboTenNv.SelectedValue.ToString());

            DateTime dtBatdau = dtNgayBatDau.Value;
            ngaybatdau = dtBatdau.ToString("dd/MM/yyyy");

            DateTime dtKetthuc = dtNgayKetThuc.Value;
            ngayketthuc = dtKetthuc.ToString("dd/MM/yyyy");

            DataTable dt = hodonCtrl.GetDataHoaDonByTenANDngay(hodonbanObj, ngaybatdau, ngayketthuc);
            dgvHoaDon.DataSource = dt;
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan();
        }

        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 11);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("  Siêu thị Linkmart", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("ĐC: 627 Trương Định, Hà Nội", new Font("Courier New", 11), new SolidBrush(Color.Black), startX, startY + offset-5);
            offset = offset + (int)FontHeight+5;
            string top = "Tên sản phẩm".PadRight(18) + "SL".PadRight(8) + "Giá".PadRight(8) + "Thành tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("-----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            //int index = 0;
            int tongtien = 0;
            foreach (DataGridViewRow row in dgvChiTietBan.Rows)
            {
                string item = row.Cells["sTenhang"].Value.ToString().PadRight(18) + row.Cells["sSoluong"].Value.ToString().PadRight(8) + row.Cells["sGiaban"].Value.ToString().PadRight(8) + (int.Parse(row.Cells["sGiaban"].Value.ToString()) * int.Parse(row.Cells["sSoluong"].Value.ToString())).ToString();
                graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                //graphic.DrawString(lsbProductPrice.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent   
                tongtien += int.Parse(row.Cells["sGiaban"].Value.ToString()) * int.Parse(row.Cells["sSoluong"].Value.ToString());
            }

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Total to pay ", new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tongtien.ToString(), new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

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
