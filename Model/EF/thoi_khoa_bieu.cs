//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class thoi_khoa_bieu
    {
        public Nullable<int> ma_mon { get; set; }
        public string ma_gv { get; set; }
        public int ma_lop { get; set; }
        public int tiet { get; set; }
        public Nullable<int> ma_hoc_ki { get; set; }
        public Nullable<int> ma_nam_hoc { get; set; }
    
        public virtual giao_vien giao_vien { get; set; }
        public virtual hoc_ki hoc_ki { get; set; }
        public virtual lop_hoc lop_hoc { get; set; }
        public virtual mon_hoc mon_hoc { get; set; }
        public virtual nam_hoc nam_hoc { get; set; }
    }
}
