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
    
    public partial class giao_vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giao_vien()
        {
            this.lop_hoc = new HashSet<lop_hoc>();
            this.thoi_khoa_bieu = new HashSet<thoi_khoa_bieu>();
        }
    
        public string ma_gv { get; set; }
        public string pass { get; set; }
        public string ten { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public Nullable<byte> gioiTinh { get; set; }
        public string sdt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lop_hoc> lop_hoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thoi_khoa_bieu> thoi_khoa_bieu { get; set; }
    }
}
