using ClarkCodingChallenge.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClarkCodingChallenge.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}