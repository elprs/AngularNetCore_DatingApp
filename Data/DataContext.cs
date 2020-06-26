using Microsoft.EntityFrameworkCore;
using AngularNetCore_DatingApp.Models;

namespace AngularNetCore_DatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}

        public DbSet<Value> Values { get; set; }
    }
}