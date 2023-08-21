namespace De01_img.Models
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("ID")]
        [Required(ErrorMessage = "Id khong duoc trong")]
        public int Pid { get; set; }

        [DisplayName("CategoryID")]
        [Required(ErrorMessage = "CategoryID khong duoc trong")]
        public int Categoryid { get; set; }

        //[Required]
        [StringLength(250)]
        [DisplayName("ProdName")]
        [Required(ErrorMessage = "Khong duoc trong")]
        public string ProdName { get; set; }

        [StringLength(50)]
        [DisplayName("MetaTitle")]
        [Required(ErrorMessage = "Khong duoc trong")]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        [DisplayName("Description")]
        [Required(ErrorMessage = "Khong duoc trong")]
        public string Description { get; set; }

        [StringLength(550)]
        [DisplayName("Image")]
        [Required(ErrorMessage = "Khong duoc trong")]
        public string ImagePath { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Khong duoc trong")]
        public decimal Price { get; set; }
    }
}
