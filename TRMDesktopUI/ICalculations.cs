using System.Collections.Generic;

namespace TRMDesktopUI
{
    public interface ICalculations
    {
        List<string> Register { get; set; }

        double Add(double x, double y);
    }
}