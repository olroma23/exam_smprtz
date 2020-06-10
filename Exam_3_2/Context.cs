using Exam_3_2.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_3_2
{
    public class Context : DbContext
    {
        public DbSet<Goods> Products { get; set; }

        public DbSet<Goods> Storages { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
