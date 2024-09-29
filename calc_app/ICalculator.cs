using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_app
{
    public interface ICalculator
    {
        void Clear_A();
        void Clear_B();
        void divide(double b);
        void minus(double b);
        void multiple(double b);
        void plus(double b);
        void Put_A(double a);
        double Get_A();
        void Put_B(double b);
        double Get_B();
    }
}
