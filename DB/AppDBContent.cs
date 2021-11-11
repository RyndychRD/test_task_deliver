using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_task_deliver_RyndychRD.Models;

namespace test_task_deliver_RyndychRD
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> orders{set;get;}

    }
}
