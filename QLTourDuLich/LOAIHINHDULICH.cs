//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTourDuLich
{
    using System;
    using System.Collections.Generic;
    using DAL;
    
    public partial class LOAIHINHDULICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHINHDULICH()
        {
            this.TOURDULICHes = new HashSet<TOURDULICH>();
        }
    
        public string MALOAIHINH { get; set; }
        public string TENLOAIHINH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURDULICH> TOURDULICHes { get; set; }

        public List<LOAIHINHDULICH> GetAll()
        {
            return new DAL_LoaiHinh().GetAll();
        }

        public bool Insert(LOAIHINHDULICH LoaiHinh)
        {
            return new DAL_LoaiHinh().Insert(LoaiHinh);
        }

        public bool Update(LOAIHINHDULICH LoaiHinhCu, LOAIHINHDULICH LoaiHinhMoi)
        {
            return new DAL_LoaiHinh().Update(LoaiHinhCu, LoaiHinhMoi);
        }

        public bool Delete(LOAIHINHDULICH LoaiHinh)
        {
            return new DAL_LoaiHinh().Delete(LoaiHinh);
        }
    }
}
