using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreTestInnovar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController
    {
        List<Beer> beers = new List<Beer>{
            new Beer(){ Id= 1,Name = "Beer1", Year = 1981},
            new Beer(){ Id= 2,Name = "Beer2", Year = 2001},
            new Beer(){ Id= 3,Name = "Beer3", Year = 1970},
            new Beer(){ Id= 4,Name = "Beer4", Year = 1999}
        };

        // Get Beers
        [HttpGet]
        public bool GetLinqBeers(){
            var sum=0;

            beers.ForEach(
                beer=>{
                    sum += beer.Year;
                }
            );

            var list90 = new List<Beer>();
            beers.ForEach(
                beer=>{
                    if(beer.Year > 1990){
                        list90.Add(beer);
                    }
                }
            );

            var sum2 = beers.Sum(beer => beer.Year);
            var list91 = beers.Where(beer => beer.Year>1990);
            var sortList = beers.OrderBy(beer => beer.Year);
            beers.OrderByDescending(beer => beer.Year);
            

            Console.WriteLine(sum);
            Console.WriteLine(sum2);

            return true;
        }
    }
}