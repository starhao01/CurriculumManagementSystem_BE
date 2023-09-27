using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BusinessObject
{
    public class Session
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int schedule_id { get; set; }
        [Required]
        [StringLength(50)]
        public string schedule_content { get; set; }
        [Required]
        public string ITU { get; set; }
        [Required]
        public long schedule_student_task { get; set; }
        [Required]
        public string student_material { get; set; }
        [Required]
        public string lecturer_material { get; set;}
        [Required]
        public long schedule_lecturer_task { get; set; }
        [AllowNull]
        public string? student_material_link { get; set; }
        [AllowNull]
        public string? lecturer_material_link { get; set; }
    }
}