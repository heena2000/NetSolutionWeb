using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetSolutionWeb.Models
{
    public class Career
    {
        [Key]
        public int CareerID { get; set; }

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
        [StringLength(50)]
        public string ExtName { get; set; }

        [NotMapped]
        public ImageUpload FileUpload { get; set; }
    }
}
