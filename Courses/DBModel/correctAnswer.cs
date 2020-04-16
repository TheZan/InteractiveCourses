namespace Courses.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("correctAnswer")]
    public partial class correctAnswer
    {
        public int correctAnswerId { get; set; }

        public int question { get; set; }

        public int answer { get; set; }

        public virtual answer answer1 { get; set; }

        public virtual question question1 { get; set; }
    }
}
