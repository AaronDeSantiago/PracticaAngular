using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class SpaContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Deparments { get; set; }
    }
}