using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieAppContext : DbContext
    {
        // Constructor
        public MovieAppContext (DbContextOptions<MovieAppContext> options) : base(options)
        {
            //leaving this blank for now
        }

        public DbSet<MovieSubmissionModel> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieSubmissionModel>().HasData(
                // Seeds starting data into the database
                    new MovieSubmissionModel
                    {
                        MovieId = 1,
                        Rating = "PG",
                        Edited = false,
                        Lent = "No",
                        Notes = "Star Wars: Attack of the Clones"
                    },
                    new MovieSubmissionModel
                    {
                        MovieId = 2,
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "No",
                        Notes = "Jojo Rabbit"
                    },
                    new MovieSubmissionModel
                    {
                        MovieId = 3,
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "No",
                        Notes = "Interstellar"
                    }
                );
        }
    
    }
}
