//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatHang
    {
        public string Id { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> Gia { get; set; }
        public string LoaiSanPham { get; set; }
    
        public virtual ChitietDienThoai ChitietDienThoai { get; set; }
        public virtual ChitietLaptop ChitietLaptop { get; set; }
    }
}
