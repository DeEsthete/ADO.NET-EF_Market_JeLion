namespace EFResult
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CORP\СикировТ.Categories")]
    public partial class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
