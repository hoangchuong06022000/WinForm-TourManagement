using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    class DAL_NhanVien
    {
        public List<NHANVIEN> GetAll()
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            return db.NHANVIENs.ToList();
        }

        public bool Insert(NHANVIEN NhanVien)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            db.NHANVIENs.Add(NhanVien);
            db.SaveChanges();
            try
            {

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(NHANVIEN NhanVienMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                NHANVIEN NhanVien = db.NHANVIENs.Find(NhanVienMoi.MANV);
                db.NHANVIENs.Attach(NhanVien);
                NhanVien.TENNV = NhanVienMoi.TENNV;
                db.Entry(NhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(NHANVIEN NhanVien)
        {

            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                NHANVIEN NV = db.NHANVIENs.Where(p => p.MANV == NhanVien.MANV).SingleOrDefault();
                db.NHANVIENs.Remove(NV);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
