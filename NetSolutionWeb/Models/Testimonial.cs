using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetSolutionWeb.Models
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }

        [Required]
        [StringLength(200)]
        public string PersonName { get; set; }

        [Required]
        [StringLength(200)]
        public string Designation { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(2000)]
        public string TestimonialText { get; set; }
    }
}
