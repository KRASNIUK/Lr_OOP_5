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
        public double feathers; // g
        public double hide;// kg
        public double meat;// kg

        public void getInformation(PrintHandler print)
        {
            string Information = "";

            Information +=
                $"Struct: {this.GetType().Name}\n" +
                $"    Feathers: {feathers}\n" +
                $"    Hide: {hide}\n" +
                $"    Meat: {meat}\n";

            print?.Invoke(Information);
        }
    }
}