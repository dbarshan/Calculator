using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class accumulator
    {
        private double value;
        
        public accumulator()
        {
            value = 0;
        }
        public double getValue()
        {
            return value;
        }

        public void setValue(double v)
        {
            value = v;
        }

    }
}
