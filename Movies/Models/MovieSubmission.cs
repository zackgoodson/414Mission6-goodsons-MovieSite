using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class MovieSubmissionModel
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }
        public string Lent { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }



    }
}
