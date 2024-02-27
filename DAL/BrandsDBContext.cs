using Brands_proj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Brands_proj.DAL
{
    public class BrandsDBContext:DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MIMI\\SQLEXPRESS;database=BrandsDB;trusted_connection=true");
        }
    }
}
