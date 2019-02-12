using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VideoTracker.Model
{
    public class VideoTrackerContext: DbContext
    {
        public VideoTrackerContext(DbContextOptions<VideoTrackerContext> options)
            : base(options)
        {

        }

        public DbSet<Video> Videos { get; set; }
    }
}
