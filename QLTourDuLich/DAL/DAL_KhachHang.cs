using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    public class DAL_KhachHang
    {
        public List<KHACH> GetAll()
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            return db.KHACHes.ToList();
        }

        public bool Insert(KHACH Khach)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            db.KHACHes.Add(Khach);
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

        public bool Update(KHACH KhachMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                KHACH Khach = db.KHACHes.Find(KhachMoi.MAKH);
                db.KHACHes.Attach(Khach);
                Khach.HOTEN = KhachMoi.HOTEN;
                Khach.CMND = KhachMoi.CMND;
                Khach.DIACHI = KhachMoi.DIACHI;
                Khach.GIOITINH = KhachMoi.GIOITINH;
                Khach.SDT = KhachMoi.SDT;
                Khach.QUOCTICH = KhachMoi.QUOCTICH;
                db.Entry(Khach).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(KHACH Khach)
        {
            
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                KHACH KH = db.KHACHes.Where(p => p.MAKH == Khach.MAKH).SingleOrDefault();
                db.KHACHes.Remove(KH);
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
