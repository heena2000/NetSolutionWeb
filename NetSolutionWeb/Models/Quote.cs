using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetSolutionWeb.Models
{
    public class Quote
    {
        [Key]
        public int QuoteID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string EmailID { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactNo { get; set; }

        [Required]
        public int Budget { get; set; }

        [Required]
        [StringLength(2000)]
        public string QuoteText { get; set; }
    }
}
