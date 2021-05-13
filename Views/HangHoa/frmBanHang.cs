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
using QuanLyCuaHangTienLoi.Objects;
using System.Drawing.Printing;

namespace QuanLyCuaHangTienLoi.Views
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            LoadNV();
            txtMavach.Focus();
        }
        
        void LoadNV()
        {
            Objects.NhanVien nvObj = new Objects.NhanVien();
            DangNhapCtrl dangnhap = new DangNhapCtrl();

            DataTable dt = new DataTable();
            nvObj.Username = LoginInfo.UserName;
            dt = dangnhap.GetDataByUser(nvObj);

            foreach (DataRow row in dt.Rows)
            {
                LoginInfo.Manv = row["PK_iManhanvienID"].ToString();
                txtNhanvien.Text = row["sHoten"].ToString();
                break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtMavach.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã vạch!");
            }
             else if (int.Parse(numSL.Value.ToString()) > 0)
            {
                getMatHangByMaVach();
                BindingDataLvCTB();
                txtMavach.Text = string.Empty;
                numSL.Value = 1;
            } else
            {
                MessageBox.Show("Mặt hàng vừa nhập chưa có số lượng");
            }
            
        }

        private void txtMavach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);
            }
        }

        DataTable GetMatHangByMaVach()
        {
            Objects.MatHang mathangObj = new Objects.MatHang();
            QuanLyMatHangCtrl mathangCtrl = new QuanLyMatHangCtrl();

            mathangObj.Mavach = txtMavach.Text.Trim();
            DataTable dt = mathangCtrl.GetDataByMaVach(mathangObj);

            return dt;
        }

        int STT = 0;
        void getMatHangByMaVach()
        {
            string tenhang, donvitinh, mahang;
            int soluong, giaban, thanhtien;
            

            if (txtMavach.Text.Trim() != "")
            {
                DataTable dt = GetMatHangByMaVach();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("không có mặt hàng có mã " + txtMavach.Text.Trim());
                    return;
                }
                
                for (int i = 0; i < lvCTB.Items.Count; i++)
                {
                    if (lvCTB.Items[i].SubItems[1].Text == dt.Rows[0]["sTenhang"].ToString())
                    {
                        lvCTB.Items[i].SubItems[2].Text = (int.Parse(lvCTB.Items[i].SubItems[2].Text) + Convert.ToInt16(numSL.Value.ToString())).ToString();
                        lvCTB.Items[i].SubItems[5].Text = (int.Parse(lvCTB.Items[i].SubItems[2].Text) * int.Parse(lvCTB.Items[i].SubItems[4].Text)).ToString();
                        STT++;
                        return;
                    }
                    
                }
                mahang = dt.Rows[0]["PK_iMamathangID"].ToString();
                tenhang = dt.Rows[0]["sTenhang"].ToString();
                soluong = Convert.ToInt16(numSL.Value.ToString());
                donvitinh = dt.Rows[0]["sDonvitinh"].ToString();
                giaban = int.Parse(dt.Rows[0]["dGiaban"].ToString());
                thanhtien = soluong * giaban;
                STT++;

                ListViewItem item = new ListViewItem(new string[] { STT.ToString(), tenhang, soluong.ToString(), donvitinh, giaban.ToString(), thanhtien.ToString(), mahang.ToString() });
                this.lvCTB.Items.AddRange(new ListViewItem[] { item });
            }
        }

        void BindingDataLvCTB()
        {
            int tongtien = 0;
            tongtien = TinhTongTien();

            lblSoluong.Text = STT.ToString();
            txtThanhtien.Text = tongtien.ToString();
            if (int.Parse(txtGiamGia.Text) > 0)
            {
                int tienphaitra = tongtien * 100 / int.Parse(txtGiamGia.Text);
                txtTienphaitra.Text = tienphaitra.ToString();
            }
            else
            {
                txtTienphaitra.Text = txtThanhtien.Text;
            }
        }

        int TinhTongTien()
        {
            int tongtien = 0;
            foreach (ListViewItem lvItem in lvCTB.Items)
            {
                tongtien += int.Parse(lvItem.SubItems[5].Text);
            }
            return tongtien;
        }

        bool InsertHoaDonBan()
        {
            QuanLyHoaDonCtrl hoadonCtrl = new QuanLyHoaDonCtrl();
            if (LoginInfo.Manv != "")
            {
                hoadonCtrl.InsertHoaDonBan();
                return true;
            }
            return false;
        }

        void InsertChiTietBan(ChiTietBan ctbObj)
        {
            QuanLyHoaDonCtrl hoadonCtrl = new QuanLyHoaDonCtrl();
            for (int i = 0; i < lvCTB.Items.Count; i++)
            {
                ctbObj.Mamathang = int.Parse(lvCTB.Items[i].SubItems[6].Text);
                ctbObj.Soluong = int.Parse(lvCTB.Items[i].SubItems[2].Text);
                ctbObj.Giaban = lvCTB.Items[i].SubItems[4].Text;

                hoadonCtrl.InsertChiTietBan(ctbObj);
            }
        }

        private void txtTienkhachdua_Leave(object sender, EventArgs e)
        {
            if (txtTienphaitra.Text != "" && txtTienkhachdua.Text.Trim() != "")
            {
                int tientralai = int.Parse(txtTienkhachdua.Text.Trim()) - int.Parse(txtTienphaitra.Text.Trim());
                txtTientralai.Text = tientralai.ToString();
            }
        }

        private void txtTienkhachdua_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("ádfasdf");
        }

        private void txtMavach_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMavach.Text.Length == 13)
            {
                btnOk_Click(sender, e);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("chưa in được");
            if(lvCTB.Items.Count < 1)
            {
                MessageBox.Show("Chưa có mặt hàng để thanh toán!");
                return;
            }
            try
            {
                InsertHoaDonBan();
                ChiTietBan ctbObj = new ChiTietBan();
                InsertChiTietBan(ctbObj);

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
                LoginInfo.Tien += int.Parse(txtTienphaitra.Text.Trim());
                btnHuy_Click(sender, e);
            }
            catch (Exception)
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lvCTB.Items.Clear();
            txtMavach.Text = string.Empty;
            txtTienkhachdua.Text = string.Empty;
            txtTientralai.Text = string.Empty;
            txtTienphaitra.Text = string.Empty;
            txtThanhtien.Text = string.Empty;
            lblSoluong.Text = "0";
            STT =0;
            numSL.Value = 1;
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
            graphic.DrawString("ĐC: 627 Trương Định, Hà Nội", new Font("Courier New", 11), new SolidBrush(Color.Black), startX, startY + offset - 5);
            offset = offset + (int)FontHeight + 5;
            string top = "Tên sản phẩm".PadRight(18) + "SL".PadRight(8) + "Giá".PadRight(5) + "Thành tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("-----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            //int index = 0;
            int tongtien = 0;
            foreach (ListViewItem lvItem in lvCTB.Items)
            {
                string item = lvItem.SubItems[1].Text.PadRight(18) + lvItem.SubItems[2].Text.PadRight(8) + lvItem.SubItems[4].Text.PadRight(8) + lvItem.SubItems[5].Text;
                graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                //graphic.DrawString(lsbProductPrice.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent   
                tongtien += int.Parse(lvItem.SubItems[5].Text);
            }

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Tổng Tiền :", new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tongtien.ToString(), new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);
            offset = offset + (int)FontHeight + 5;
            
            graphic.DrawString("Tiền khách đưa :", new Font("Courier New", 11), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(txtTienkhachdua.Text.Trim(), new Font("Courier New", 11), new SolidBrush(Color.Black), startX + 250, startY + offset);
            offset = offset + (int)FontHeight + 5;

            graphic.DrawString("Tiền trả lại :", new Font("Courier New", 11), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(txtTientralai.Text.Trim(), new Font("Courier New", 11), new SolidBrush(Color.Black), startX + 250, startY + offset);
            offset = offset + (int)FontHeight + 15;

            /*offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("CASH ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudCash.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("CHANGE ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudChange.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent */
            graphic.DrawString("   Cám Ơn Quý Khách", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" Hân hạnh được phục vụ!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
