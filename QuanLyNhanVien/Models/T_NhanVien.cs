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
    
    public partial class T_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_NhanVien()
        {
            this.T_PhieuKham = new HashSet<T_PhieuKham>();
        }
    
        public int MaNhanVien { get; set; }
        public string MaKhoa { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<bool> NguoiLaoDong { get; set; }
        public string TenNhanVien { get; set; }
        public Nullable<short> NgaySinh { get; set; }
        public Nullable<short> ThangSinh { get; set; }
        public Nullable<int> NamSinh { get; set; }
        public string DiaChi { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string CMND { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string HoKhau { get; set; }
        public string ChoOHienNay { get; set; }
        public string NganhHoc { get; set; }
        public string NoiHoc { get; set; }
        public string DiaChiHoc { get; set; }
        public Nullable<System.DateTime> NgayBatDauHoc { get; set; }
        public string CongViecTruocDay { get; set; }
        public string TienSuGiaDinh { get; set; }
        public string TienSuBanThan { get; set; }
    
        public virtual T_KhoaPhong T_KhoaPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PhieuKham> T_PhieuKham { get; set; }
    }
}
