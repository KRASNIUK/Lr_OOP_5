using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Animal : IAnimal
    {
        public double weight { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        protected bool alive { get; set; }

        public double maxSpeed { get; set; }

        public bool isMaile { get; set; }

        public Animal()
        {
            Console.WriteLine($"To create new {this.GetType().BaseType.Name}:{this.GetType().Name}");
            alive = true;
        }

        public virtual BootyArgs killAnimal()
        {
            if (alive) {
                Console.WriteLine($"To kill {this.GetType().Name}: {this.name}");
                alive = false;
                return new BootyArgs();
            }
            else
            {
                throw new Exception("alive = false");
            }
        }

        public virtual string getInformation(PrintHandler print = null)
        {
            string Information =
                $"Class: {this.GetType().Name}\n" +
                $"    Alive: {alive}\n" +
                $"                  \n" +
                $"    Name: {name}\n" +
                $"    Age: {age}\n" +
                $"    Weight: {weight}\n" +
                $"    IsMaile: {isMaile}\n" +
                $"                      \n" +
                $"    MaxSpeed: {maxSpeed}\n";

            return Information;
        }
    }
}
