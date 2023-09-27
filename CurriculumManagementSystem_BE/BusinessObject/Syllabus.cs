﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Syllabus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int syllabus_id { get; set; }
        [Required]
        public string document_type { get; set; }
        [Required]
        public int decision_No { get; set; }
        [Required]
        public int degree_level { get; set; }
        [Required]
        public string syllabus_description { get; set; }
        [Required]
        public string student_task { get; set; }
        [AllowNull]
        public string? syllabus_tool { get; set; }
        [AllowNull]
        public string? syllabus_note { get; set; }
        [Required]
        public decimal min_GPA_to_pass { get; set; }
        [Required]
        public int scoring_scale { get; set; }
        [Required]
        public DateTime approved_date { get; set; }
        [Required]
        public string syllabus_status { get; set; }
    }
}
