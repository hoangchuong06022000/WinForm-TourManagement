//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTourDuLich
{
    using System;
    using System.Collections.Generic;
    using DAL;

    public partial class PHANBONHANVIEN
    {
        public string MANV { get; set; }
        public string MADOAN { get; set; }
        public string NHIEMVU { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }

        public string TENNV
        {
            get { return NHANVIEN.TENNV; }
        }

        public List<PHANBONHANVIEN> GetPhanBoNhanVien(string MaDoan)
        {
            return new DAL_PhanBoNhanVien().GetPhanBoNhanVien(MaDoan);
        }

        public bool Insert(PHANBONHANVIEN PhanBo)
        {
            return new DAL_PhanBoNhanVien().Insert(PhanBo);
        }

        public bool Update(PHANBONHANVIEN PhanBoMoi)
        {
            return new DAL_PhanBoNhanVien().Update(PhanBoMoi);
        }

        public bool Delete(PHANBONHANVIEN PhanBo)
        {
            return new DAL_PhanBoNhanVien().Delete(PhanBo);
        }
    }
}
