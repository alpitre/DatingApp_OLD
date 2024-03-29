
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
  public class DataContext : DbContext
  {
    // public DataContext(DbContextOptions<DbContext> options) : base (options)
     public DataContext(DbContextOptions options) : base (options)
    {

    }
    public DbSet<Value> Values { get; set; }
    public DbSet<User> Users { get; set; }
  }

}