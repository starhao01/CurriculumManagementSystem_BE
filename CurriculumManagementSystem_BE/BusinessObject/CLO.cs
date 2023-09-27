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
    public class CLO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CLO_id { get; set; }
        [Required] 
        public string CLO_name { get; set; }
        [AllowNull] 
        public string? CLO_description { get; set; }   
    }
}
