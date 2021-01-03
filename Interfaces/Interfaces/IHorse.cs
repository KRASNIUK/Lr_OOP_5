using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IHorse : IAnimal
    {
        double carryingCapacity { get; set; }


        void sitOnHorse();
        void rideHorse();
    }
    
}
