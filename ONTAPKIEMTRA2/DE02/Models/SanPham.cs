namespace DE02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Mã sản phẩm")]
        [Required(ErrorMessage ="Mã sản phẩm không được để trống")]
        public string Masp { get; set; }

        [StringLength(50)]
        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage ="Tên sản phẩm không được để trống")]
        public string Tensp { get; set; }

        [StringLength(50)]
        [DisplayName("Đơn vị tính")]
        [Required(ErrorMessage = "Đơn vị không được để trống")]
        public string Donvitinh { get; set; }

        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống")]
        public int? Soluong { get; set; }
    }
}
