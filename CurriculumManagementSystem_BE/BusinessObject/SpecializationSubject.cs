using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class SpecializationSubject
    {
        [ForeignKey(nameof(Specialization))]
        public int specialization_id { get; set; }
        [ForeignKey(nameof(Subject))]
        public int subject_id { get; set; }

        public virtual Specialization specialization { get; set; }  
        public virtual Subject subject { get; set; }
    }
}
