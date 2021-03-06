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
            Console.WriteLine("{");
            for(int i = 0; i < _products.Count;i++)
            {
                _products[i].Show();
            }
            Console.WriteLine("}");
        }
        public void AddProducts()
        {
            for(int i = 0; i < 10; i++)
            {
                string tempName = "Name" + i;
                _products.Add(new Product(tempName, 12*(uint)i));
            }
        }

    }
}
