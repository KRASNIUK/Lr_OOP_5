using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Horse horseRuner = new Horse()
            {
                carryingCapacity = 12,
                name = "Runer",
                age = 10,
                isMaile = true,
                weight = 11.2,
                maxSpeed = 15
            };
            horseRuner.getInformation(ConsolePrint);

            Bird birdAngry = new Bird()
            {
                name = "Angry-Bird",
                age = 3,
                doesFly = true,
                isMaile = true, 
                maxEggsWeek = 3,
                maxSpeed = 8,
                weight = 1
            };
            birdAngry.getInformation(ConsolePrint);

            BootyArgs booty_AngryBird = birdAngry.killAnimal();
            booty_AngryBird.getInformation(ConsolePrint);

            birdAngry.getInformation(ConsolePrint);

            Pegasus pegasusArnold = new Pegasus()
            {
                name = "Arnold",
                age = 12,
                isMaile = false,
                doesFly = true,
                maxSpeed = 20,
                weight = 20.4,
                carryingCapacity = 100
            };
            pegasusArnold.getInformation(ConsolePrint);

            pegasusArnold.sitOnHorse();

            Console.ReadKey();
        }

        static void ConsolePrint(string Information)
        {
            Console.WriteLine(Information);
        }
    }
}
