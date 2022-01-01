using QLTourDuLich.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.BUS
{
    class BUS_ThongKeNhanVien
    {

        public List<ModelThongKeNhanVien> ThongKeNhanVien()
        {
            DAL_ThongKe TK = new DAL_ThongKe();
            return TK.ThongKeNhanVien();
        }

        public List<ModelThongKeNhanVien> ThongKeNhanVientuDen(DateTime NgayTu, DateTime NgayDen)
        {
            DAL_ThongKe TK = new DAL_ThongKe();
            return TK.ThongKeNhanVientuDen(NgayTu, NgayDen);
        }
    }

    class  ModelThongKeNhanVien
    {
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public int SOLAN { get; set; }
    }
}
