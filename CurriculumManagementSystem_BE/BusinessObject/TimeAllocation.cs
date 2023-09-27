using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class TimeAllocation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int time_allocation_id { get; set; }
        [Required]
        public string time_allocation_description { get; set; }

    }
}
