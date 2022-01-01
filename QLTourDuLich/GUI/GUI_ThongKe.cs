using QLTourDuLich.BUS;
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
    public partial class GUI_ThongKe : Form
    {

        public GUI_ThongKe()
        {
            InitializeComponent();
            LoadTKNV();
            LoadTKTour();
        }

        private void LoadTKNV()
        {
            BUS_ThongKeNhanVien bus = new BUS_ThongKeNhanVien();
            var List = new List<ModelThongKeNhanVien>();
            List = bus.ThongKeNhanVien();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = List;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MANV";
            column.Name = "Mã";
            column.Width = 80;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 155;
            column.DataPropertyName = "TENNV";
            column.Name = "Tên";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 110;
            column.DataPropertyName = "SOLAN";
            column.Name = "Số Lần Đi";
            dataGridView1.Columns.Add(column);

        }

        private void LoadTKTour()
        {
            BUS_ThongKeTour bus = new BUS_ThongKeTour();
            var List = new List<ModelThongKeTour>();
            List = bus.ThongKeTour();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = List;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MATOUR";
            column.Name = "Mã Tour";
            column.Width = 100;
            dataGridView2.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 175;
            column.DataPropertyName = "GIATIEN";
            column.Name = "Tổng Thu";
            dataGridView2.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Width = 110;
            column.DataPropertyName = "SODOAN";
            column.Name = "Số Đoàn";
            dataGridView2.Columns.Add(column);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            DateTime NgayTu = txtTu.Value;
            DateTime NgayDen = txtDen.Value;

            if (NgayTu.CompareTo(NgayDen) > 0)
            {
                MessageBox.Show("Ngày từ phải trước ngày đến", "Thông báo");
                return;
            }

            BUS_ThongKeNhanVien bus = new BUS_ThongKeNhanVien();
            var List = new List<ModelThongKeNhanVien>();
            List = bus.ThongKeNhanVientuDen(NgayTu, NgayDen);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = List;
        }
    }
}
