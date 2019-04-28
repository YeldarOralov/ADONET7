using HomeWork7.Models;
using System;
using System.Data.Entity;
using System.Linq;
namespace HomeWork7.DataAccess
{
    public class StockContext : DbContext
    {
        public StockContext()
            : base("name=StockContext")
        {
            Database.SetInitializer<StockContext>(new DataInitializer());
        }
        public DbSet<Product> Products { get; set; }
    }
}