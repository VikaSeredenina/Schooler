namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [Key]
        public long id_users { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(100)]
        public string role { get; set; }

        [Required]
        [StringLength(100)]
        public string last_name_user { get; set; }

        [Required]
        [StringLength(100)]
        public string name_user { get; set; }

        [StringLength(100)]
        public string patronymic_user { get; set; }
    }
}
