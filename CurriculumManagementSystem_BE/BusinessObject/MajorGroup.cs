﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class MajorGroup
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int major_id { get; set;}
        [Required, MaxLength(10)]
        public string major_code { get; set;}
        [Required, MaxLength(50)]
        public string major_name { get; set;}
        [Required]
        public string major_status { get; set;}
    }
}
