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
    public partial class FormChinh : Form
    {
        Form activeForm;

        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanLyTour_Click(object sender, EventArgs e)
        {
            openCildForm(new Main());
        }

        private void openCildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openCildForm(new GUI_KhachHang());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openCildForm(new GUI_Doan());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openCildForm(new GUI_ThongKe());
        }
    }
}
