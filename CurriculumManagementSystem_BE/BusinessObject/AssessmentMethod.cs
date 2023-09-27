using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class AssessmentMethod
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int assessment_method_id { get; set; }
        [Required]
        public string assessment_method_component { get; set; }
        [Required]
        public string assessment_method_type { get; set; }
        [AllowNull]
        public string? assessment_method_description { get; set; }
    }
}
