using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI
{
    public class Calculations : ICalculations
    {
        public List<string> Register { get; set; } = new List<string>();

        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
