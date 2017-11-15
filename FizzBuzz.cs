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
            if((v % 15) == 0) {
                return "FizzBuzz";
            }
            bool isFizzNumber = v % 3 == 0;
            if (isFizzNumber) {
                return "Fizz";
            }
            if((v % 5) == 0) {
                return "Buzz";
            }
            return v.ToString();
        }
    }
}