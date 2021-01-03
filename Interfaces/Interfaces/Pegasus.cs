using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Pegasus : Animal, IBird, IHorse
    {
        public bool doesFly { get; set; }
        int IBird.maxEggsWeek { get; set; }

        public double carryingCapacity { get; set; }

        public void takeInArms()
        {
            Console.WriteLine($"You don't take a {this.GetType().Name} in arms");
        }

        public override string getInformation(PrintHandler print)
        {
            string Information = base.getInformation();

            Information +=
                $"    CarryingCapacity: {carryingCapacity}\n" +
                $"    DoesFly: {doesFly}\n" +
                $"";

            print?.Invoke(Information);

            return Information;
        }
        public override BootyArgs killAnimal()
        {
            BootyArgs bootyArgs = new BootyArgs() { feathers = 500, hide = 10, meat = 90 };

            return bootyArgs;
        }

        public void sitOnHorse()
        {
            Console.WriteLine($"You sit on {this.GetType().Name}");
        }
        public void rideHorse()
        {
            Console.WriteLine($"You ride {this.GetType().Name}");
        }
    }
}