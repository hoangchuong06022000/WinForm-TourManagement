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
    public partial class GUI_ChiTietDoan : Form
    {

        public List<KHACH> ListKhachHang;
        public List<CHITIETDOAN> ListChiTietDoan;
        public List<GIATOUR> ListGiaTour;
        public KHACH Khach = new KHACH();
        public CHITIETDOAN ct = new CHITIETDOAN();
        public GIATOUR G = new GIATOUR();
        public DOANDULICH DoanDuLichHienTai;

        public GUI_ChiTietDoan()
        {
            InitializeComponent();
        }

        public void formChiTiet(DOANDULICH Doan)
        {
            DoanDuLichHienTai = Doan;

            txtMaDoan.Text = Doan.MADOAN;
            txtMaTour.Text = Doan.MATOUR;
            ListKhachHang = Khach.GetAll();
            ListChiTietDoan = ct.getChiTietDoan(Doan.MADOAN);
            ListGiaTour = G.GetGiaTour(Doan.MATOUR);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListChiTietDoan;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Width = 70;
            column.DataPropertyName = "MAKH";
            column.Name = "Mã KH";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 150;
            column.DataPropertyName = "TENKHACHHANG";
            column.Name = "Khách Hàng";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 150;
            column.DataPropertyName = "VAITROKH";
            column.Name = "Vai Trò";
            dataGridView1.Columns.Add(column);

            LoadComboKH();
            foreach (GIATOUR G in ListGiaTour)
            {
                comboGia.Items.Add(G.GIATIEN);
            }
            comboGia.SelectedIndex = 0;
        }

        private bool KiemTraDuLieu()
        {
            string MaTour = txtMaTour.Text;
            string MaDoan = txtMaDoan.Text;
            string MaKH = comboKhachHang.Text;
            string Gia = comboGia.Text;
            string VaiTro = txtVaiTro.Text;

            if (MaTour.Equals("") || MaDoan.Equals("") || MaKH.Equals("") || Gia.Equals("") || VaiTro.Equals(""))
                return false;

            return true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            int trung = 0;
            foreach(GIATOUR G in ListGiaTour)
            {
                if (comboGia.Text.Equals(G.GIATIEN))
                {
                    trung = 1;
                    break;
                }
            }
            if(trung == 0)
            {
                MessageBox.Show("Giá này không tồn tại", "Thông báo");
                return;
            }

            CHITIETDOAN CTDoan = new CHITIETDOAN();
            string MaDoan = txtMaDoan.Text;
            string VaiTro = txtVaiTro.Text;
            string MaKH = comboKhachHang.Text;
            double Gia = double.Parse(comboGia.Text);

            CTDoan.MAKH = MaKH;
            CTDoan.MADOAN = MaDoan;
            CTDoan.VAITROKH = VaiTro;

            if (ct.Insert(CTDoan) == false)
            {
                MessageBox.Show("Không được phép thêm", "Thông báo lỗi");
                return;
            }
            ListChiTietDoan = ct.getChiTietDoan(DoanDuLichHienTai.MADOAN);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListChiTietDoan;

            double DoanhThu = 0;
            DoanhThu = ListChiTietDoan.Count * Gia;
            DoanDuLichHienTai.DOANHTHU = DoanhThu;

            DoanDuLichHienTai.Update(DoanDuLichHienTai);

            LoadComboKH();
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
                string message = "Bạn chưa chọn Chi tiết đoàn để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ListChiTietDoan[VT].Delete(ListChiTietDoan[VT]) == false)
                {
                    MessageBox.Show("Không được phép xóa", "Thông báo");
                    return;
                }

                ListChiTietDoan.Remove(ListChiTietDoan[VT]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListChiTietDoan;

                double Gia = double.Parse(comboGia.Text);
                double DoanhThu = 0;
                DoanhThu = ListChiTietDoan.Count * Gia;
                DoanDuLichHienTai.DOANHTHU = DoanhThu;
                DoanDuLichHienTai.Update(DoanDuLichHienTai);

                LoadComboKH();
            }
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
                string message = "Bạn chưa chọn Chi tiết đoàn để sửa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CHITIETDOAN CTDoan = new CHITIETDOAN();
                string MaDoan = txtMaDoan.Text;
                string VaiTro = txtVaiTro.Text;
                string MaKH = comboKhachHang.Text;

                if (KiemTraDuLieu() == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }

                int trung = 0;
                foreach (GIATOUR G in ListGiaTour)
                {
                    if (comboGia.Text.Equals(G.GIATIEN))
                    {
                        trung = 1;
                        break;
                    }
                }
                if (trung == 0)
                {
                    MessageBox.Show("Giá này không tồn tại", "Thông báo");
                    return;
                }

                CTDoan.MADOAN = MaDoan;
                CTDoan.MAKH = MaKH;
                CTDoan.VAITROKH = VaiTro;

                if (ct.Update(CTDoan) == false)
                {
                    MessageBox.Show("Không được phép sửa", "Thông báo lỗi");
                    return;
                }
            }

            ListChiTietDoan = ct.getChiTietDoan(DoanDuLichHienTai.MADOAN);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListChiTietDoan;

            double Gia = double.Parse(comboGia.Text);
            double DoanhThu = 0;
            DoanhThu = ListChiTietDoan.Count * Gia;
            DoanDuLichHienTai.DOANHTHU = DoanhThu;
            DoanDuLichHienTai.Update(DoanDuLichHienTai);

            LoadComboKH();
        }

        public void LoadComboKH()
        {
            comboKhachHang.Items.Clear();
            int Trung = 0;
            foreach (KHACH K in ListKhachHang)
            {
                Trung = 0;
                string MaKhach = K.MAKH;
                foreach (CHITIETDOAN ChiTiet in ListChiTietDoan)
                {
                    if (K.MAKH.Trim().Equals(ChiTiet.MAKH.Trim()))
                    {
                        Trung = 1;
                        break;
                    }

                }
                if (Trung == 0)
                {
                    comboKhachHang.Items.Add(MaKhach);
                }
            }
            comboKhachHang.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = e.RowIndex;
            string MaKH = dataGridView1.Rows[VT].Cells[0].Value.ToString();
            string VaiTro = dataGridView1.Rows[VT].Cells[2].Value.ToString();

            comboKhachHang.Text = MaKH;
            txtVaiTro.Text = VaiTro;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            GUI_KhachHang frameKH = new GUI_KhachHang();
            frameKH.ShowDialog();
        }
    }    
}
