using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndInnovarPracticantes.Controllers;

[ApiController]
[Route("[controller]")]
public class BrandController: ControllerBase
{
    private Context _context;
    public BrandController(Context context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IEnumerable<Brand> GetBrands(){
        return _context.Brands.ToList();
    }

    //Get one Brand
    [HttpGet("{id}")]
    public Brand? GetBrand(long id){
        var Brand = _context.Brands.Find(id);
        return Brand;
    }

    //Insert Brand
    [HttpPost]
    public Brand InsertBrand(Brand Brand){
        _context.Brands.Add(Brand);
        _context.SaveChanges();
        return Brand;
    }
}
