using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "PG-13",
                    Director = "Rob Reiner",
                    Description = "A romantic comedy about two best friends navigating love in New York City."
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG",
                    Director = "Ivan Reitman",
                    Description = "A team of specialists is hired to catch ghosts in New York City."
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG",
                    Director = "Ivan Reitman",
                    Description = "The ghostbusters return to battle supernatural forces in New York City."
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "Not Rated",
                    Director = "Howard Hawks",
                    Description = "A sheriff and a gunslinger team up to hold off a siege."
                },
                new Movie
                {
                    Title = "Oppenheimer",
                    ReleaseDate = DateTime.Parse("2023-7-21"),
                    Genre = "Drama",
                    Price = 15.99M,
                    Rating = "R",
                    Director = "Christopher Nolan",
                    Description = "The story of American scientist J. Robert Oppenheimer and his role in the development of the atomic bomb."
                },
                new Movie
                {
                    Title = "Barbie",
                    ReleaseDate = DateTime.Parse("2023-7-21"),
                    Genre = "Comedy",
                    Price = 14.99M,
                    Rating = "PG-13",
                    Director = "Greta Gerwig",
                    Description = "Barbie suffers a crisis that leads her to question her world and her existence."
                },
                new Movie
                {
                    Title = "The Little Mermaid",
                    ReleaseDate = DateTime.Parse("2023-5-26"),
                    Genre = "Adventure",
                    Price = 16.99M,
                    Rating = "PG",
                    Director = "Rob Marshall",
                    Description = "A young mermaid makes a deal with a sea witch to trade her voice for human legs."
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Genre = "Sci-Fi",
                    Price = 12.99M,
                    Rating = "PG-13",
                    Director = "Christopher Nolan",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea."
                },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Genre = "Drama",
                    Price = 10.99M,
                    Rating = "R",
                    Director = "Frank Darabont",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
                }
            );
            context.SaveChanges();
        }
    }
}