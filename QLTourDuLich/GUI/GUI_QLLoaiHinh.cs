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
    public partial class GUI_QLLoaiHinh : Form
    {

        public List<LOAIHINHDULICH> ListLoaiHinh;

        public GUI_QLLoaiHinh()
        {
            InitializeComponent();
            LoadData();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KiemTraDuLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if(KiemTraMa() == false)
            {
                MessageBox.Show("Mã loại hình này đã tồn tại", "Thông báo");
                return;
            }
            string MaLoaiHinh = txtMaLoaiHinh.Text;
            string TenLoaiHinh = txtTenLoaiHinh.Text;
            LOAIHINHDULICH LoaiHinh = new LOAIHINHDULICH();
            LoaiHinh.MALOAIHINH = MaLoaiHinh;
            LoaiHinh.TENLOAIHINH = TenLoaiHinh;
            if(LoaiHinh.Insert(LoaiHinh) == false)
            {
                MessageBox.Show("Lỗi kết nối CSDL", "Thông báo");
                return;
            }

            ListLoaiHinh.Add(LoaiHinh);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListLoaiHinh;
        }

        public void LoadData()
        {
            LOAIHINHDULICH LH = new LOAIHINHDULICH();
            ListLoaiHinh = LH.GetAll();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListLoaiHinh.ToList();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MALOAIHINH";
            column.Name = "Mã Loại Hình";
            column.Width = 130;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 300;
            column.DataPropertyName = "TENLOAIHINH";
            column.Name = "Tên Loại Hình";
            dataGridView1.Columns.Add(column);
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
                string message = "Bạn chưa chọn Loại Hình để sửa";
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
                string MaLoaiHinhCu = dataGridView1.Rows[VT].Cells[0].Value.ToString();
                string TenLoaiHinhCu = dataGridView1.Rows[VT].Cells[1].Value.ToString();
                LOAIHINHDULICH LoaiHinhCu = new LOAIHINHDULICH();
                LoaiHinhCu.MALOAIHINH = MaLoaiHinhCu;
                LoaiHinhCu.TENLOAIHINH = TenLoaiHinhCu;

                string MaLoaiHinhMoi = txtMaLoaiHinh.Text;
                string TenLoaiHinhMoi = txtTenLoaiHinh.Text;
                LOAIHINHDULICH LoaiHinhMoi = new LOAIHINHDULICH();
                LoaiHinhMoi.MALOAIHINH = MaLoaiHinhMoi;
                LoaiHinhMoi.TENLOAIHINH = TenLoaiHinhMoi;

                if (LoaiHinhMoi.Update(LoaiHinhCu, LoaiHinhMoi) == false)
                {
                    MessageBox.Show("Lỗi kết nối CSDL", "Thông báo");
                    return;
                }

                foreach (LOAIHINHDULICH Loai in ListLoaiHinh)
                {
                    if (Loai.MALOAIHINH.Trim().Equals(MaLoaiHinhCu.Trim()))
                    {
                        LoaiHinhCu = Loai;
                    }
                }

                ListLoaiHinh.Remove(LoaiHinhCu);
                ListLoaiHinh.Add(LoaiHinhMoi);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListLoaiHinh;
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
                string message = "Bạn chưa chọn Loại Hình để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaLoaiHinh = dataGridView1.Rows[VT].Cells[0].Value.ToString();
                string TenLoaiHinh = dataGridView1.Rows[VT].Cells[1].Value.ToString();
                LOAIHINHDULICH LoaiHinh = new LOAIHINHDULICH();
                LoaiHinh.MALOAIHINH = MaLoaiHinh;
                LoaiHinh.TENLOAIHINH = TenLoaiHinh;

                if (LoaiHinh.Delete(LoaiHinh) == false)
                {
                    MessageBox.Show("Lỗi kết nối CSDL", "Thông báo");
                    return;
                }

                foreach (LOAIHINHDULICH Loai in ListLoaiHinh)
                {
                    if (Loai.MALOAIHINH.Trim().Equals(MaLoaiHinh.Trim()))
                    {
                        LoaiHinh = Loai;
                    }
                }


                ListLoaiHinh.Remove(LoaiHinh);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListLoaiHinh;
            }
        }

        public bool KiemTraDuLieu()
        {
            string MaLoaiHinh = txtMaLoaiHinh.Text;
            string TenLoaiHinh = txtTenLoaiHinh.Text;
            if(MaLoaiHinh.Equals("") || TenLoaiHinh.Equals(""))
            {
                return false;
            }
            return true;
        }

        public bool KiemTraMa()
        {
            string MaLoaiHinh = txtMaLoaiHinh.Text;
            foreach (LOAIHINHDULICH Loai in ListLoaiHinh)
            {
                if (Loai.MALOAIHINH.Trim().Equals(MaLoaiHinh.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             txtMaLoaiHinh.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
             txtTenLoaiHinh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
