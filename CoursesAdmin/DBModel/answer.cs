namespace CoursesAdmin.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("answer")]
    public partial class answer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public answer()
        {
            correctAnswer = new HashSet<correctAnswer>();
        }

        public int answerId { get; set; }

        [Required]
        public string answerText { get; set; }

        public int questionId { get; set; }

        public virtual question question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<correctAnswer> correctAnswer { get; set; }
    }
}
