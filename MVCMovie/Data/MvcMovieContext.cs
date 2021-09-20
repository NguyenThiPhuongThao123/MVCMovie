using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;

namespace MVCMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
           : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
