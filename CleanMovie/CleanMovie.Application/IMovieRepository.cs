using CleanMovie.Domain;
using System.Collections.Generic;


namespace CleanMovie.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
    }

}
