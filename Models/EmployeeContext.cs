using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNet.Models
{
    public class EmployeeContext: DbContext             //Classe conexão com o banco
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) 
        { 
        }
        
        public DbSet<Employee> Employees { get; set; }          //Injeção de dependencia - Classe
    }
}
