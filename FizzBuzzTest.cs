using System;
using Xunit;

namespace _04_fizzbuzz_testdouble
{
    public class FizzBuzzTest
    {
        FizzBuzz fizzbuzz = new FizzBuzz();

        [Fact]
        public void InputOneGetOne()
        {
            string expected = "1";

            string actual = fizzbuzz.GetNumber(1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputTwoGetTwo()
        {
            string expected = "2";

            string actual = fizzbuzz.GetNumber(2);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void InputThreeGetThree()
        {
            string expected = "Fizz";

            string actual = fizzbuzz.GetNumber(3);

            Assert.Equal(expected, actual);
        }
    }
}
