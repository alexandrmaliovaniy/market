using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace market.Models
{
    public class ClothesContext : DbContext
    {
        public ClothesContext(DbContextOptions<ClothesContext> options):base(options)
        {

        }
        public DbSet<Clothes> Cloth { get; set; }
    }
}
