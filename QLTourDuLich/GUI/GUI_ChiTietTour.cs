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
    public partial class GUI_ChiTietTour : Form
    {

        public List<DIADIEM> ListDiaDiem;
        public List<CHITIETTOUR> ListChiTietTour;

        public GUI_ChiTietTour()
        {
            InitializeComponent();
        }

        public void formChiTiet(string MaTour)
        {
            DIADIEM dd = new DIADIEM();
            CHITIETTOUR ct = new CHITIETTOUR();
            txtMaTour.Text = MaTour;
            ListDiaDiem = dd.GetAll();
            ListChiTietTour = ct.getChiTietTour(MaTour);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListChiTietTour.ToList();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MATOUR";
            column.Name = "Mã Tour";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 207;
            column.DataPropertyName = "TENDIADIEM";
            column.Name = "Địa Điểm";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 85;
            column.DataPropertyName = "THUTU";
            column.Name = "Thứ Tự";
            dataGridView1.Columns.Add(column);

            CapNhatCombo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = e.RowIndex;
            string MaTour = dataGridView1.Rows[VT].Cells[0].Value.ToString();
            string DiaDiem = dataGridView1.Rows[VT].Cells[1].Value.ToString();
            string ThuTu = dataGridView1.Rows[VT].Cells[2].Value.ToString();

            txtMaTour.Text = MaTour;
            comboDiaDiem.Text = DiaDiem;
            txtThuTu.Text = ThuTu;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string MaTour = txtMaTour.Text;
            string DiaDiem = comboDiaDiem.Text;
            string ThuTu = txtThuTu.Text;
            if (MaTour.Equals("") || DiaDiem.Equals("") || ThuTu.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            if(Regex.IsMatch(ThuTu, "^\\d$") == false)
            {
                MessageBox.Show("Thứ tự vui lòng nhập số", "Thông báo");
                return;
            }

            CHITIETTOUR ChiTietTour = new CHITIETTOUR();
            ChiTietTour.MATOUR = MaTour;
            ChiTietTour.MADIADIEM = getMaDiaDiem(DiaDiem);
            ChiTietTour.THUTU = int.Parse(ThuTu);

            if(ChiTietTour.Insert(ChiTietTour) == false)
            {
                MessageBox.Show("Không được phép thêm", "Thông báo");
                return;
            }
            ListChiTietTour = ChiTietTour.getChiTietTour(MaTour);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListChiTietTour;

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
                string message = "Bạn chưa chọn Chi Tiết Tour để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaTour = txtMaTour.Text;
                string DiaDiem = comboDiaDiem.Text;
                string ThuTu = txtThuTu.Text;
                if (MaTour.Equals("") || DiaDiem.Equals("") || ThuTu.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }

                if (Regex.IsMatch(ThuTu, "^\\d$") == false)
                {
                    MessageBox.Show("Thứ tự vui lòng nhập số", "Thông báo");
                    return;
                }

                CHITIETTOUR ChiTietTour = new CHITIETTOUR();
                ChiTietTour.MATOUR = MaTour;
                ChiTietTour.MADIADIEM = getMaDiaDiem(DiaDiem);
                if (ListChiTietTour[VT].MADIADIEM.Trim().Equals(ChiTietTour.MADIADIEM.Trim()) == false)
                {
                    MessageBox.Show("Không được sửa Mã địa điểm", "Thông báo");
                    return;
                }
                ChiTietTour.THUTU = int.Parse(ThuTu);

                if (ChiTietTour.Update(ChiTietTour) == false)
                {
                    MessageBox.Show("Không được phép sửa", "Thông báo");
                    return;
                }
                ListChiTietTour = ChiTietTour.getChiTietTour(MaTour);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListChiTietTour;

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
                string message = "Bạn chưa chọn Chi Tiết Tour để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ListChiTietTour[VT].Delete(ListChiTietTour[VT]) == false)
                {
                    MessageBox.Show("Không được phép xóa", "Thông báo");
                    return;
                }

                ListChiTietTour.Remove(ListChiTietTour[VT]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListChiTietTour;
                CapNhatCombo();
            }
        }

        public string getMaDiaDiem(string TenDiaDiem)
        {
            string MaDiaDiem = "";
            foreach (DIADIEM DD in ListDiaDiem)
            {
                if(TenDiaDiem.Trim().Equals(DD.TENDIADIEM.Trim()))
                {
                    MaDiaDiem = DD.MADIADIEM;
                }
            }
            return MaDiaDiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_QLDIADIEM frameAddTour = new GUI_QLDIADIEM();
            frameAddTour.ShowDialog();
            comboDiaDiem.Items.Clear();
            DIADIEM dd = new DIADIEM();
            ListDiaDiem = dd.GetAll();
            CapNhatCombo();
        }

        public void CapNhatCombo()
        {
            comboDiaDiem.Items.Clear();
            int Trung = 0;
            foreach (DIADIEM DD in ListDiaDiem)
            {
                Trung = 0;
                string TenDiaDiem = DD.TENDIADIEM;
                foreach (CHITIETTOUR ChiTiet in ListChiTietTour)
                {
                    if (DD.MADIADIEM.Trim().Equals(ChiTiet.MADIADIEM.Trim()))
                    {
                        Trung = 1;
                        break;
                    }

                }
                if (Trung == 0)
                {
                    comboDiaDiem.Items.Add(TenDiaDiem);
                }
            }
        }
    }
}
