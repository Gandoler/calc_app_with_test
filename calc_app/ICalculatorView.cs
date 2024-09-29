using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_app
{
    public interface ICalculatorView
    {
        string DisplayText { get; set; }
        void ShowError(string message);
    }
}
