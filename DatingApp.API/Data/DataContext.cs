using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        // prop to tell EF about our entities (Value model/entity in our case):
        // convention pluralise the names of the entities value -> values(to be table name)      
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }

    }
}