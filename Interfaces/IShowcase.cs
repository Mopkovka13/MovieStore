using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Interfaces
{
    public interface IShowcase
    {
        uint Id { get; set; }
        string Name { get; set; }
        int Capacity { get; set; }
        DateTime CreateDate { get; set; }
        DateTime DeleteTime { get; set; }

        void ShowProducts();
    }
}
