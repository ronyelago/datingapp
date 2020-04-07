using Microsoft.EntityFrameworkCore;
using datingapp.api.Models;
using DatingApp.API.Models;

namespace datingapp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Values {get; set;}
        public DbSet<User> Users { get; set; }
    }
}