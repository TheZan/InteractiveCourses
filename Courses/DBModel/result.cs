namespace Courses.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("result")]
    public partial class result
    {
        public int resultId { get; set; }

        public int userId { get; set; }

        public int badgeId { get; set; }

        public virtual badge badge { get; set; }

        public virtual users users { get; set; }
    }
}
