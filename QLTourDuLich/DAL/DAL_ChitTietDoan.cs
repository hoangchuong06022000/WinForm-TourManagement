using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    class DAL_ChitTietDoan
    {
        public List<CHITIETDOAN> GetChiTiet(string MaDoan)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            var result = from c in db.CHITIETDOANs where c.MADOAN == MaDoan select c;
            return result.ToList();
        }

        public bool Insert(CHITIETDOAN ChiTietDoan)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.CHITIETDOANs.Add(ChiTietDoan);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(CHITIETDOAN ChiTietDoanMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                CHITIETDOAN ChiTietDoan = db.CHITIETDOANs.Find(ChiTietDoanMoi.MADOAN, ChiTietDoanMoi.MAKH);
                db.CHITIETDOANs.Attach(ChiTietDoan);
                ChiTietDoan.VAITROKH = ChiTietDoanMoi.VAITROKH;
                db.Entry(ChiTietDoan).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(CHITIETDOAN ChiTietDoan)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                CHITIETDOAN ChiTiet = db.CHITIETDOANs.Find(ChiTietDoan.MADOAN, ChiTietDoan.MAKH);
                db.CHITIETDOANs.Remove(ChiTiet);
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
