using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;

namespace NetCoreTestInnovar.DataService;

public class BeerDataService
{
    private Context _context;

    public BeerDataService(Context context){
        _context = context;
    }

    public List<Beer> GetBeers(){
        return _context.Beers.ToList();
    }

    public Beer? GetBeer(long id){
        var beer = _context.Beers.Find(id);
        return beer;
    }

    public Beer InsertBeer(Beer beer){
        _context.Beers.Add(beer);
        _context.SaveChanges();
        return beer;
    }

    public Beer? UpdateBeer(Beer beer){
        var beerDbo = _context.Beers.Find(beer.BeerId);

        if(beerDbo == null) return null;

        beerDbo.Name = beer.Name;
        _context.SaveChanges();
        return beerDbo;
    }

    public bool DeleteBeer(long id){
        var beerDbo = _context.Beers.Find(id);
        if(beerDbo==null) return false;

        _context.Beers.Remove(beerDbo);
        _context.SaveChanges();
        return true;
    }
}
