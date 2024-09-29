using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calc_app
{
    public class Calculator : ICalculator
    {
        private double a = 0, b = 0;
        public void Clear_A()
        {
            this.a = 0;
        }

        public void Clear_B()
        {
            this.b = 0;
        }

        public void divide(double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            a = a / b;
        }



        public void minus(double b)
        {
            try
            {

                a = a - b;

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }



        public void multiple(double b)
        {
            try
            {

                a = a * b;

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }



        public void plus(double b)
        {
            try
            {

                a = a + b;

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void Put_A(double a)
        {
            try
            {
                this.a = checked(a);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public double Get_A()
        {
            return this.a;
        }

        public void Put_B(double b)
        {
            try
            {
                this.b = checked(b);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public double Get_B()
        {
            return b;
        }
    }
}
