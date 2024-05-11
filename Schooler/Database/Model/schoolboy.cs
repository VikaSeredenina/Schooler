namespace Schooler.Database.Model
{
    using Microsoft.SqlServer.Server;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class schoolboy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public schoolboy()
        {
            attendances = new HashSet<attendance>();
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

        [Required]
        [StringLength(200)]
        public string surname_NP_parents { get; set; }

        [Required]
        [StringLength(100)]
        public string parents_email { get; set; }

        [StringLength(20)]
        public string parents_phone_number { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }

        [StringLength(100)]
        public string QR_kod { get; set; }
        public string parent_telegramm_id { get; set; }

        public long id_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attendance> attendances { get; set; }

        public virtual _class _class { get; set; }
    }
}
