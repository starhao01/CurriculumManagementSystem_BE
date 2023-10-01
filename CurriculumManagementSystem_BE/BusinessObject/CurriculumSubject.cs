﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CurriculumSubject
    {
        [ForeignKey("Subject")]
        public int subject_id { get; set; }
        [ForeignKey("Curriculum")]
        public int curriculum_id { get; set; }
        [Required]
        public int term_no { get; set; }

        public virtual Curriculum Curriculums { get; set; }
        public virtual Subject Subjects { get; set; }
    }
}
