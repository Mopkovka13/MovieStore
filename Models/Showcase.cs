using MovieStore.Interfaces;
using System;
using System.Collections.Generic;

namespace MovieStore.Models
{
    public class Showcase : IShowcase
    {
        private List<Product> _products = new List<Product>();
        private static uint _autoId;

        public Showcase()
        {
            Id = _autoId++;
            CreateDate = DateTime.Now;
        }
        
        public uint Id { get; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public DateTime CreateDate { get; }

        public void ShowProducts()
        {
            
        }

    }
}
