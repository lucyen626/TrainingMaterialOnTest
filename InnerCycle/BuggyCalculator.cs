using System;

namespace InnerCycle
{
    internal class BuggyCalculator
    {
        public BuggyCalculator()
        {
        }

        internal int Substract(int a, int b)
        {
            return b > a ? 0 : a - b;
        }
    }
}