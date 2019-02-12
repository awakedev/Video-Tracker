using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VideoTracker.Model
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideoTrackerContext(
                serviceProvider.GetRequiredService<DbContextOptions<VideoTrackerContext>>()))
            {
                if (context.Videos.Any())
                {
                    return;
                }

                context.Videos.AddRange(
                    new Video
                    {
                        Title = "Die Hard",
                        Link = "https://www.youtube.com",
                        Genre = "Movie",
                        Watched = true
                    },
                    new Video
                    {
                        Title = "Die Hard 2",
                        Link = "https://www.youtube.com",
                        Genre = "Movie",
                        Watched = true
                    },
                    new Video
                    {
                        Title = "Die Hard 3",
                        Link = "https://www.youtube.com",
                        Genre = "Movie",
                        Watched = true
                    },
                    new Video
                    {
                        Title = "Die Hard 4",
                        Link = "https://www.youtube.com",
                        Genre = "Movie",
                        Watched = true
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}