namespace Test2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongNhan")]
    public partial class CongNhan
    {
        [Key]
        [StringLength(10)]
        public string Macn { get; set; }

        [StringLength(10)]
        public string Hoten { get; set; }

        [StringLength(10)]
        public string Donvi { get; set; }

        [StringLength(10)]
        public string Bacluong { get; set; }
    }
}
