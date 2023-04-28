using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreTestInnovar.BusinessService;

namespace BarApi.Controllers;
[ApiController]
[Route("[controller]")]
public class BeerController: ControllerBase
{
    
    private BeerBusinessService _beerBusinessService;
    public BeerController(BeerBusinessService beerBusinessService)
    {
        _beerBusinessService = beerBusinessService;
    }

    // Get Beers
    [HttpGet]
    public List<Beer> GetBeers(){
        return _beerBusinessService.GetBeers();
    }

     //Get one beer
    [HttpGet("{id}")]
    public Beer? GetBeer(long id){
        return _beerBusinessService.GetBeer(id);
    }

    //Insert Beer
    [HttpPost]
    public Beer InsertBeer(Beer beer){
        return _beerBusinessService.InsertBeer(beer);
    }

    //Update beer
    [HttpPut]
    public Beer? UpdateBeer(Beer beer){
        return _beerBusinessService.UpdateBeer(beer);
    }

    //Delete beer
    [HttpDelete("{id}")]
    public bool DeleteBeer(long id){
        return _beerBusinessService.DeleteBeer(id);
    }

    [HttpGet("[action]")]
    public List<Beer> GetBeersByYearBefore(int year){
        return _beerBusinessService.GetBeersByYearBefore(year);
    }

    [HttpPost("[action]")]
    public List<Beer> GetBeerByName(string name){
        return _beerBusinessService.GetBeerByName(name);
    }

    [HttpPost("[action]")]
    public List<Beer> GetBeersByBrandId(long brandId){
        return _beerBusinessService.GetBeersByBrandId(brandId);
    }

    [HttpPost("[action]")]
    public List<Beer> GetBeersWhitBrand(){
        return _beerBusinessService.GetBeersWhitBrand();
    }

    //Update Year
    [HttpPost("[action]")]
    public Beer? UpdateYearOfBeer(long beerId, int newYear){
        return _beerBusinessService.UpdateYearOfBeer(beerId, newYear);
    }

    //Get beer names
    [HttpPost("[action]")]
    public List<string> GetBeerNames(){
        return _beerBusinessService.GetBeerNames();
    }
    
    //Get beer names upper case
    [HttpPost("[action]")]
    public List<string> GetBeerNamesUpperCase(){
        return _beerBusinessService.GetBeerNamesUpperCase();
    }
}