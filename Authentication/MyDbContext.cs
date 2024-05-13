using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MyConnectionString") { }

        public DbSet<Tables.Users>Users { get; set; }

    }
}
