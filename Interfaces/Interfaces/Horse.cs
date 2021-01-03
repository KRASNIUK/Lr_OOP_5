using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public delegate void PrintHandler(string Information);

    class Horse : Animal, IHorse
    {
        public double carryingCapacity { get; set; }


        public override string getInformation(PrintHandler print)
        {
            string Information = base.getInformation();

            Information +=
                $"    CarryingCapacity: {carryingCapacity}\n";

            print?.Invoke(Information);

            return Information;
        }
        public override BootyArgs killAnimal()
        {
            BootyArgs bootyArgs = new BootyArgs() { feathers = 0, hide = 7, meat = 80 };

            return bootyArgs;
        }

        public void sitOnHorse()
        {
            Console.WriteLine("You sit on horse");
        }
        public void rideHorse()
        {
            Console.WriteLine("You ride horse");
        }
    }
}