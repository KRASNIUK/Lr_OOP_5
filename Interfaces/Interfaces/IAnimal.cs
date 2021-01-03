using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IAnimal
    {
        double weight { get; set; }
        int age { get; set; }
        string name { get; set; }

        double maxSpeed { get; set; }

        bool isMaile { get; set; }

        string getInformation(PrintHandler print = null);
        BootyArgs killAnimal();

    }

    public struct BootyArgs
    {
        public int feathers; // g
        public int hide; // kg
        public int meat; // kg
    }
}