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
    
    public partial class KHACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH()
        {
            this.CHITIETDOANs = new HashSet<CHITIETDOAN>();
        }
    
        public string MAKH { get; set; }
        public string HOTEN { get; set; }
        public string CMND { get; set; }
        public string DIACHI { get; set; }
        public string GIOITINH { get; set; }
        public string SDT { get; set; }
        public string QUOCTICH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDOAN> CHITIETDOANs { get; set; }

        public List<KHACH> GetAll()
        {
            return new DAL_KhachHang().GetAll();
        }

        public bool Insert(KHACH Khach)
        {
            return new DAL_KhachHang().Insert(Khach);
        }

        public bool Update(KHACH KhachMoi)
        {
            return new DAL_KhachHang().Update(KhachMoi);
        }

        public bool Delete(KHACH Khach)
        {
            return new DAL_KhachHang().Delete(Khach);
        }
    }
}