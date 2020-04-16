namespace Courses.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("submodule")]
    public partial class submodule
    {
        public int submoduleId { get; set; }

        [Required]
        public string submoduleName { get; set; }

        [Required]
        public string submoduleText { get; set; }

        public byte[] submoduleImage { get; set; }

        public int? moduleId { get; set; }

        public virtual module module { get; set; }
    }
}
