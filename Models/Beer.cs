using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarApi.Models
{
    public class Beer
    {
        [Key]
        public long BeerId {get;set;}
        public string Name {get; set;}
        public int Year {get;set;}
        public long BrandId {get;set;}

        [ForeignKey(nameof(BrandId))]
        public Brand? Brand {get;set;}
    }
}