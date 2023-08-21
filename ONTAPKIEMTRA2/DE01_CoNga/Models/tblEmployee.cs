namespace DE01_CoNga.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployee")]
    public partial class tblEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Không được để trống")]
        public int eid { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Không được để trống")]
        public string name { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public int? age { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Không được để trống")]
        public string addr { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public int? salary { get; set; }

        [StringLength(50)]
        

        public string image { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public int? deptid { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public virtual tblDept tblDept { get; set; }
    }
}
