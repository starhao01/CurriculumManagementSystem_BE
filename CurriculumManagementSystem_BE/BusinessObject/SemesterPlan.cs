﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class SemesterPlan
    {
        [ForeignKey(nameof(Curriculum))]
        public int curriculum_id { get; set; }
        [ForeignKey(nameof(Semester))]
        public int semester_id { get; set; }
        [Required]
        public string semester_plan_code { get; set; }
        [Required]
        public string semester_plan_name { get; set; }

        public virtual Curriculum curriculum { get; set; }
        public virtual Semester semester { get; set; }
    }
}
