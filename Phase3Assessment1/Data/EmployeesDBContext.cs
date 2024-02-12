using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase3Assessment1.Models;

namespace Phase3Assessment1
{
    public class EmployeesDBContext : DbContext
    {
        public EmployeesDBContext (DbContextOptions<EmployeesDBContext> options)
            : base(options)
        {
        }

        public DbSet<Phase3Assessment1.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
