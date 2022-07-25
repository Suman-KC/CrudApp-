using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CrudApp.Models
{
    /* 
     1.install entityframework core from managenuget package
     2.create model class and database context class.
     3. create connection string and add dependency in startup.cs file.
    4. Create controller with views
    5. Create Migration by using this command "add-migration IntialCreate"
    6. Then type "update-database" command
     
     
     */
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options) //options for databaseprovider
        {

        }
        public DbSet<Employee> Employees { get; set; }//type of employees is employee& automatically stored in table employee
    }
}
