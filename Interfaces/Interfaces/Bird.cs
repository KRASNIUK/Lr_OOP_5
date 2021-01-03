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
            BootyArgs bootyArgs = new BootyArgs() { feathers = 100, hide = 0, meat = 4 };

            return bootyArgs;
        }

        public void takeInArms()
        {
            Console.WriteLine("You take a bird in arms");
        }
    }
}