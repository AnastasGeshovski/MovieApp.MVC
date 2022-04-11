
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;


namespace MovieApp.Models
{
    public class MovieAppDbContext : DbContext
    {
        public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MovieApp.Models.Movie> Movie { get; set; }
    }
}