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
    public partial class GUI_Doan : Form
    {
        List<DOANDULICH> ListDoan;
        List<TOURDULICH> ListTour;

        public GUI_Doan()
        {
            InitializeComponent();
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            DOANDULICH Doan = new DOANDULICH();
            string MaTour = comboMaTour.Text;
            DateTime NgayBatDau = txtNgayBatDau.Value;
            DateTime NgayKetThuc = txtNgayKetThuc.Value;
            double DoanhThu = 0;

            string MaDoan = MaTuDong();
            Doan.MADOAN = MaDoan;
            Doan.MATOUR = MaTour;
            Doan.NGAYKETTHUC = NgayKetThuc;
            Doan.NGAYKHOIHANH = NgayBatDau;
            Doan.DOANHTHU = DoanhThu;

            if (NgayBatDau.CompareTo(NgayKetThuc) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải truước ngày kết thúc", "Thông báo");
                return;
            }

            if (Doan.Insert(Doan) == false)
            {
                MessageBox.Show("Không được phép thêm", "Thông báo lỗi");
                return;
            }

            ListDoan.Add(Doan);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListDoan;
        }

        public void LoadData()
        {
            DOANDULICH Doan = new DOANDULICH();
            TOURDULICH tour = new TOURDULICH();
            ListDoan = Doan.GetAll();
            ListTour = tour.GetAll();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListDoan.ToList();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MADOAN";
            column.Name = "Mã Đoàn";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 80;
            column.DataPropertyName = "MATOUR";
            column.Name = "Mã Tour";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 120;
            column.DataPropertyName = "GIATIEN";
            column.Name = "Doanh Thu";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 140;
            column.DataPropertyName = "NGAYKHOIHANH";
            column.Name = "Ngày Khởi Hành";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 140;
            column.DataPropertyName = "NGAYKETTHUC";
            column.Name = "Ngày Kết Thúc";
            dataGridView1.Columns.Add(column);

            DataGridViewButtonColumn columnButton = new DataGridViewButtonColumn();
            columnButton.Width = 60;
            columnButton.HeaderText = "";
            columnButton.Text = "Chi Tiết";
            columnButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnButton);

            columnButton = new DataGridViewButtonColumn();
            columnButton.Width = 60;
            columnButton.HeaderText = "";
            columnButton.Text = "Chi Phí";
            columnButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnButton);

            columnButton = new DataGridViewButtonColumn();
            columnButton.Width = 60;
            columnButton.HeaderText = "";
            columnButton.Text = "Nhân Viên";
            columnButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnButton);

            columnButton = new DataGridViewButtonColumn();
            columnButton.Width = 60;
            columnButton.HeaderText = "";
            columnButton.Text = "Nội dung";
            columnButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnButton);

            comboMaTour.Items.Clear();
            comboMa.Items.Clear();
            foreach (TOURDULICH Tour in ListTour)
            {
                comboMaTour.Items.Add(Tour.MATOUR);
                comboMa.Items.Add(Tour.MATOUR);
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
                string message = "Bạn chưa chọn Đoàn để sửa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string MaDoan = dataGridView1.Rows[VT].Cells[0].Value.ToString();
                string MaTour = comboMaTour.Text;
                DateTime NgayBatDau = txtNgayBatDau.Value;
                DateTime NgayKetThuc = txtNgayKetThuc.Value;
                if(KiemTraDuLieu() == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }

                if (NgayBatDau.CompareTo(NgayKetThuc) > 0)
                {
                    MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Thông báo");
                    return;
                }

                DOANDULICH Doan = new DOANDULICH();
                Doan.MADOAN = MaDoan;
                if (ListDoan[VT].MADOAN.Trim().Equals(Doan.MADOAN.Trim()))
                {
                    Doan = ListDoan[VT];
                }
                Doan.DOANHTHU = 0;
                Doan.MATOUR = MaTour;
                Doan.NGAYKETTHUC = NgayKetThuc;
                Doan.NGAYKHOIHANH = NgayBatDau;

                if (Doan.Update(Doan) == false)
                {
                    MessageBox.Show("Không được phép sửa", "Thông báo");
                    return;
                }
                ListDoan = Doan.GetAll();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListDoan;
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
                string message = "Bạn chưa chọn Đoàn để xóa";
                string title = "Thông báo lỗi";
                MessageBox.Show(message, title);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (ListDoan[VT].Delete(ListDoan[VT]) == false)
                {
                    MessageBox.Show("Không được phép xóa", "Thông báo");
                    return;
                }

                ListDoan.Remove(ListDoan[VT]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListDoan;
            }
        }

        private bool KiemTraDuLieu()
        {
            string MaTour = comboMaTour.Text;
            string NgayBatDau = txtNgayBatDau.Text;
            string NgayKetThuc = txtNgayKetThuc.Text;

            if (MaTour.Equals("") || NgayBatDau.Equals("") || NgayKetThuc.Equals(""))
                return false;

            return true;
        }

        public string MaTuDong()
        {
            string Ma = "";
            int So = 0;
            string MaDoan = ListDoan[ListDoan.Count - 1].MADOAN;
            Ma = MaDoan.Substring(0, 2);
            string[] split = MaDoan.Split('O');
            So = int.Parse(split[1]);
            So++;
            if (So < 10)
                Ma += "0" + So;
            else
                Ma += So;
            return Ma;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int VT = e.RowIndex;
            string MaDoan = dataGridView1.Rows[VT].Cells[0].Value.ToString();
            DOANDULICH DoanDuLich = new DOANDULICH();
            foreach (DOANDULICH doan in ListDoan)
            {
                if (doan.MADOAN.Equals(MaDoan))
                {
                    DoanDuLich = doan;
                    break;
                }
            }

            if (e.ColumnIndex == 5)
            {
                GUI_ChiTietDoan frame = new GUI_ChiTietDoan();
                frame.formChiTiet(DoanDuLich);
                frame.ShowDialog();
                LoadData();
                return;
            }

            if (e.ColumnIndex == 6)
            {
                GUI_ChiPhi frame = new GUI_ChiPhi();
                frame.formChiPhi(DoanDuLich.MADOAN);
                frame.ShowDialog();
                return;
            }

            if (e.ColumnIndex == 7)
            {
                GUI_PhanBoNhanVien frame = new GUI_PhanBoNhanVien();
                frame.formPhanBo(DoanDuLich.MADOAN);
                frame.ShowDialog();
                return;
            }

            if (e.ColumnIndex == 8)
            {
                GUI_NoiDung frame = new GUI_NoiDung();
                frame.formNoiDung(DoanDuLich.MADOAN);
                frame.ShowDialog();
                return;
            }

            string MaTour = dataGridView1.Rows[VT].Cells[1].Value.ToString();
            string NgayKhoiHanh = dataGridView1.Rows[VT].Cells[3].Value.ToString();
            string NgayKetThuc = dataGridView1.Rows[VT].Cells[4].Value.ToString();

            comboMaTour.Text = MaTour;
            txtNgayBatDau.Text = NgayKhoiHanh;
            txtNgayKetThuc.Text = NgayKetThuc;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string MaTour = comboMa.Text;

            List<DOANDULICH> ListTimKiemDoan = new List<DOANDULICH>();
            if (MaTour.Equals("") == false)
            {
                foreach (DOANDULICH doan in ListDoan)
                {
                    if (doan.MATOUR.Equals(MaTour))
                        ListTimKiemDoan.Add(doan);
                }
                if (ListTimKiemDoan.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả", "Thông báo");
                    return;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListTimKiemDoan;
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListDoan;
        }
    }
}
