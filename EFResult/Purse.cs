namespace EFResult
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CORP\ПавловЕ.Purses")]
    public partial class Purse
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool IsDeleted { get; set; }

        public int Cash { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
