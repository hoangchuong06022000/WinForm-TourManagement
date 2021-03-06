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
    
    public partial class CHITIETTOUR
    {
        public string MATOUR { get; set; }
        public string MADIADIEM { get; set; }
        public int THUTU { get; set; }
    
        public virtual TOURDULICH TOURDULICH { get; set; }
        public virtual DIADIEM DIADIEM { get; set; }

        public List<CHITIETTOUR> getChiTietTour(string MaTour)
        {
            return new DAL_ChiTietTour().GetChiTiet(MaTour);
        }

        public string TENDIADIEM
        {
            get { return DIADIEM.TENDIADIEM; }
        }

        public bool Insert(CHITIETTOUR ChiTietTour)
        {
            return new DAL_ChiTietTour().Insert(ChiTietTour);
        }

        public bool Update(CHITIETTOUR ChiTietTourMoi)
        {
            return new DAL_ChiTietTour().Update(ChiTietTourMoi);
        }

        public bool Delete(CHITIETTOUR ChiTietTour)
        {
            return new DAL_ChiTietTour().Delete(ChiTietTour);
        }
    }
}
