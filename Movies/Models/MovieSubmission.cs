using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class MovieSubmissionModel
    {
        // Sets a key for the record in the database
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }

        // Makes Rating a required field
        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }
        public string Lent { get; set; }

        // Limits the input for the Notes field to 25 characters
        [MaxLength(25)]
        public string Notes { get; set; }



    }
}
