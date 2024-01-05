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
        [Required(ErrorMessage = "Nh?p m� nh�n vi�n")]
        public string Manv { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Nh?p h? t�n nh�n vi�n")]

        public string Hoten { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Nh?p ph�ng nh�n vi�n")]

        public string Maphong { get; set; }

        [Required(ErrorMessage = "Nh?p l??ng nh�n vi�n")]
        public double? Luong { get; set; }
    }
}
