//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_dienthoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.ChiTietDHs = new HashSet<ChiTietDH>();
        }
    
        public long MaDH { get; set; }
        public Nullable<int> MaKH { get; set; }
        public string TenNguoiNhan { get; set; }
        public string SDTnhan { get; set; }
        public string DiaChiNhan { get; set; }
        public Nullable<decimal> TriGia { get; set; }
        public string TinhTrang { get; set; }
        public Nullable<System.DateTime> NgayDH { get; set; }
        public string HTThanhToan { get; set; }
        public string HTGiaohang { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDH> ChiTietDHs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
