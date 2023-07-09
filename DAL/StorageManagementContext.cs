using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StorageManagementContext:DbContext
    {
        public StorageManagementContext(DbContextOptions<StorageManagementContext> options):base(options)
        {
            
        }
        public DbSet<MVCProject.Entities.Concrete.Column> Columns { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Storage> Storages { get; set; }




    }
}
