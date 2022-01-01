using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QLTourDuLich.DAL
{
    class DAL_ChiPhi
    {
        public List<CHIPHI> GetChiPhi(string MaDoan)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            var result = from c in db.CHIPHIs where c.MADOAN == MaDoan select c;
            return result.ToList();
        }

        public bool Insert(CHIPHI ChiPhi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.CHIPHIs.Add(ChiPhi);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(CHIPHI ChiPhiMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                CHIPHI ChiPhi = db.CHIPHIs.Find(ChiPhiMoi.MACHIPHI, ChiPhiMoi.MADOAN);
                db.CHIPHIs.Attach(ChiPhi);
                ChiPhi.SOTIEN = ChiPhiMoi.SOTIEN;
                db.Entry(ChiPhi).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(CHIPHI ChiPhi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                CHIPHI ChiTiet = db.CHIPHIs.Find(ChiPhi.MACHIPHI, ChiPhi.MADOAN);
                db.CHIPHIs.Remove(ChiTiet);
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
