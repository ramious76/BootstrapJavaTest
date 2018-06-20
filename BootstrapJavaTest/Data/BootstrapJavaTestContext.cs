using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BootstrapJavaTest.Models
{
    public class BootstrapJavaTestContext : DbContext
    {
        public BootstrapJavaTestContext (DbContextOptions<BootstrapJavaTestContext> options)
            : base(options)
        {
        }

        public DbSet<BootstrapJavaTest.Models.Person> Person { get; set; }
    }
}
