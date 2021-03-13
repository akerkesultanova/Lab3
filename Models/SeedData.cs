﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class SeedData
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
                        Director = "Todd Phillips",
                        Genre = "Crime , Drama , Thriller",
                        Title = "Joker",
                        Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/joker_dabf394a-d4f2-4b68-90e2-011ed6b54012_poster.png?d=270x360&q=20",
                        ReleaseDate = new DateTime(2019, 10, 3)
                    },
                    new Movie
                    {
                        Director = "David Leitch",
                        Genre = "Action , Adventure",
                        Title = "Fast & Furious Presents: Hobbs & Shaw",
                        Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/fast-furious-presents-hobbs-shaw_14d1ab4f-c90c-46d1-9e04-f7d69f285ebd_poster.png?d=270x360&q=20",
                        ReleaseDate = new DateTime(2019, 8, 2)
                    },
                    new Movie
                    {
                        Director = "Jon Favreau",
                        Genre = "Adventure , Animation , Drama , Family , Musical",
                        Title = "The Lion King",
                        Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/the-lion-king_3904aadc-3a07-4836-892f-763b2dfdeea3_poster.png?d=270x360&q=20",
                        ReleaseDate = new DateTime(2019, 7, 19)
                    },
                    new Movie
                    {
                        Director = "Joachim Rønning",
                        Genre = "Adventure , Family , Fantasy",
                        Title = "Maleficent: Mistress of Evil",
                        Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/maleficent-mistress-of-evil_c8507e61-a6b3-404d-b8c5-df6f74bc62be_poster.png?d=270x360&q=20",
                        ReleaseDate = new DateTime(2019, 10, 18)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
