using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BarApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeerController: ControllerBase
    {
    private Context _context;
    public BeerController(Context context)
    {
        _context = context;
    }

    // Get Beers
    [HttpGet]
    public IEnumerable<Beer> GetBeers(){
        return _context.Beers.ToList();
    }

    //Get one beer
    [HttpGet("{id}")]
    public Beer? GetBeer(long id){
        var beer = _context.Beers.Find(id);
        return beer;
    }

    //Insert Beer
    [HttpPost]
    public Beer InsertBeer(Beer beer){
        _context.Beers.Add(beer);
        _context.SaveChanges();
        return beer;
    }

    //Update beer
    [HttpPut]
    public Beer? UpdateBeer(Beer beer){
        var beerDbo = _context.Beers.Find(beer.Id);

        if(beerDbo == null) return null;

        beerDbo.Name = beer.Name;
        _context.SaveChanges();
        return beerDbo;
    }

    //Delete beer
    [HttpDelete("{id}")]
    public bool DeleteBeer(long id){
        var beerDbo = _context.Beers.Find(id);
        if(beerDbo==null) return false;

        _context.Beers.Remove(beerDbo);
        _context.SaveChanges();
        return true;
    }

    }
}