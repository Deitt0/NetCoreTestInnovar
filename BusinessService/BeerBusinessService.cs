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
        return _beerDataService.GetBeers();
    }
}
