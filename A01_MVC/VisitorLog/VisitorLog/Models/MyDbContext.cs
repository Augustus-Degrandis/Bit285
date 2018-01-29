using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VisitorLog.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("VisitorLog") { }
        
        public DbSet<Visitor> Visitors { get; set; }

    }
}