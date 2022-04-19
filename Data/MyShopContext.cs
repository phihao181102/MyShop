using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyShop.Models;

namespace MyShop.Data
{
    public class MyShopContext : DbContext
    {
        public MyShopContext (DbContextOptions<MyShopContext> options)
            : base(options)
        {
        }

        public DbSet<MyShop.Models.Shop> Shop { get; set; }
    }
}
