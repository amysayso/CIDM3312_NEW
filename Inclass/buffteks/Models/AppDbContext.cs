using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace buffteks.Models
{
    //here, we extend the DbContext class with our own class "AppDbContext" 
    public class AppDbContext : DbContext
    {

        //the connection string is used by the SQL server database provider to find the database
        private const string ConnectionString = @"Data Source=buffteks.db";

        //The connection string is used by the SQL Server database provider to find the database
        //private const string is used by the SQL Server database provider 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //using the SQLite database provider's UseSqlServer command sets up the options ready for creating the application
            optionsBuilder.UseSqlite(ConnectionString);
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Client> Client {get; set; }
    }
}