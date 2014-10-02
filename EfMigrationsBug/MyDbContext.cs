using EfMigrationsBug.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMigrationsBug
{
    public class MyDbContext : DbContext
    {
        public DbSet<Foo> Foo { get; set; }
    }
}
