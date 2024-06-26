namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("class")]
    public partial class _class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public _class()
        {
            schoolboys = new HashSet<schoolboy>();
        }

        [Key]
        public long id_class { get; set; }

        [Required]
        [StringLength(10)]
        public string name_class { get; set; }

        [Required]
        [StringLength(50)]
        public string classroom_teacher { get; set; }

        public int total_number_of_students { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<schoolboy> schoolboys { get; set; }
    }
}
