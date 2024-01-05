namespace OnTX2_6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(10)]
        [Required(ErrorMessage = "Nh?p mã nhân viên")]
        public string Manv { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Nh?p h? tên nhân viên")]

        public string Hoten { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Nh?p phòng nhân viên")]

        public string Maphong { get; set; }

        [Required(ErrorMessage = "Nh?p l??ng nhân viên")]
        public double? Luong { get; set; }
    }
}
