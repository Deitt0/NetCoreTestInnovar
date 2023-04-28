using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using Microsoft.EntityFrameworkCore;

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

    public List<Beer> GetBeersByYearBefore(int year){
        return _context.Beers.Where(beer => beer.Year > year).ToList();
    }

    public List<Beer> GetBeerByName(string name){
        return _context.Beers.Where(beer => beer.Name == name).ToList();
    }

    public List<Beer> GetBeersByBrandId(long brandId){
        return _context.Beers.Where(beer=>beer.BrandId == brandId).ToList();
    }

    public List<Beer> GetBeersWhitBrand(){
        return _context.Beers.Include(beer=>beer.Brand).ToList();
    }

    public Beer? UpdateYearOfBeer(long idBrand, int newYear){
        var beer = GetBeer(idBrand);
        if(beer == null) return null;
        beer.Year = newYear;
        _context.SaveChanges();
        return beer;
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
        beerDbo.Year = beer.Year;
        beerDbo.BrandId = beer.BrandId;
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
