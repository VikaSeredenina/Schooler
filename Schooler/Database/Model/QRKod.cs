namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QRKod")]
    public partial class QRKod
    {
        [Key]
        public long id_QRKod { get; set; }

        [Required]
        [StringLength(100)]
        public string content { get; set; }

        public Guid id_schoolboy { get; set; }

        public virtual schoolboy schoolboy { get; set; }
    }
}
