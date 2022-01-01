using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    class DAL_ChiTietTour
    {
        public List<CHITIETTOUR> GetChiTiet(string MaTour)
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            var result = from c in db.CHITIETTOURs where c.MATOUR == MaTour select c; 
            return result.ToList();
        }

        public bool Insert(CHITIETTOUR ChiTietTour)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.CHITIETTOURs.Add(ChiTietTour);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(CHITIETTOUR ChiTietTourMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                CHITIETTOUR ChiTiet = db.CHITIETTOURs.Find(ChiTietTourMoi.MATOUR, ChiTietTourMoi.MADIADIEM);
                db.CHITIETTOURs.Attach(ChiTiet);
                ChiTiet.THUTU = ChiTietTourMoi.THUTU;
                db.Entry(ChiTiet).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(CHITIETTOUR ChiTietTour)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                CHITIETTOUR ChiTiet = db.CHITIETTOURs.Find(ChiTietTour.MATOUR, ChiTietTour.MADIADIEM);
                db.CHITIETTOURs.Remove(ChiTiet);
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
