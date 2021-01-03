using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IBird : IAnimal
    {
        bool doesFly { get; set; }
        int maxEggsWeek { get; set; }

        void takeInArms();

    }
}
