
using Skeleton.Models;
using Microsoft.EntityFrameworkCore;

namespace Skeleton.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<User> Users { get; set; }


    }
}