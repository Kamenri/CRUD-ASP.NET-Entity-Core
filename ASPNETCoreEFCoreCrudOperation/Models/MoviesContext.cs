using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreEFCoreCrudOperation.Models
{
    //DbContext is using Microsoft Entity Framework Core via the packages installed
    public class MoviesContext : DbContext
    {
        public MoviesContext()
        {

        }

        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {

        }

        //DbSet correspond to a particular table which will be created via Entity Framework
        public DbSet<Movies> Movies { get; set; }
    }
}
