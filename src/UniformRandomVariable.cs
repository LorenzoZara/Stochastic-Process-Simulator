using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StochasticProcessSimulator
{
    public class UniformRandomVariable
    {
        private Random R = new Random();

        private int lowerBound;
        private int upperBound;

        public UniformRandomVariable(int a, int b)
        {
            this.lowerBound = a;
            this.upperBound = b;
        }

        public int getValue()
        {
            return R.Next(this.lowerBound, this.upperBound);

        }
    }
}
