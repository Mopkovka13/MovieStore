using MovieStore.Interfaces;
using System;

namespace MovieStore.Models
{
    public class Showcase : IShowcase
    {
        public uint Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DeleteTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowProducts()
        {
            throw new NotImplementedException();
        }
    }
}
