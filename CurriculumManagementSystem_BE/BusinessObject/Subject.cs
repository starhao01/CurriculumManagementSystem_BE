using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Subject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int subject_id { get; set; }
        [Required]
        public string subject_code { get; set; }
        [Required]
        public string subject_name { get; set;}
        [Required]
        public string english_subject_name { get; set;}
        [Required]
        public int term_no { get; set; }
        [Required]
        public int credit { get; set; }
        [Required]
        public string option { get; set; }
        [Required]
        public string subject_status { get; set; }
    }
}
