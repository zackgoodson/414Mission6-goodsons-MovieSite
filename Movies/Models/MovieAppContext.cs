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
                        Category = "Sci-Fi",
                        Title = "Star Wars: Attack of the Clones",
                        Year = 2002,
                        Director = "George Lucas",
                        Rating = "PG",
                        Edited = false,
                        Lent = "No",
                        Notes = ""
                    },
                    new MovieSubmissionModel
                    {
                        MovieId = 2,
                        Category = "Sci-Fi",
                        Title = "Jojo Rabbit",
                        Year = 2019,
                        Director = "Taika Watiti",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "No",
                        Notes = ""
                    },
                    new MovieSubmissionModel
                    {
                        Category = "Sci-Fi",
                        Title = "Interstellar",
                        Year = 2011,
                        Director = "Christopher Nolan",
                        MovieId = 3,
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "No",
                        Notes = ""
                    }
                );
        }
    
    }
}
