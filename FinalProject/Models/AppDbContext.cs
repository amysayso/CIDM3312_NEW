using System;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }
    }


    
}