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
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );
            mb.Entity<MovieSubmissionModel>().HasData(
                // Seeds starting data into the database
                    new MovieSubmissionModel
                    {
                        MovieId = 1,
                        CategoryId = 1,
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
                        CategoryId = 2,
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
                        CategoryId = 1,
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
