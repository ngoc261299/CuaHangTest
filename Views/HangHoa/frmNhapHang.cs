using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHangTienLoi.Views.Hàng_hóa;
using QuanLyCuaHangTienLoi.Controls;
using QuanLyCuaHangTienLoi.Objects;


namespace QuanLyCuaHangTienLoi
{
    public partial class frmNhapHang : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["QuanlyCuaHang"].ToString();

        public frmNhapHang()
        {
            InitializeComponent();
            LoadLoaiHang();
            LoadMatHang();

            QuanLyNhaCungCapCtrl qlncc = new QuanLyNhaCungCapCtrl();
            DataTable dt = qlncc.GetData();
            cboNcc.DataSource = dt;
            cboNcc.DisplayMember = "sTennhacungcap";
            cboNcc.ValueMember = "PK_iManhacungcapID";
        }

        private void LoadLoaiHang()
        {
            QuanLyLoaiHangCtrl qllh = new QuanLyLoaiHangCtrl();
            DataTable dt = qllh.GetData();
            dgvLoaiHang.DataSource = dt;
        }

        private void LoadMatHang()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "select PK_iMamathangID, sTenhang, iSoluong from tblMatHang";
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            dgvHangHoa.DataSource = dt;
        }

        string maloai;
        
        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MatHang mathangObj = new MatHang();

            maloai = dgvLoaiHang.CurrentRow.Cells[0].Value.ToString();
            mathangObj.Maloai = int.Parse(maloai);

            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cnn))
            {
                string query = "select PK_iMamathangID, sTenhang, iSoluong from tblMatHang where FK_iMaloaihangID = " + maloai;
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    try
                    {
                        cn.Open();
                        cm.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            dgvHangHoa.DataSource = dt;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            cboNcc.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboNcc.Enabled = true;
        }

        int stt = 0;
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Views.HangHoa.frmThemChiTietNhap formThemCTN = new Views.HangHoa.frmThemChiTietNhap();
            formThemCTN.ShowDialog();

            //kiểm tra số lượng và giá nhập dữ liệu không?
            if (Views.HangHoa.frmThemChiTietNhap.sl == "" || Views.HangHoa.frmThemChiTietNhap.gia == "")
            {
                return;
            }

            string mahang, tenhang, sl, gianhap;
            int thanhtien, tongtien;

            mahang = dgvHangHoa.CurrentRow.Cells["sMa"].Value.ToString();
            tenhang = dgvHangHoa.CurrentRow.Cells["sTenhang"].Value.ToString();
            sl = Views.HangHoa.frmThemChiTietNhap.sl;
            gianhap = Views.HangHoa.frmThemChiTietNhap.gia;
            thanhtien = int.Parse(sl) * int.Parse(gianhap);
            stt++;

            ListViewItem item = new ListViewItem(new string[] { stt.ToString(), mahang, tenhang, sl, gianhap, thanhtien.ToString()});
            this.lvCTN.Items.AddRange(new ListViewItem[] { item });

            tongtien = TongTien();
            txtTongtien.Text = tongtien.ToString();
        }

        int TongTien()
        {
            int tongtien = 0;
            foreach (ListViewItem item in lvCTN.Items)
            {
                tongtien += int.Parse(item.SubItems[5].Text);
            }
            return tongtien;
        }

        private void btnHuyChonLoai_Click(object sender, EventArgs e)
        {
            LoadMatHang();
        }

        private void btnHuyNhap_Click(object sender, EventArgs e)
        {
            lvCTN.Items.Clear();
            txtTongtien.Text = string.Empty;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int mancc, manv;

            mancc = int.Parse(cboNcc.SelectedValue.ToString());
            manv = int.Parse(LoginInfo.Manv);

            HoaDonNhap hoadonnhapObj = new HoaDonNhap();
            QuanLyHoaDonCtrl hoadonCtrl = new QuanLyHoaDonCtrl();

            hoadonnhapObj.MaNCC = mancc;
            hoadonnhapObj.MaNV = manv;
            try
            {
                if (hoadonnhapObj != null && lvCTN.Items.Count > 0)
                {
                    hoadonCtrl.InsertHoaDonNhap(hoadonnhapObj);
                }
                else
                {
                    MessageBox.Show("Chưa có mặt hàng để nhập");
                    return;
                }

                string mahang, sl, gianhap;

                ChiTietNhap ctnObj = new ChiTietNhap();

                for (int i = 0; i < lvCTN.Items.Count; i++)
                {
                    mahang = lvCTN.Items[i].SubItems[1].Text;
                    sl = lvCTN.Items[i].SubItems[3].Text;
                    gianhap = lvCTN.Items[i].SubItems[4].Text;

                    ctnObj.Mahang = int.Parse(mahang);
                    ctnObj.Soluong = int.Parse(sl);
                    ctnObj.Gianhap = int.Parse(gianhap);

                    if (ctnObj != null)
                    {
                        hoadonCtrl.InsertChiTietNhap(ctnObj);
                    }
                }
                if (lvCTN.Items.Count > 1)
                {
                    MessageBox.Show("Nhập hàng thàng công");
                }
                else
                {
                    MessageBox.Show("Nhập hàng thất bại");
                }
                btnHuyNhap_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
