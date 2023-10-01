using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class PLOMapping
    {
        [ForeignKey(nameof(PLOs))]
        public int PLO_id { get; set; }
        [ForeignKey(nameof(Subject))]
        public int subject_id { get; set; }

        public virtual PLOs PLO { get; set; }
        public virtual Subject Subjects { get; set; }
    }
}
