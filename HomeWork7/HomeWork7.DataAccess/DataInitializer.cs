using HomeWork7.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.DataAccess
{
    public class DataInitializer:DropCreateDatabaseAlways<StockContext>
    {
        private List<Product> _products;
        public DataInitializer()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Name = "Вода",
                    Price=150
                },
                new Product
                {
                    Name="Кока Кола",
                    Price = 250
                },
                new Product
                {
                    Name="Спрайт",
                    Price = 250
                }
            };
        }
        protected override void Seed(StockContext context)
        {
            context.Products.AddRange(_products);
            base.Seed(context);
        }
    }
}
