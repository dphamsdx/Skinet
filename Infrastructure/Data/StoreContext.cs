using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        //prop
        public DbSet<Product> Products { get; set; }

        //ctor
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

    }
}