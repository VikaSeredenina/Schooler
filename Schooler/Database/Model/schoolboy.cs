namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("schoolboy")]
    public partial class schoolboy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public schoolboy()
        {
            attendance = new HashSet<attendance>();
            QRKod = new HashSet<QRKod>();
        }

        [Key]
        public Guid guid { get; set; }

        [Required]
        [StringLength(100)]
        public string surname { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string patronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_birth { get; set; }

        [StringLength(250)]
        public string parents_email { get; set; }

        public long id_class { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }

        [StringLength(11)]
        public string parents_phone_number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attendance> attendance { get; set; }

        public virtual _class _class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QRKod> QRKod { get; set; }
    }
}
