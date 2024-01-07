using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
    }
}
