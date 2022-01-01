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
    public partial class GUI_PhanBoNhanVien : Form
    {

        public List<PHANBONHANVIEN> ListPhanBo;
        public List<NHANVIEN> ListNhanVien;

        public GUI_PhanBoNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaDoan = txtMaDoan.Text;
            string TenNV = comboNhanVien.Text;
            string MaNV = getMaNhanVien(TenNV);
            string NhiemVu = txtNhiemVu.Text;

            if (KiemTraDuLieu() == false)
                return;

            PHANBONHANVIEN PhanBo = new PHANBONHANVIEN();
            PhanBo.MADOAN = MaDoan;
            PhanBo.MANV = MaNV;
            PhanBo.NHIEMVU = NhiemVu;

            if (PhanBo.Insert(PhanBo) == false)
            {
                MessageBox.Show("Không được phép thêm", "Thông báo");
                return;
            }
            ListPhanBo = PhanBo.GetPhanBoNhanVien(MaDoan);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListPhanBo;

            CapNhatCombo();
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
                string message = "Bạn chưa chọn để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaDoan = txtMaDoan.Text;
                string TenNV = comboNhanVien.Text;
                string MaNV = getMaNhanVien(TenNV);
                string NhiemVu = txtNhiemVu.Text;

                if (KiemTraDuLieu() == false)
                {
                    return;
                }
                string MaNVCu = dataGridView1.Rows[VT].Cells[0].Value.ToString().Trim();

                if (MaNVCu.Trim().Equals(MaNV.Trim()) == false)
                {
                    MessageBox.Show("Không được phép sửa Mã Nhân Viên", "Thông báo");
                    return;
                }

                PHANBONHANVIEN PhanBo = new PHANBONHANVIEN();
                PhanBo.MADOAN = MaDoan;
                PhanBo.MANV = MaNV;
                PhanBo.NHIEMVU = NhiemVu;

                if (PhanBo.Update(PhanBo) == false)
                {
                    MessageBox.Show("Không được phép sửa", "Thông báo");
                    return;
                }
                ListPhanBo = PhanBo.GetPhanBoNhanVien(MaDoan);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListPhanBo;

                CapNhatCombo();
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
                string message = "Bạn chưa chọn để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ListPhanBo[VT].Delete(ListPhanBo[VT]) == false)
                {
                    MessageBox.Show("Không được phép xóa", "Thông báo");
                    return;
                }

                ListPhanBo.Remove(ListPhanBo[VT]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListPhanBo;
                CapNhatCombo();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = e.RowIndex;
            string TenNV = dataGridView1.Rows[VT].Cells[1].Value.ToString();
            string NhiemVu = dataGridView1.Rows[VT].Cells[2].Value.ToString();

            comboNhanVien.Text = TenNV;
            txtNhiemVu.Text = NhiemVu;
        }

        public void formPhanBo(string MaDoan)
        {
            PHANBONHANVIEN PB = new PHANBONHANVIEN();
            NHANVIEN NV = new NHANVIEN();
            ListPhanBo = PB.GetPhanBoNhanVien(MaDoan);
            ListNhanVien = NV.getAll();
            txtMaDoan.Text = MaDoan;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListPhanBo.ToList();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MANV";
            column.Name = "Mã nhân Viên";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 170;
            column.DataPropertyName = "TENNV";
            column.Name = "Tên Nhân Viên";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 120;
            column.DataPropertyName = "NHIEMVU";
            column.Name = "Nhiệm Vụ";
            dataGridView1.Columns.Add(column);

            CapNhatCombo();
        }

        public void CapNhatCombo()
        {
            comboNhanVien.Items.Clear();
            int Trung = 0;
            foreach (NHANVIEN LoaiCP in ListNhanVien)
            {
                Trung = 0;
                string MaNV = LoaiCP.MANV;
                foreach (PHANBONHANVIEN CP in ListPhanBo)
                {
                    if (CP.MANV.Trim().Equals(MaNV.Trim()))
                    {
                        Trung = 1;
                        break;
                    }

                }
                if (Trung == 0)
                {
                    comboNhanVien.Items.Add(LoaiCP.TENNV);
                }
            }
        }

        public string getMaNhanVien(string TenNV)
        {
            foreach (NHANVIEN nv in ListNhanVien)
            {
                if (nv.TENNV.Trim().Equals(TenNV.Trim()))
                {
                    return nv.MANV;
                }
            }
            return "";
        }

        public bool KiemTraDuLieu()
        {
            string MaDoan = txtMaDoan.Text;
            string TenNV = comboNhanVien.Text;
            string MANV = getMaNhanVien(TenNV);
            string NhiemVu = txtNhiemVu.Text;

            if (NhiemVu.Equals("") || TenNV.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return false;
            }

            if (MANV.Equals(""))
            {
                MessageBox.Show("Nhân viên này không tồn tại", "Thông báo");
                return false;
            }

            return true;
        }
    }
}
