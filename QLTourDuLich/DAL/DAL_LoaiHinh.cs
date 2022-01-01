using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTourDuLich.DAL
{
    class DAL_LoaiHinh
    {
        public List<LOAIHINHDULICH> GetAll()
        {
            QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
            return db.LOAIHINHDULICHes.ToList();
        }

        public bool Insert(LOAIHINHDULICH LoaiHinh)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.LOAIHINHDULICHes.Add(LoaiHinh);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(LOAIHINHDULICH LoaiHinhCu, LOAIHINHDULICH LoaiHinhMoi)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.LOAIHINHDULICHes.Attach(LoaiHinhCu);
                db.LOAIHINHDULICHes.Remove(LoaiHinhCu);
                db.LOAIHINHDULICHes.Add(LoaiHinhMoi);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(LOAIHINHDULICH LoaiHinh)
        {
            try
            {
                QUANLYTOURDULICHEntities db = new QUANLYTOURDULICHEntities();
                db.LOAIHINHDULICHes.Attach(LoaiHinh);
                db.LOAIHINHDULICHes.Remove(LoaiHinh);
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
