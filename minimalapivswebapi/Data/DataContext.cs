﻿using Microsoft.EntityFrameworkCore;

namespace minimalapivswebapi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
    }
}
