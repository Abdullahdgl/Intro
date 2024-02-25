using Kodlama.ioProject2.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioProject2.DataAccess.Concrete.EntityFrameWork
{
    public class KodlamaContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=KodlamaDB; Trusted_connection=true");
        }
        public DbSet<Course> courses { get; set; }
    }
}
