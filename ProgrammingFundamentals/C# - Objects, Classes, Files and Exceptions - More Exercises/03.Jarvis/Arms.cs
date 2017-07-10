using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Arms
    {
        public Arm LeftArm { get; set; }

        public Arm RightArm { get; set; }
    }

    class Arm
    {
        public int EnergyConsumption { get; set; }

        public int ReachDistance { get; set; }

        public int Fingers { get; set; }
    }
}
