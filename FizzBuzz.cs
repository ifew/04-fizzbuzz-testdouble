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

            if(isFizzNumber(v)) {
                return "Fizz";
            }
            if(isBuzzNumber(v)) {
                return "Buzz";
            }
            return v.ToString();
        }

        private bool isFizzNumber(int v) {
            return v % 3 == 0;
        }

        private bool isBuzzNumber(int v) {
            return v % 5 == 0;
        }
    }
}