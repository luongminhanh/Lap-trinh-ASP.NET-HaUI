﻿namespace BaiTap10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [DisplayName("Mã rượu")]
        [Required(ErrorMessage = "Mã rượu không được để trống!")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Tên rượu không được để trống!")]
        [StringLength(50)]
        [DisplayName("Tên rượu")]

        public string ProductName { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Mô tả")]

        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Giá nhập")]
        [Required(ErrorMessage = "Giá nhập không được để trống!")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Giá bán")]
        [Required(ErrorMessage = "Giá bán không được để trống!")]
        public decimal Price { get; set; }
        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống!")]
        public int Quantity { get; set; }

        [StringLength(20)]
        [DisplayName("Năm sản xuất")]
        public string Vintage { get; set; }

        [Required(ErrorMessage = "Danh mục không được để trống!")]
        [StringLength(10)]
        public string CatalogyID { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Vùng không được để trống!")]
        [StringLength(100)]
        [DisplayName("Vùng")]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}
