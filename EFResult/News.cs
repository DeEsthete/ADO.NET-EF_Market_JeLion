namespace EFResult
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CORP\СикировТ.News")]
    public partial class News
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Required]
        [StringLength(7000)]
        public string NewsText { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
