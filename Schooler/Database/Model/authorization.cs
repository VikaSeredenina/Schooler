namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("authorization")]
    public partial class authorization
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(255)]
        public string login { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        public virtual User User { get; set; }
    }
}
