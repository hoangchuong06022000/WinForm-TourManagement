using QLTourDuLich.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTourDuLich
{
    public partial class Main : Form
    {
        public List<GIATOUR> ListGia;
        public List<TOURDULICH> ListTour;
        public List<LOAIHINHDULICH> ListLoaiHinh;

        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            GIATOUR Gia = new GIATOUR();
            TOURDULICH Tour = new TOURDULICH();
            LOAIHINHDULICH LoaiHinh = new LOAIHINHDULICH();
            ListGia = Gia.GetAll();
            ListTour = Tour.GetAll();
            ListLoaiHinh = LoaiHinh.GetAll();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ListGia.ToList();


            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MATOUR";
            column.Width = 45;
            column.Name = "Mã";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TENGOI";
            column.Width = 130;
            column.Name = "Tên gọi";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DACDIEM";
            column.Name = "Đặc điểm";
            column.Width = 100;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TENLOAIHINH";
            column.Name = "Loại hình";
            column.Width = 135;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "GIATIEN";
            column.Name = "Giá tour";
            column.Width = 80;
            dataGridView1.Columns.Add(column);
        
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TG_BATDAU";
            column.Name = "Bắt đầu";
            column.Width = 95;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TG_KETTHUC";
            column.Width = 95;
            column.Name = "Kết thúc";
            dataGridView1.Columns.Add(column);

            DataGridViewButtonColumn columnButton = new DataGridViewButtonColumn();
            columnButton.Width = 60;
            columnButton.HeaderText = "";
            columnButton.Text = "Sửa";
            columnButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnButton);

            columnButton = new DataGridViewButtonColumn();
            columnButton.Width = 60;
            columnButton.HeaderText = "";
            columnButton.Text = "Xóa";
            columnButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnButton);

            comboMaTour.Items.Clear();
            comboMa.Items.Clear();
            foreach (TOURDULICH tour in ListTour)
            {
                comboMaTour.Items.Add(tour.MATOUR);
                comboMa.Items.Add(tour.MATOUR);
            }
            comboLoaiHinh.Items.Clear();
            foreach (LOAIHINHDULICH loaihinh in ListLoaiHinh)
            {
                comboLoaiHinh.Items.Add(loaihinh.TENLOAIHINH);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = e.RowIndex;
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    GUI_Edit_Tour frame = new GUI_Edit_Tour();
                    frame.formSuaGia(ListGia[VT]);
                    frame.ShowDialog();
                    ListGia = ListGia[VT].GetAll();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ListGia;
                    return;
                }
                else
                    return;
            }

            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    if(ListGia[VT].Delete(ListGia[VT]) == false)
                    {
                        MessageBox.Show("Lỗi CSDL", "Thông báo");
                        return;
                    }
                    ListGia.Remove(ListGia[VT]);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ListGia;
                    return;
                }
                else
                    return;
            }
            GUI_ChiTietTour frameChiTiet = new GUI_ChiTietTour();
            frameChiTiet.formChiTiet(ListGia[VT].MATOUR);
            frameChiTiet.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUI_Edit_Tour frameAddTour = new GUI_Edit_Tour();
            frameAddTour.formThem();
            frameAddTour.ShowDialog();
            GIATOUR Gia = new GIATOUR();
            TOURDULICH Tour = new TOURDULICH();
            ListGia = Gia.GetAll();
            dataGridView1.DataSource = ListGia.ToList();
            ListTour = Tour.GetAll();
            comboMaTour.Items.Clear();
            foreach (TOURDULICH tour in ListTour)
            {
                comboMaTour.Items.Add(tour.MATOUR);
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            string MaTour = comboMaTour.Text;
            if (MaTour.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn Mã tour để xóa", "Thông báo");
            }
            else
            {
                foreach (TOURDULICH tour in ListTour)
                {
                    if(MaTour.Trim().Equals(tour.MATOUR.Trim()))
                    {
                        if (tour.Delete(tour) == false)
                        {
                            MessageBox.Show("Tour này chưa được xóa các địa điểm và giá", "Thông báo");
                            return;
                        }
                        comboMaTour.Items.Remove(MaTour);
                        return;
                    }
                }
                MessageBox.Show("Mã tour này không tồn tại", "Thông báo");
            }
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            string MaTour = comboMaTour.Text;
            if (MaTour.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn Mã tour để sửa", "Thông báo");
            }
            else
            {
                foreach (TOURDULICH tour in ListTour)
                {
                    if (MaTour.Trim().Equals(tour.MATOUR.Trim()))
                    {
                        GIATOUR Gia = new GIATOUR();
                        TOURDULICH Tour = new TOURDULICH();
                        GUI_Edit_Tour frame = new GUI_Edit_Tour();
                        frame.formSuaTour(tour);
                        frame.ShowDialog();
                        ListGia = Gia.GetAll();
                        ListTour = Tour.GetAll();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ListGia;
                        return;
                    }
                }
                MessageBox.Show("Mã tour này không tồn tại", "Thông báo");
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string MaTour = comboMa.Text;
            string TenLoaiHinh = comboLoaiHinh.Text;

            List<GIATOUR> ListGiaTour = new List<GIATOUR>();
            if (MaTour.Equals("") == false)
            {
                foreach (GIATOUR gia in ListGia)
                {
                    if (gia.MATOUR.Equals(MaTour))
                        ListGiaTour.Add(gia);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListGiaTour;
                return;
            }

            if (TenLoaiHinh.Equals("") == false)
            {
                foreach (GIATOUR gia in ListGia)
                {
                    if (gia.TENLOAIHINH.Equals(TenLoaiHinh))
                        ListGiaTour.Add(gia);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListGiaTour;
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListGia;
        }

        public string getMaLoaiHinh(string TenLoaiHinh)
        {
            foreach (LOAIHINHDULICH loaihinh in ListLoaiHinh)
            {
                if (loaihinh.TENLOAIHINH.Equals(TenLoaiHinh))
                    return loaihinh.MALOAIHINH;
            }
            return "";
        }
    }
}
