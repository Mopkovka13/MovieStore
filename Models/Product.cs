using MovieStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class Product : IProduct
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public uint Volume { get; set; }
        public decimal Price { get; set; }
        
    }
}
