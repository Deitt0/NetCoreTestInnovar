using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BarApi.Models
{
    public class Beer
    {
        public long Id {get;set;}
        public string Name {get; set;} = string.Empty;
        public int Year { get; set; }
    }
}