using CleanMovie.Application;
using CleanMovie.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;
        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }


        public Movie CreateMovie(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
            return movie;

        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
    }

}
