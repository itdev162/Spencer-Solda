using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuidler)
        {
            modelBuidler.Entity<Value>().HasData(
                new Value { Id = 1, Name = "Value1" },
                new Value { Id = 2, Name = "Value2" },
                new Value { Id = 3, Name = "Value3" }
            );
        }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

    }








}