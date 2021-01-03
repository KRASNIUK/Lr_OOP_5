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

        public double maxSpeed { get; set; }

        public bool isMaile { get; set; }

        public virtual BootyArgs killAnimal()
        {
            return new BootyArgs();
        }

        public virtual string getInformation(PrintHandler print = null)
        {
            string Information =
                $"Class: {this.GetType().Name}\n" +
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
