using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    public class DAL_Tour
    {
        public List<TOURDULICH> GetAll()
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            return db.TOURDULICHes.ToList();
        }

        public bool Insert(TOURDULICH Tour)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.TOURDULICHes.Add(Tour);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(TOURDULICH TourCu, TOURDULICH TourMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                TOURDULICH tour = db.TOURDULICHes.Find(TourMoi.MATOUR);
                db.TOURDULICHes.Attach(tour);
                tour.MALOAIHINH = TourMoi.MALOAIHINH;
                tour.TENGOI = TourMoi.TENGOI;
                tour.DACDIEM = TourMoi.DACDIEM;
                db.Entry(tour).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(TOURDULICH Tour)
        {
            
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                TOURDULICH tour = db.TOURDULICHes.Where(p => p.MATOUR == Tour.MATOUR).SingleOrDefault();
                db.TOURDULICHes.Remove(tour);
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
