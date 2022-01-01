using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    class DAL_GiaTour
    {
        public List<GIATOUR> GetAll()
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            return db.GIATOURs.ToList();
        }

        public List<GIATOUR> GetGiaTour(string MaTour)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            var result = from c in db.GIATOURs where c.MATOUR == MaTour select c;
            return result.ToList();
        }

        public bool Insert(GIATOUR GiaTour)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.GIATOURs.Add(GiaTour);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(GIATOUR GiaTourMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                GIATOUR Gia = db.GIATOURs.Find(GiaTourMoi.MAGIA);
                db.GIATOURs.Attach(Gia);
                Gia.THANHTIEN = GiaTourMoi.THANHTIEN;
                Gia.TG_BATDAU = GiaTourMoi.TG_BATDAU;
                Gia.TG_KETTHUC = GiaTourMoi.TG_KETTHUC;
                db.Entry(Gia).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(GIATOUR GiaTour)
        {

            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                GIATOUR Gia= db.GIATOURs.Where(p => p.MAGIA == GiaTour.MAGIA).SingleOrDefault();
                db.GIATOURs.Remove(Gia);
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
