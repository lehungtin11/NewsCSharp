//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1905ct0020_LHT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_baiviet
    {
        public int id_baiviet { get; set; }
        public string tenbaiviet { get; set; }
        public string mabaiviet { get; set; }
        public string hinhanh { get; set; }
        public string noidung { get; set; }
        public string tomtat { get; set; }
        public int id_danhmuc { get; set; }
        public string ngay { get; set; }
    
        public virtual tbl_danhmuc tbl_danhmuc { get; set; }
    }
}
