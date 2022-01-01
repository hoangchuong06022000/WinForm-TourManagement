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
    public partial class GUI_ChiPhi : Form
    {

        public List<CHIPHI> ListChiPhi;
        public List<LOAICHIPHI> ListLoaiChiPhi;

        public GUI_ChiPhi()
        {
            InitializeComponent();
        }

        public void formChiPhi(string MaDoan)
        {
            CHIPHI cp = new CHIPHI();
            LOAICHIPHI loaiCP = new LOAICHIPHI();
            ListLoaiChiPhi = loaiCP.getAll();
            ListChiPhi = cp.getChiPhi(MaDoan);
            txtMaDoan.Text = MaDoan;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListChiPhi.ToList();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MACHIPHI";
            column.Name = "Mã Chi Phí";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 207;
            column.DataPropertyName = "TENLOAICHIPHI";
            column.Name = "Tên Chi Phí";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 85;
            column.DataPropertyName = "THANHTIEN";
            column.Name = "Số Tiền";
            dataGridView1.Columns.Add(column);

            CapNhatCombo();
        }

        public void CapNhatCombo()
        {
            comboChiPhi.Items.Clear();
            int Trung = 0;
            foreach (LOAICHIPHI LoaiCP in ListLoaiChiPhi)
            {
                Trung = 0;
                string MaChiPhi = LoaiCP.MACHIPHI;
                foreach (CHIPHI CP in ListChiPhi)
                {
                    if (CP.MACHIPHI.Trim().Equals(MaChiPhi.Trim()))
                    {
                        Trung = 1;
                        break;
                    }

                }
                if (Trung == 0)
                {
                    comboChiPhi.Items.Add(LoaiCP.TENLOAICHIPHI);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaDoan = txtMaDoan.Text;
            string TenChiPhi = comboChiPhi.Text;
            string MaChiPhi = getMaChiPhi(TenChiPhi);
            string SoTien = txtSoTien.Text;
            double ThanhTien = ChuyenChuoiThanhTien(SoTien);

            if(KiemTraDuLieu() == false)
                return;

            CHIPHI ChiPhi = new CHIPHI();
            ChiPhi.MADOAN = MaDoan;
            ChiPhi.MACHIPHI = MaChiPhi;
            ChiPhi.SOTIEN = ThanhTien;

            if (ChiPhi.Insert(ChiPhi) == false)
            {
                MessageBox.Show("Không được phép thêm", "Thông báo");
                return;
            }
            ListChiPhi = ChiPhi.getChiPhi(MaDoan);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListChiPhi;

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
                string message = "Bạn chưa chọn Chi Phí để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaDoan = txtMaDoan.Text;
                string TenChiPhi = comboChiPhi.Text;
                string MaChiPhi = getMaChiPhi(TenChiPhi);
                string SoTien = txtSoTien.Text;
                double ThanhTien = ChuyenChuoiThanhTien(SoTien);
                if (KiemTraDuLieu() == false)
                {
                    return;
                }
                string MaChiPhiCu = dataGridView1.Rows[VT].Cells[0].Value.ToString().Trim();

                if(MaChiPhiCu.Equals(MaChiPhi.Trim()) == false)
                {
                    MessageBox.Show("Không được phép sửa Mã chi phí", "Thông báo");
                    return;
                }

                CHIPHI ChiPhi = new CHIPHI();
                ChiPhi.MADOAN = MaDoan;
                ChiPhi.MACHIPHI = MaChiPhi;
                ChiPhi.SOTIEN = ThanhTien;

                if (ChiPhi.Update(ChiPhi) == false)
                {
                    MessageBox.Show("Không được phép sửa", "Thông báo");
                    return;
                }
                ListChiPhi = ChiPhi.getChiPhi(ChiPhi.MADOAN);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListChiPhi;

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
                string message = "Bạn chưa chọn Chi Phí để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ListChiPhi[VT].Delete(ListChiPhi[VT]) == false)
                {
                    MessageBox.Show("Không được phép xóa", "Thông báo");
                    return;
                }

                ListChiPhi.Remove(ListChiPhi[VT]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListChiPhi;
                CapNhatCombo();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = e.RowIndex;
            string ChiPhi = dataGridView1.Rows[VT].Cells[1].Value.ToString();
            string SoTien = dataGridView1.Rows[VT].Cells[2].Value.ToString();

            comboChiPhi.Text = ChiPhi;
            txtSoTien.Text = SoTien;
        }

        public string getMaChiPhi(string LoaiChiPhi)
        {
            foreach (LOAICHIPHI LoaiCP in ListLoaiChiPhi)
            {
                if (LoaiCP.TENLOAICHIPHI.Trim().Equals(LoaiChiPhi.Trim()))
                {
                    return LoaiCP.MACHIPHI;
                }
            }
            return "";
        }

        public double ChuyenChuoiThanhTien(string SoTien)
        {
            try
            {
                SoTien = SoTien.Replace(".", "");
                return double.Parse(SoTien);
            }
            catch (Exception d)
            {
                return -1;
            }
        }

        public bool KiemTraDuLieu()
        {
            string MaDoan = txtMaDoan.Text;
            string TenChiPhi = comboChiPhi.Text;
            string MaChiPhi = getMaChiPhi(TenChiPhi);
            string SoTien = txtSoTien.Text;
            double ThanhTien = ChuyenChuoiThanhTien(SoTien);

            if (TenChiPhi.Equals("") || SoTien.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return false;
            }

            if(MaChiPhi.Equals(""))
            {
                MessageBox.Show("Chi phí này không tồn tại", "Thông báo");
                return false;
            }

            if (ThanhTien < 0)
            {
                MessageBox.Show("Nhập sai giá trị tiền", "Thông báo");
                return false;
            }

            return true;
        }
    }
}
