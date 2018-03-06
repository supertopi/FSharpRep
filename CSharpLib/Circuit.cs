using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPhysics
{
    public class Circuit
    {
        public int Resistance { get; set; }
        public int Voltage { get; set; }

        public int GetFloorCurrent()
        {
            return Voltage / Resistance;
        }
    }
}
