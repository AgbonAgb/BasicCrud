﻿namespace BasicCrud.Data
{
    using BasicCrud.Model;
    using Microsoft.EntityFrameworkCore;
    public class AppDbContext:DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
        //{

        //}
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
