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
        private static uint _autoId;
        public Product()
        {
            Id = _autoId++;
        }
        public uint Id { get; }
        public string Name { get; set; }
        public uint Volume { get; set; }
        public decimal Price { get; set; }
        
    }
}
