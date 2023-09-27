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
    public class Material
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int material_id { get; set; }
        [Required]
        public string material_description { get; set;}
        [AllowNull]
        public string? material_purpose { get; set;}
        [AllowNull]
        public string? material_ISBN { get; set;}
        [Required]
        public string material_type { get; set;}
        [AllowNull]
        public string? material_note { get; set;}
        [AllowNull]
        public string? material_author { get; set;}
        [AllowNull]
        public string? material_publisher { get; set;}
        [AllowNull]
        public DateTime? material_published_date { get; set;}
        [AllowNull]
        public string? material_edition { get; set;} 
    }
}
