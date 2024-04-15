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

        public DateTime time_of_entry { get; set; }

        public bool status { get; set; }

        public long id_lesson { get; set; }

        public Guid guid_schoolboy { get; set; }

        public DateTime? time_of_deportation { get; set; }

        public virtual lesson lesson { get; set; }

        public virtual schoolboy schoolboy { get; set; }
    }
}
