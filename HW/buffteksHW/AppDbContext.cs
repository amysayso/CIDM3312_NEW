using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace buffteksHW
{
    //here, we extend the DbContext class with our own class 'AppDbContext'
    public class AppDbContext : DbContext
    {
        //The connection string is used by the SQL Server database provider to find the database
        private const string ConnectionString = @"Data Source=buffteksHW.db";

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
        {
            //Using the SQLite database provider’s UseSqlServer command sets up the options ready for creating the applications’s DBContext
            optionsBuilder.UseSqlite(ConnectionString); //#B
        }        

        public DbSet <Student> Students { get; set; }    

        public DbSet <Client> Clients { get; set; } 

        public DbSet <Advisor> Advisors {get; set; }

        public DbSet <Team> Teams {get; set;}

        public DbSet <Project> Projects {get; set;}

        public DbSet <Organization> Organizations {get; set;}

        public DbSet <StudentTeam> StudentTeam {get; set;}


        public DbSet <ClientOrg> ClientOrg {get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentTeam>()
            .HasKey(st => new {st.TeamID, st.StudentID});
        
        modelBuilder.Entity<ClientOrg>()
            .HasKey(co => new {co.ClientID, co.OrganizationID});
    }
}
}
      

