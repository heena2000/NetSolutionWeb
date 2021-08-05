using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetSolutionWeb.Models
{
    public class Story
    {
        [Key]
        public int StoryID { get; set; }

        [Required]
        [StringLength(200)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(200)]
        public string TagLine { get; set; }

        [Required]
        [StringLength(200)]
        public string Industry { get; set; }

        [Required]
        [StringLength(2000)]
        public string Features { get; set; }

        [Required]
        [StringLength(50)]
        public string ExtName { get; set; }

        [NotMapped]
        public ImageUpload FileUpload { get; set; }
    }
}
