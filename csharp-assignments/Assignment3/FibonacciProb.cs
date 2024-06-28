using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public  class FibonacciProb
    {
        public int Fibonacci(int n) {
            if (n == 1 || n == 2) {
                return 1;
            }

            return Fibonacci(n-1) + Fibonacci(n-2);
        }
    }
}
