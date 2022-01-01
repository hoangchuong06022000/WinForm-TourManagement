using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QLTourDuLich.DAL
{
    class DAL_PhanBoNhanVien
    {
        public List<PHANBONHANVIEN> GetPhanBoNhanVien(string MaDoan)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            var result = from c in db.PHANBONHANVIENs where c.MADOAN == MaDoan select c;
            return result.ToList();
        }

        public bool Insert(PHANBONHANVIEN PhanBo)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.PHANBONHANVIENs.Add(PhanBo);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(PHANBONHANVIEN PhanBoMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                PHANBONHANVIEN PhanBo = db.PHANBONHANVIENs.Find(PhanBoMoi.MANV, PhanBoMoi.MADOAN);
                db.PHANBONHANVIENs.Attach(PhanBo);
                PhanBo.NHIEMVU = PhanBoMoi.NHIEMVU;
                db.Entry(PhanBo).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(PHANBONHANVIEN PhanBo)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                PHANBONHANVIEN PhanBoNhanVien = db.PHANBONHANVIENs.Find(PhanBo.MANV, PhanBo.MADOAN);
                db.PHANBONHANVIENs.Remove(PhanBoNhanVien);
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
