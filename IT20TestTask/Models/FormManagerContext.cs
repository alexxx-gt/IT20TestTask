using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IT20TestTask.Models
{
    public class FormManagerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Passing> Passings { get; set; }
        
    }
}