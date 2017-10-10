﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyNhanVienEntities : DbContext
    {
        public QuanLyNhanVienEntities()
            : base("name=QuanLyNhanVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_TocKy> T_TocKy { get; set; }
        public virtual DbSet<T_NhanVien> T_NhanVien { get; set; }
        public virtual DbSet<T_KhoaPhong> T_KhoaPhong { get; set; }
        public virtual DbSet<T_PhieuKham> T_PhieuKham { get; set; }
        public virtual DbSet<T_KhoThietBi> T_KhoThietBi { get; set; }
        public virtual DbSet<T_Lib_ThietBi> T_Lib_ThietBi { get; set; }
        public virtual DbSet<T_PhieuNhap> T_PhieuNhap { get; set; }
        public virtual DbSet<T_PhieuNhap_ChiTiet> T_PhieuNhap_ChiTiet { get; set; }
        public virtual DbSet<T_ChucNang> T_ChucNang { get; set; }
        public virtual DbSet<T_NguoiDung> T_NguoiDung { get; set; }
        public virtual DbSet<T_PhieuLanh> T_PhieuLanh { get; set; }
        public virtual DbSet<T_PhieuLanh_ChiTiet> T_PhieuLanh_ChiTiet { get; set; }
    
        public virtual ObjectResult<P_DanhSachKhoaPhong_Result> P_DanhSachKhoaPhong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_DanhSachKhoaPhong_Result>("P_DanhSachKhoaPhong");
        }
    
        public virtual ObjectResult<P_DanhSachNhanVien_Result> P_DanhSachNhanVien()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_DanhSachNhanVien_Result>("P_DanhSachNhanVien");
        }
    
        public virtual ObjectResult<P_DanhSachSucKhoeNhanVien_Result> P_DanhSachSucKhoeNhanVien(string namKham)
        {
            var namKhamParameter = namKham != null ?
                new ObjectParameter("NamKham", namKham) :
                new ObjectParameter("NamKham", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_DanhSachSucKhoeNhanVien_Result>("P_DanhSachSucKhoeNhanVien", namKhamParameter);
        }
    
        public virtual ObjectResult<P_DanhSachKhoThietBi_Result> P_DanhSachKhoThietBi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_DanhSachKhoThietBi_Result>("P_DanhSachKhoThietBi");
        }
    
        public virtual int P_InsertKho(string maKhoa, string tenKho)
        {
            var maKhoaParameter = maKhoa != null ?
                new ObjectParameter("MaKhoa", maKhoa) :
                new ObjectParameter("MaKhoa", typeof(string));
    
            var tenKhoParameter = tenKho != null ?
                new ObjectParameter("TenKho", tenKho) :
                new ObjectParameter("TenKho", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_InsertKho", maKhoaParameter, tenKhoParameter);
        }
    
        public virtual int P_UpdateKho(Nullable<int> maKho, string maKhoa, string tenKho, string kyHieu)
        {
            var maKhoParameter = maKho.HasValue ?
                new ObjectParameter("MaKho", maKho) :
                new ObjectParameter("MaKho", typeof(int));
    
            var maKhoaParameter = maKhoa != null ?
                new ObjectParameter("MaKhoa", maKhoa) :
                new ObjectParameter("MaKhoa", typeof(string));
    
            var tenKhoParameter = tenKho != null ?
                new ObjectParameter("TenKho", tenKho) :
                new ObjectParameter("TenKho", typeof(string));
    
            var kyHieuParameter = kyHieu != null ?
                new ObjectParameter("KyHieu", kyHieu) :
                new ObjectParameter("KyHieu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_UpdateKho", maKhoParameter, maKhoaParameter, tenKhoParameter, kyHieuParameter);
        }
    
        public virtual ObjectResult<P_InsertPhieuNhap_Result> P_InsertPhieuNhap(Nullable<int> maKho, string nhaCungCap, Nullable<System.DateTime> ngayNhap, string nguoiNhap, string ghiChu)
        {
            var maKhoParameter = maKho.HasValue ?
                new ObjectParameter("MaKho", maKho) :
                new ObjectParameter("MaKho", typeof(int));
    
            var nhaCungCapParameter = nhaCungCap != null ?
                new ObjectParameter("NhaCungCap", nhaCungCap) :
                new ObjectParameter("NhaCungCap", typeof(string));
    
            var ngayNhapParameter = ngayNhap.HasValue ?
                new ObjectParameter("NgayNhap", ngayNhap) :
                new ObjectParameter("NgayNhap", typeof(System.DateTime));
    
            var nguoiNhapParameter = nguoiNhap != null ?
                new ObjectParameter("NguoiNhap", nguoiNhap) :
                new ObjectParameter("NguoiNhap", typeof(string));
    
            var ghiChuParameter = ghiChu != null ?
                new ObjectParameter("GhiChu", ghiChu) :
                new ObjectParameter("GhiChu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_InsertPhieuNhap_Result>("P_InsertPhieuNhap", maKhoParameter, nhaCungCapParameter, ngayNhapParameter, nguoiNhapParameter, ghiChuParameter);
        }
    
        public virtual ObjectResult<P_DanhSachPhieuNhap_Result> P_DanhSachPhieuNhap(Nullable<System.DateTime> tuNgay, Nullable<System.DateTime> denNgay)
        {
            var tuNgayParameter = tuNgay.HasValue ?
                new ObjectParameter("TuNgay", tuNgay) :
                new ObjectParameter("TuNgay", typeof(System.DateTime));
    
            var denNgayParameter = denNgay.HasValue ?
                new ObjectParameter("DenNgay", denNgay) :
                new ObjectParameter("DenNgay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_DanhSachPhieuNhap_Result>("P_DanhSachPhieuNhap", tuNgayParameter, denNgayParameter);
        }
    
        public virtual ObjectResult<P_DanhSachChiTietPhieuNhap_Result> P_DanhSachChiTietPhieuNhap(Nullable<int> maPhieuNhap)
        {
            var maPhieuNhapParameter = maPhieuNhap.HasValue ?
                new ObjectParameter("MaPhieuNhap", maPhieuNhap) :
                new ObjectParameter("MaPhieuNhap", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_DanhSachChiTietPhieuNhap_Result>("P_DanhSachChiTietPhieuNhap", maPhieuNhapParameter);
        }
    
        public virtual ObjectResult<P_DanhSachPhieuLanh_Result> P_DanhSachPhieuLanh(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("Nam", nam) :
                new ObjectParameter("Nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_DanhSachPhieuLanh_Result>("P_DanhSachPhieuLanh", thangParameter, namParameter);
        }
    }
}
