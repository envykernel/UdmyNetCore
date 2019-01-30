using Microsoft.EntityFrameworkCore;
using UdmyDotNet.API.Models;

namespace UdmyDotNet.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Value>  Values { get; set; }
    }
}