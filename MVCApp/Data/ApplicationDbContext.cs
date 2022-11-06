using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("connectionString")
        {

        }
       public DbSet<Student> Students { get; set; }
    }
}