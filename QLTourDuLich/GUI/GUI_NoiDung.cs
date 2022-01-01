using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTourDuLich.GUI
{
    public partial class GUI_NoiDung : Form
    {

        public NOIDUNG NoiDungHienTai = new NOIDUNG();

        public GUI_NoiDung()
        {
            InitializeComponent();
        }

        public void formNoiDung(string MaDoan)
        {
            NOIDUNG NoiDung = new NOIDUNG();
            NoiDungHienTai = NoiDung.GetNoiDung(MaDoan);
            txtMaDoan.Text = MaDoan;
            if(NoiDungHienTai != null)
            {
                txtHanhTrinh.Text = NoiDungHienTai.HANHTRINH;
                txtKhachSan.Text = NoiDungHienTai.KHACHSAN;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaDoan = txtMaDoan.Text;
            string HanhTrinh = txtHanhTrinh.Text;
            string KhachSan = txtKhachSan.Text;

            NOIDUNG NoiDung = new NOIDUNG();
            NoiDung.MADOAN = MaDoan;
            NoiDung.HANHTRINH = HanhTrinh;
            NoiDung.KHACHSAN = KhachSan;

            if (KiemTraDuLieu() == false)
                return;

            if (NoiDungHienTai != null)
            {
                if(NoiDung.Update(NoiDung) == false)
                {
                    MessageBox.Show("Lỗi xử lý", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                    NoiDungHienTai = NoiDung;
                }
                
            }
            else
            {
                if (NoiDung.Insert(NoiDung) == false)
                {
                    MessageBox.Show("Lỗi xử lý", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                    NoiDungHienTai = NoiDung;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (NoiDungHienTai.Delete(NoiDungHienTai) == false)
                {
                    MessageBox.Show("Không được phép xóa", "Thông báo");
                    return;
                }
                NoiDungHienTai = null;
                txtHanhTrinh.Text = "";
                txtKhachSan.Text = "";
            }
        }

        public bool KiemTraDuLieu()
        {
            string HanhTrinh = txtHanhTrinh.Text;
            string KhachSan = txtKhachSan.Text;
            if(HanhTrinh.Equals("") || KhachSan.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return false;
            }
            return true;
        }
    }
}
