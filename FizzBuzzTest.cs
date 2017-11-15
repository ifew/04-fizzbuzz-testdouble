using System;
using Xunit;

namespace _04_fizzbuzz_testdouble
{
    public class FizzBuzzTest
    {
        [Fact]
        public void InputOneGetOne()
        {
            string expected = "1";

            FizzBuzz fizzbuzz = new FizzBuzz();
            string actual = fizzbuzz.GetNumber(1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputTwoGetTwo()
        {
            string expected = "2";

            FizzBuzz fizzbuzz = new FizzBuzz();
            string actual = fizzbuzz.GetNumber(2);

            Assert.Equal(expected, actual);
        }
    }
}
