namespace CoursesAdmin.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("badge")]
    public partial class badge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public badge()
        {
            result = new HashSet<result>();
        }

        public int badgeId { get; set; }

        [Required]
        [StringLength(150)]
        public string badgeName { get; set; }

        public byte[] badgeImage { get; set; }

        public int? moduleId { get; set; }

        public virtual module module { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<result> result { get; set; }
    }
}
