using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using NetCoreTestInnovar.DataService;

namespace NetCoreTestInnovar.BusinessService;

public class BeerBusinessService
{
    private BeerDataService _beerDataService;
    public BeerBusinessService(BeerDataService beerDataService){
        _beerDataService = beerDataService;
    }
    public List<Beer> GetBeers(){
        var beerList = _beerDataService.GetBeers();
        return beerList;
    }

    public Beer? GetBeer(long id){
        var beer = _beerDataService.GetBeer(id);
        return beer;
    }

    public Beer InsertBeer(Beer beer){
        var beerInserted = _beerDataService.InsertBeer(beer);
        return beerInserted;
    }

    public Beer? UpdateBeer(Beer beer){
        return _beerDataService.UpdateBeer(beer);
    }

    public bool DeleteBeer(long id){
        return _beerDataService.DeleteBeer(id);
    }

    public List<Beer> GetBeersByYearBefore(int year){
        return _beerDataService.GetBeersByYearBefore(year);
    }

    public List<Beer> GetBeerByName(string name){
        return _beerDataService.GetBeerByName(name);
    }

    public List<Beer> GetBeersByBrandId(long brandId){
        return _beerDataService.GetBeersByBrandId(brandId);
    }

    public List<Beer> GetBeersWhitBrand(){
        return _beerDataService.GetBeersWhitBrand();
    }

    public Beer? UpdateYearOfBeer(long beerId, int newYear){
        return _beerDataService.UpdateYearOfBeer(beerId, newYear);
    }

    public List<string> GetBeerNames(){
        //Get all bers
        var beerList = _beerDataService.GetBeers();

        //Get beer names
        //Whit foreach
        List<string> beerNames = new List<string>();
        foreach(var beer in beerList){
            beerNames.Add(beer.Name);
        }        
        //Whit LINQ
        //beerNames = beerList.Select(beer=>beer.Name);

        //Return beer names
        return beerNames;
    }

    public List<string> GetBeerNamesUpperCase(){
        var beerNames = GetBeerNames();
        List<string> beerNamesUpper = new List<string>();
        foreach(var beerName in beerNames){
            beerNamesUpper.Add(beerName.ToUpper());
        }
        return beerNamesUpper;
    }

}
