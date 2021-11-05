using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class operation
    {
        private char c;
        public operation()
        {
        }
        public double perform(double d1, double d2)
        {
            switch (c)
            {
                case '+': return d1 + d2;
                case '-': return d1 - d2;
                case '*': return d1 * d2;
                case '/': return d1 / d2;
                default : return d1; 
            }
        }

        public void setOperation(char _c)
        {
            c = _c;
        }
    }
}
