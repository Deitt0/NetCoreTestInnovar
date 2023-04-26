using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BarApi.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options){

        }
        public DbSet<Beer> Beers {get;set;}
    }
}