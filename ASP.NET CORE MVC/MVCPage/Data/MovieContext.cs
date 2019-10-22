using Microsoft.EntityFrameworkCore;
using MVCPage.Models;

namespace MVCPage.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options){}
        public DbSet<Movie> Movie {get;set;}
        public DbSet<Account> Account {get; set;}

    }
}