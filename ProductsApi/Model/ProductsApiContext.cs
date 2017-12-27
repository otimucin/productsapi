using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductsApi.Model
{
    public class ProductsApiContext : DbContext
    {
        public ProductsApiContext(DbContextOptions<ProductsApiContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
