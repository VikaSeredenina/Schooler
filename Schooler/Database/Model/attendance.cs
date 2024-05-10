namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("attendance")]
    public partial class attendance
    {
        [Key]
        public long id_attendance { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public DateTime? arrival_time { get; set; }

        public DateTime? time_of_departure { get; set; }

        public bool status { get; set; }

        public Guid guid { get; set; }

        public virtual schoolboy schoolboy { get; set; }
    }
}
