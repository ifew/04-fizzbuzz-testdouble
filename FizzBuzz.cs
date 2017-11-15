using System;

namespace _04_fizzbuzz_testdouble
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string GetNumber(int v)
        {
            if(v == 3) {
                return "Fizz";
            }
            if(v == 5) {
                return "Buzz";
            }
            if(v == 6) {
                return "Fizz";
            }
            return v.ToString();
        }
    }
}