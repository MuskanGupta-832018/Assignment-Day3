using EntityframeworkWebApp.Models;
using EntityframeworkWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace EntityframeworkWebApp.Context
{
    public class studentcontext:DbContext
    {
        public studentcontext()
        {

        }
        public studentcontext(DbContextOptions<studentcontext> options)
        : base(options) { }

        public DbSet<Students> students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=StudentsDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
