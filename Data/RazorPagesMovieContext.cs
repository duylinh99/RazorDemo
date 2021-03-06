using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPagesMovie;

    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }

        public DbSet<RazorPagesMovie.Models.Students> Students { get; set; }

        public DbSet<RazorPagesMovie.Models.Person> Person { get; set; }

        public DbSet<RazorPagesMovie.Employee> Employee { get; set; }

        public DbSet<RazorPagesMovie.Lecture> Lecture { get; set; }


    }
