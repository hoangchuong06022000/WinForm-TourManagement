using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    class DAL_Doan
    {
        public List<DOANDULICH> GetAll()
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            return db.DOANDULICHes.ToList();
        }

        public bool Insert(DOANDULICH Doan)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.DOANDULICHes.Add(Doan);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(DOANDULICH DoanMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                DOANDULICH Doan = db.DOANDULICHes.Find(DoanMoi.MADOAN);
                db.DOANDULICHes.Attach(Doan);
                Doan.MATOUR = DoanMoi.MATOUR;
                Doan.NGAYKHOIHANH = DoanMoi.NGAYKHOIHANH;
                Doan.NGAYKETTHUC = DoanMoi.NGAYKETTHUC;
                Doan.DOANHTHU = DoanMoi.DOANHTHU;
                db.Entry(Doan).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(DOANDULICH Doan)
        {

            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                DOANDULICH DoanDL = db.DOANDULICHes.Where(p => p.MADOAN == Doan.MADOAN).SingleOrDefault();
                db.DOANDULICHes.Remove(DoanDL);
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
