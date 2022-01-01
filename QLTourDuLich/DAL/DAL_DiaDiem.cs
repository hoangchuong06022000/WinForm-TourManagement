using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    class DAL_DiaDiem
    {
        public List<DIADIEM> GetAll()
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            return db.DIADIEMs.ToList();
        }

        public bool Insert(DIADIEM DiaDiem)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.DIADIEMs.Add(DiaDiem);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(DIADIEM DiaDiemCu, DIADIEM DiaDiemMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.DIADIEMs.Attach(DiaDiemCu);
                db.DIADIEMs.Remove(DiaDiemCu);
                db.DIADIEMs.Add(DiaDiemMoi);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(DIADIEM DiaDiem)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.DIADIEMs.Attach(DiaDiem);
                db.DIADIEMs.Remove(DiaDiem);
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
