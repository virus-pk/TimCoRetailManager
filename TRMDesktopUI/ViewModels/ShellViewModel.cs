using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel
    {
        private ICalculations _calculations;

        // On start calculations => register count = 0
        public ShellViewModel(ICalculations calculations) // Use it in constructor
        {
            _calculations = calculations;
        }
    }
}
