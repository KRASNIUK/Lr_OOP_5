using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Bird : Animal, IBird
    {
        public bool doesFly { get; set; }
        public int maxEggsWeek { get; set; }

        public override string getInformation(PrintHandler print)
        {
            string Information = base.getInformation();

            Information +=
                $"    ВoesFly: {doesFly}\n" +
                $"    MaxEggsWeek: {maxEggsWeek}\n" +
                $"     ";

            print?.Invoke(Information);

            return Information;
        }
        public override BootyArgs killAnimal()
        {
            base.killAnimal();
            BootyArgs bootyArgs = new BootyArgs() { feathers = weight * 0.2 * 95, hide = 0, meat = weight * 0.8};

            
            return bootyArgs;
        }

        public void takeInArms()
        {
            if(alive)
                Console.WriteLine("You take a bird in arms");

            else
                throw new Exception("alive = false");
        }
    }
}