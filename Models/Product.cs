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
        public Product(string name, uint volume)
        {
            Id = _autoId++;
            Name = name;
            Volume = volume;
        }
        public uint Id { get; }
        public string Name { get; set; }
        public uint Volume { get; set; }
        public decimal? Price { get; set; }
        public void Show()
        {
            Console.WriteLine($"\tId: {Id},  Name: {Name},  Volume: {Volume}, Price: {Price}");
        }
        
    }
}
