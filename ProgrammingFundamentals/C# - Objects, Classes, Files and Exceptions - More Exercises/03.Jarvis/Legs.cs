using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Legs
    {
        public Leg LeftLeg { get; set; }

        public Leg RightLeg { get; set; }
    }

    class Leg
    {
        public int EnergyConsumption { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }
    }
}
