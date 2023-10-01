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
    public class Combo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int combo_id { get; set; }
        [Required] 
        public string combo_name { get; set; }
        [AllowNull]
        public string? combo_description { get; set;}
        [ForeignKey(nameof(Specialization))]
        public int specialization_id { get; set; }
        [ForeignKey(nameof(Curriculum))]
        public int curriculum_id { get; set; }
        [Required]
        public string combo_status { get; set; }

        public virtual Specialization specialization { get; set; }
        public virtual Curriculum curriculum { get; set; }
        public virtual ICollection<ComboSubject> comboSubjects { get; set; }   
    }
}
