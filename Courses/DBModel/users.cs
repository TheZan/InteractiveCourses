namespace Courses.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            result = new HashSet<result>();
        }

        [Key]
        public int userId { get; set; }

        [Required]
        [StringLength(100)]
        public string surname { get; set; }

        [Required]
        [StringLength(100)]
        public string firstname { get; set; }

        [Column(TypeName = "date")]
        public DateTime dob { get; set; }

        [Required]
        [StringLength(50)]
        public string sex { get; set; }

        public byte[] userPhoto { get; set; }

        [Required]
        [StringLength(100)]
        public string userLogin { get; set; }

        [Required]
        [StringLength(100)]
        public string userPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<result> result { get; set; }
    }
}
