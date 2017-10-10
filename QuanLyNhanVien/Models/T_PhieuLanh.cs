//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PhieuLanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PhieuLanh()
        {
            this.T_PhieuLanh_ChiTiet = new HashSet<T_PhieuLanh_ChiTiet>();
        }
    
        public int MaPhieuLanh { get; set; }
        public int MaKho { get; set; }
        public int MaNguoiDung { get; set; }
        public string SoPhieu { get; set; }
        public System.DateTime NgayLuu { get; set; }
        public Nullable<System.DateTime> NgayDuyet { get; set; }
        public Nullable<System.DateTime> NgayPhat { get; set; }
        public bool ChoDuyet { get; set; }
        public bool DaDuyet { get; set; }
        public bool DaPhat { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> STT { get; set; }
        public short Thang { get; set; }
        public int Nam { get; set; }
    
        public virtual T_KhoThietBi T_KhoThietBi { get; set; }
        public virtual T_NguoiDung T_NguoiDung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PhieuLanh_ChiTiet> T_PhieuLanh_ChiTiet { get; set; }
    }
}
