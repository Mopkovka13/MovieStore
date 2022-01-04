using MovieStore.Interfaces;
using System;
using System.Collections.Generic;

namespace MovieStore.Models
{
    public class Showcase : IShowcase
    {
        private List<Product> _products = new List<Product>();
        private static uint _autoId;

        public Showcase(string _name, uint _capacity)
        {
            Id = _autoId++;
            Name = _name;
            Capacity = _capacity;
            CreateDate = DateTime.Now;
        }
        
        public uint Id { get; }
        public string Name { get; set; }
        public uint Capacity { get; set; }
        public DateTime CreateDate { get; }

        public void Show()
        {
            Console.WriteLine($"Id: {Id},  Name: {Name},  Capacity: {Capacity}, DateCreate: {CreateDate}");
        }
        public void ShowProducts()
        {
            
        }

    }
}
