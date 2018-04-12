namespace EFResult
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CORP\СикировТ.Messages")]
    public partial class Message
    {
        public int Id { get; set; }

        public int ThemeId { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(5000)]
        public string MessageText { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public virtual Theme Theme { get; set; }

        public virtual User User { get; set; }
    }
}
