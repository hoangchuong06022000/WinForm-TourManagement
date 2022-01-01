using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTourDuLich.GUI
{
    public partial class GUI_KhachHang : Form
    {
        List<KHACH> ListKhach;

        public GUI_KhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(KiemTraDuLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            string MaKH = getMaTuDong();
            string HoTen = txtHoTen.Text;
            string CMND = txtCMND.Text;
            string DiaChi = txtDiaChi.Text;
            string QuocTich = txtQuocTich.Text;
            string SDT = txtSDT.Text;
            string GioiTinh = getGioiTinh();

            KHACH Khach = new KHACH();
            Khach.MAKH = MaKH;
            Khach.HOTEN = HoTen;
            Khach.CMND = CMND;
            Khach.DIACHI = DiaChi;
            Khach.GIOITINH = GioiTinh;
            Khach.QUOCTICH = QuocTich;
            Khach.SDT = SDT;

            if (Khach.Insert(Khach) == false)
            {
                MessageBox.Show("Không thể thêm", "Thông báo");
                return;
            }

            ListKhach.Add(Khach);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListKhach;
        }

        public void LoadData()
        {
            KHACH K = new KHACH();
            ListKhach = K.GetAll();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListKhach.ToList();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MAKH";
            column.Name = "Mã";
            column.Width = 60;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 150;
            column.DataPropertyName = "HOTEN";
            column.Name = "Họ Tên";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 100;
            column.DataPropertyName = "CMND";
            column.Name = "CMND";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DIACHI";
            column.Name = "Địa Chỉ";
            column.Width = 183;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 90;
            column.DataPropertyName = "GIOITINH";
            column.Name = "Giới Tính";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 100;
            column.DataPropertyName = "SDT";
            column.Name = "SĐT";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 100;
            column.DataPropertyName = "QUOCTICH";
            column.Name = "Quốc Tịch";
            dataGridView1.Columns.Add(column);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCMND.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtQuocTich.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            if(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("Nam"))
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
        }

        private string getGioiTinh()
        {
            if(rdNam.Checked == true)
                return "Nam";
            if(rdNu.Checked == true)
                return "Nữ";
            return "";
        }

        private bool KiemTraDuLieu()
        {
            string HoTen = txtHoTen.Text;
            string CMND = txtCMND.Text;
            string DiaChi = txtDiaChi.Text;
            string QuocTich = txtQuocTich.Text;
            string SDT = txtSDT.Text;

            if (HoTen.Equals("") || CMND.Equals("") || DiaChi.Equals("") || QuocTich.Equals("") || SDT.Equals(""))
                return false;

            if (getGioiTinh().Equals(""))
                return false;

            return true;
        }

        private string getMaTuDong()
        {
            string Ma = "";
            int So = 0;
            string MaKH = ListKhach[ListKhach.Count - 1].MAKH;
            Ma = MaKH.Substring(0, 2);
            string[] split = MaKH.Split('H');
            So = int.Parse(split[1]);
            So++;
            if (So < 10)
                Ma += "0" + So;
            else
                Ma += So;
            return Ma;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int VT = 0;
            try
            {
                VT = dataGridView1.CurrentCell.RowIndex;
            }
            catch (Exception ex)
            {
                string message = "Bạn chưa chọn Khách hàng để sửa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }

            if (KiemTraDuLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaKH = dataGridView1.Rows[VT].Cells[0].Value.ToString();
                KHACH KH = new KHACH();
                KHACH KhachCu = new KHACH();

                foreach (KHACH Khach in ListKhach)
                {
                    if (Khach.MAKH.Trim().Equals(MaKH.Trim()))
                    {
                        KhachCu = Khach;
                        KH = Khach;
                        break;
                    }
                }

                string HoTen = txtHoTen.Text;
                string CMND = txtCMND.Text;
                string DiaChi = txtDiaChi.Text;
                string QuocTich = txtQuocTich.Text;
                string SDT = txtSDT.Text;
                string GioiTinh = getGioiTinh();
                KH.HOTEN = HoTen;
                KH.CMND = CMND;
                KH.GIOITINH = GioiTinh;
                KH.SDT = SDT;
                KH.QUOCTICH = QuocTich;
                KH.DIACHI = DiaChi;

                if (Regex.IsMatch(CMND, "^\\d{12}$") == false)
                {
                    MessageBox.Show("Nhập sai số CMND", "Thông báo");
                    return;
                }

                if (Regex.IsMatch(SDT, "^(0\\d{9})$") == false)
                {
                    MessageBox.Show("Nhập sai số điện thoại", "Thông báo");
                    return;
                }

                if (KH.Update(KH) == false)
                {
                    MessageBox.Show("Không thể chỉnh sửa", "Thông báo");
                    return;
                }

                ListKhach.Remove(KhachCu);
                ListKhach.Add(KH);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListKhach;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int VT = 0;
            try
            {
                VT = dataGridView1.CurrentCell.RowIndex;
            }
            catch (Exception ex)
            {
                string message = "Bạn chưa chọn Khách Hàng để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaKH = dataGridView1.Rows[VT].Cells[0].Value.ToString();

                KHACH KH = new KHACH();

                foreach (KHACH Khach in ListKhach)
                {
                    if (Khach.MAKH.Trim().Equals(MaKH.Trim()))
                    {
                        KH = Khach;
                        break;
                    }
                }


                if (KH.Delete(KH) == false)
                {
                    MessageBox.Show("Không thể xóa", "Thông báo");
                    return;
                }

                ListKhach.Remove(KH);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListKhach;
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string CMND = txtTimKiemCMND.Text;
            string HoTen = txtTimKiemHoTen.Text;
            string SDT = txtTimKiemSDT.Text;

            List<KHACH> ListTimKiemKhachHang = new List<KHACH>();
            if (HoTen.Equals("") == false)
            {
                foreach (KHACH k in ListKhach)
                {
                    if (k.HOTEN.ToLower().Contains(HoTen.ToLower()))
                        ListTimKiemKhachHang.Add(k);
                }
                if (ListTimKiemKhachHang.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả", "Thông báo");
                    return;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListTimKiemKhachHang;
                return;
            }

            if (CMND.Equals("") == false)
            {
                foreach (KHACH k in ListKhach)
                {
                    if (k.CMND.ToLower().Equals(CMND.ToLower()))
                        ListTimKiemKhachHang.Add(k);
                }
                if (ListTimKiemKhachHang.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả", "Thông báo");
                    return;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListTimKiemKhachHang;
                return;
            }

            if (SDT.Equals("") == false)
            {
                foreach (KHACH k in ListKhach)
                {
                    if (k.SDT.ToLower().Equals(SDT.ToLower()))
                        ListTimKiemKhachHang.Add(k);
                }
                if (ListTimKiemKhachHang.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả", "Thông báo");
                    return;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListTimKiemKhachHang;
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListKhach;
        }
    }
}
