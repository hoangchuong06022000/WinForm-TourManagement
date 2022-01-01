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
    public partial class GUI_Edit_Tour : Form
    {
        List<TOURDULICH> ListTour;
        List<LOAIHINHDULICH> ListLoaiHinh;
        TOURDULICH tourOld;
        GIATOUR GiaOld;

        public GUI_Edit_Tour()
        {
            InitializeComponent();
        }

        public void formThem()
        {
            btnThem.Visible = true;
            TaiForm();
        }

        public void formSuaTour(TOURDULICH tour)
        {
            tourOld = tour;
            comboMaTour.Text = tour.MATOUR;
            comboMaTour.Enabled = false;
            btnSuaTour.Visible = true;
            TaiForm();
            txtGiaTien.Enabled = false;
            txtNgayBatDau.Enabled = false;
            txtNgayKetThuc.Enabled = false;
            txtDacDiem.Text = tour.DACDIEM;
            txtTenGoi.Text = tour.TENGOI; 
            comboLoaiHinh.Text = tour.TENLOAIHINH;
        }

        public void formSuaGia(GIATOUR Gia)
        {
            btnSuaGia.Visible = true;
            TaiForm();
            txtDacDiem.Enabled = false;
            txtTenGoi.Enabled = false;
            comboLoaiHinh.Enabled = false;
            comboMaTour.Enabled = false;
            txtDacDiem.Text = Gia.DACDIEM;
            txtTenGoi.Text = Gia.TENGOI;
            comboLoaiHinh.Text = Gia.TENLOAIHINH;
            comboMaTour.Text = Gia.MATOUR;
            txtGiaTien.Text = Gia.THANHTIEN + "";
            txtNgayBatDau.Value = Gia.TG_BATDAU.Value;
            txtNgayKetThuc.Value = Gia.TG_KETTHUC.Value;

            GiaOld = Gia;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkInput() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            string MaTour = comboMaTour.Text;
            string TenGoi = txtTenGoi.Text;
            string LoaiHinh = comboLoaiHinh.Text;
            string DacDiem = txtDacDiem.Text;
            string MaGia = MaGiaTuDong();
            string GiaTien = txtGiaTien.Text;
            DateTime NgayBatDau = txtNgayBatDau.Value;
            DateTime NgayKetThuc = txtNgayKetThuc.Value;

            TOURDULICH Tour = new TOURDULICH();
            Tour.MATOUR = MaTour;
            Tour.TENGOI = TenGoi;
            Tour.MALOAIHINH = getMaLoaiHinh(LoaiHinh);
            Tour.DACDIEM = DacDiem;

            if (NgayBatDau.CompareTo(NgayKetThuc) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Thông báo");
                return;
            }

            if (Regex.IsMatch(GiaTien, "^\\d+$") == false)
            {
                MessageBox.Show("Nhập sai giá", "Thông báo");
                return;
            }

            bool TourMoi = true;
            foreach (TOURDULICH tour in ListTour)
            {
                if (comboMaTour.Text.Trim().Equals(tour.MATOUR.Trim()))
                {
                    TourMoi = false;
                }
            }
            if(TourMoi == true)
            {
                if(Tour.Insert(Tour) == false)
                {
                    MessageBox.Show("Lỗi xử lý", "Thông báo lỗi");
                    return;
                }
            }
            GIATOUR GiaTour = new GIATOUR();
            GiaTour.THANHTIEN = double.Parse(GiaTien);
            GiaTour.MATOUR = MaTour;
            GiaTour.MAGIA = MaGia;
            GiaTour.TG_BATDAU = NgayBatDau.Date;
            GiaTour.TG_KETTHUC = NgayKetThuc.Date;
            if (GiaTour.Insert(GiaTour) == false)
            {
                MessageBox.Show("Lỗi xử lý", "Thông báo lỗi");
                return;
            }

            Close();
        }

        private void TaiForm()
        {
            TOURDULICH Tour = new TOURDULICH();
            ListTour = Tour.GetAll();
            LOAIHINHDULICH LH = new LOAIHINHDULICH();
            ListLoaiHinh = LH.GetAll();
            foreach (TOURDULICH tour in ListTour)
            {
                comboMaTour.Items.Add(tour.MATOUR);
            }
            
            foreach (LOAIHINHDULICH loaiHinh in ListLoaiHinh)
            {
                comboLoaiHinh.Items.Add(loaiHinh.TENLOAIHINH);
            }
        }

        private void btnChonLoaiHinh_Click(object sender, EventArgs e)
        {
            GUI_QLLoaiHinh frameAddTour = new GUI_QLLoaiHinh();
            frameAddTour.ShowDialog();
            comboLoaiHinh.Items.Clear();
            LOAIHINHDULICH LH = new LOAIHINHDULICH();
            ListLoaiHinh = LH.GetAll();
            foreach (LOAIHINHDULICH loaiHinh in ListLoaiHinh)
            {
                comboLoaiHinh.Items.Add(loaiHinh.TENLOAIHINH);
            }
        }

        private void comboMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TOURDULICH tour in ListTour)
            {
                if(comboMaTour.SelectedItem.ToString().Trim().Equals(tour.MATOUR.Trim()))
                {
                    txtDacDiem.Text = tour.DACDIEM;
                    txtTenGoi.Text = tour.TENGOI;
                    comboLoaiHinh.Text = tour.TENLOAIHINH;
                }
            }
        }

        private bool checkInput()
        {
            if (comboMaTour.Text.Equals(""))
                return false;
            if (comboLoaiHinh.Text.Equals(""))
                return false;
            if (txtTenGoi.Text.Equals(""))
                return false;
            if (txtDacDiem.Text.Equals(""))
                return false;
            if (txtGiaTien.Text.Equals(""))
                return false;
            if (txtNgayBatDau.Text.Equals(""))
                return false;
            if (txtNgayKetThuc.Text.Equals(""))
                return false;
            return true;
        }

        public string getMaLoaiHinh(string TenLoaiHinh)
        {
            foreach (LOAIHINHDULICH loaiHinh in ListLoaiHinh)
            {
                if(TenLoaiHinh.Trim().Equals(loaiHinh.TENLOAIHINH.Trim()))
                {
                    return loaiHinh.MALOAIHINH;
                }
            }
            return "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TOURDULICH tourNew = new TOURDULICH();
            foreach (TOURDULICH tour in ListTour)
            {
                if (tourOld.MATOUR.Trim().Equals(tour.MATOUR.Trim()))
                {
                    tourNew = tour;
                }
            }
            tourNew.TENGOI = txtTenGoi.Text;
            tourNew.DACDIEM = txtDacDiem.Text;
            tourNew.MALOAIHINH = getMaLoaiHinh(comboLoaiHinh.Text);
            if (tourNew.Update(tourOld, tourNew) == false)
            {
                MessageBox.Show("Không được phép sửa", "Thông báo");
                return;
            }
            Close();
        }

        public string MaGiaTuDong()
        {
            string Ma = "";
            int So = 0;
            GIATOUR Gia = new GIATOUR();
            List<GIATOUR> ListGia = Gia.GetAll();
            string MaGia = ListGia[ListGia.Count - 1].MAGIA;
            Ma = MaGia.Substring(0, 2);
            string[] split = MaGia.Split('T'); 
            So = int.Parse(split[1]);
            So++;
            if (So < 10)
                Ma += "0" + So;
            else
                Ma += So;
            return Ma;
        }

        private void btnSuaGia_Click(object sender, EventArgs e)
        {
            DateTime NgayBatDau = txtNgayBatDau.Value;
            DateTime NgayKetThuc = txtNgayKetThuc.Value;
            string Gia = txtGiaTien.Text;

            if(Gia.Equals("") || NgayBatDau == null || NgayKetThuc == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            if(Regex.IsMatch(Gia, "^\\d+$") == false)
            {
                MessageBox.Show("Nhập sai giá", "Thông báo");
                return;
            }

            if (NgayBatDau.CompareTo(NgayKetThuc) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Thông báo");
                return;
            }

            GIATOUR GiaNew = new GIATOUR();
            GiaNew = GiaOld;
            GiaNew.THANHTIEN = double.Parse(txtGiaTien.Text);
            GiaNew.TG_BATDAU = txtNgayBatDau.Value;
            GiaNew.TG_KETTHUC = txtNgayKetThuc.Value;

            if (GiaNew.Update(GiaNew) == false)
            {
                MessageBox.Show("Không được phép sửa", "Thông báo");
                return;
            }
            Close();
        }
    }
}
