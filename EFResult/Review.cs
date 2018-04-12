namespace EFResult
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Review
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        [Required]
        [StringLength(2000)]
        public string Text { get; set; }

        public int Mark { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual User User { get; set; }

        public virtual Product Product { get; set; }
    }
}
