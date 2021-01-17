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
            base.killAnimal();
            BootyArgs bootyArgs = new BootyArgs() { feathers = 0, hide = weight * 0.08, meat = weight * 0.8};

            return bootyArgs;
        }

        public void sitOnHorse()
        {
            if (alive) 
                Console.WriteLine("You sit on horse");
            else
                throw new Exception("alive = false");
        }
        public void rideHorse()
        {
            if(alive)
                Console.WriteLine("You ride horse");
            else
                throw new Exception("alive = false");
        }
    }
}