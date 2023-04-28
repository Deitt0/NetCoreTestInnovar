using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreTestInnovar.BusinessService;

namespace BarApi.Controllers
{
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
        return null;
    }

    //Insert Beer
    [HttpPost]
    public Beer InsertBeer(Beer beer){
        return null;
    }

    //Update beer
    [HttpPut]
    public Beer? UpdateBeer(Beer beer){
        return null;
    }

    //Delete beer
    [HttpDelete("{id}")]
    public bool DeleteBeer(long id){
        return true;
    }

}
}