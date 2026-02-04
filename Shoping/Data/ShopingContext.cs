using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shoping.Models;
using Shoping.Models.Domain;

namespace Shoping.Data
{
    public class ShopingContext : DbContext
    {
        public ShopingContext (DbContextOptions<ShopingContext> options): base(options)
        {
        }

        public DbSet<Products> Products { get; set; } = default!;
        public DbSet<DifficultyModel> Difficulty { get; set; } = default!;
        public DbSet<RegionModel> Region { get; set; } = default!;
        public DbSet<WalkModel> Walk { get; set; } = default!;
    }
}
