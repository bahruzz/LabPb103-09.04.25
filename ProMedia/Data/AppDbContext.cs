﻿using Microsoft.EntityFrameworkCore;

namespace ProMedia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) :base(options) { }
       
    }
}
