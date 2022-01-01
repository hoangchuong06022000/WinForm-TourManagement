using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QLTourDuLich.DAL
{
    class DAL_NoiDung
    {
        public NOIDUNG GetNoiDung(string MaDoan)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            var result = from c in db.NOIDUNGs where c.MADOAN == MaDoan select c;
            return result.FirstOrDefault();
        }

        public bool Insert(NOIDUNG NoiDung)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.NOIDUNGs.Add(NoiDung);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(NOIDUNG NoiDungMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                NOIDUNG NoiDung = db.NOIDUNGs.Find(NoiDungMoi.MADOAN);
                db.NOIDUNGs.Attach(NoiDung);
                NoiDung.HANHTRINH = NoiDungMoi.HANHTRINH;
                NoiDung.KHACHSAN = NoiDungMoi.KHACHSAN;
                db.Entry(NoiDung).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(NOIDUNG NoiDung)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                NOIDUNG ND = db.NOIDUNGs.Find(NoiDung.MADOAN);
                db.NOIDUNGs.Remove(ND);
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
