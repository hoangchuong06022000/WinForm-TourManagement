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
    public partial class GUI_QLDIADIEM : Form
    {

        public List<DIADIEM> ListDiaDiem;

        public GUI_QLDIADIEM()
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
                MessageBox.Show("Mã Địa Điểm này đã tồn tại", "Thông báo");
                return;
            }
            string MaDiaDiem = txtMaDiaDiem.Text;
            string TenDiaDiem = txtTenDiaDiem.Text;
            DIADIEM DiaDiem = new DIADIEM();
            DiaDiem.MADIADIEM = MaDiaDiem;
            DiaDiem.TENDIADIEM = TenDiaDiem;
            if(DiaDiem.Insert(DiaDiem) == false)
            {
                MessageBox.Show("Lỗi kết nối CSDL", "Thông báo");
                return;
            }

            ListDiaDiem.Add(DiaDiem);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListDiaDiem;
        }

        public void LoadData()
        {
            DIADIEM DiaDiem = new DIADIEM();
            ListDiaDiem = DiaDiem.GetAll();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListDiaDiem.ToList();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MADIADIEM";
            column.Name = "Mã Địa Điểm";
            column.Width = 130;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 300;
            column.DataPropertyName = "TENDIADIEM";
            column.Name = "Tên Địa Điểm";
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
                string message = "Bạn chưa chọn Địa Điểm để sửa";
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
                string MaDiaDiemCu = dataGridView1.Rows[VT].Cells[0].Value.ToString();
                string TenDiaDiemCu = dataGridView1.Rows[VT].Cells[1].Value.ToString();
                DIADIEM DiaDiemCu = new DIADIEM();
                DiaDiemCu.MADIADIEM = MaDiaDiemCu;
                DiaDiemCu.TENDIADIEM = TenDiaDiemCu;

                string MaDiaDiemMoi = txtMaDiaDiem.Text;
                string TenDiaDiemMoi = txtTenDiaDiem.Text;
                DIADIEM DiaDiemMoi = new DIADIEM();
                DiaDiemMoi.MADIADIEM = MaDiaDiemMoi;
                DiaDiemMoi.TENDIADIEM = TenDiaDiemMoi;

                if (DiaDiemMoi.Update(DiaDiemCu, DiaDiemMoi) == false)
                {
                    MessageBox.Show("Lỗi kết nối CSDL", "Thông báo");
                    return;
                }

                foreach (DIADIEM DD in ListDiaDiem)
                {
                    if (DD.MADIADIEM.Trim().Equals(MaDiaDiemCu.Trim()))
                    {
                        DiaDiemCu = DD;
                    }
                }

                ListDiaDiem.Remove(DiaDiemCu);
                ListDiaDiem.Add(DiaDiemMoi);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListDiaDiem;
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
                string message = "Bạn chưa chọn Địa Điểm để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaDiaDiem = dataGridView1.Rows[VT].Cells[0].Value.ToString();
                string TenDiaDiem = dataGridView1.Rows[VT].Cells[1].Value.ToString();
                DIADIEM DiaDiem = new DIADIEM();
                DiaDiem.MADIADIEM = MaDiaDiem;
                DiaDiem.TENDIADIEM = TenDiaDiem;

                if (DiaDiem.Delete(DiaDiem) == false)
                {
                    MessageBox.Show("Lỗi kết nối CSDL", "Thông báo");
                    return;
                }

                foreach (DIADIEM DD in ListDiaDiem)
                {
                    if (DD.MADIADIEM.Trim().Equals(MaDiaDiem.Trim()))
                    {
                        DiaDiem = DD;
                    }
                }


                ListDiaDiem.Remove(DiaDiem);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListDiaDiem;
            }
        }

        public bool KiemTraDuLieu()
        {
            string MaDiaDiem = txtMaDiaDiem.Text;
            string TenDiaDiem = txtTenDiaDiem.Text;
            if(MaDiaDiem.Equals("") || TenDiaDiem.Equals(""))
            {
                return false;
            }
            return true;
        }

        public bool KiemTraMa()
        {
            string MaDiaDiem = txtMaDiaDiem.Text;
            foreach (DIADIEM DD in ListDiaDiem)
            {
                if (DD.MADIADIEM.Trim().Equals(MaDiaDiem.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             txtMaDiaDiem.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
             txtTenDiaDiem.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
