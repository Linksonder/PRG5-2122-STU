using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KleineDemo.Models
{
    public class MyContext : DbContext
    {
            
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

    }
}
