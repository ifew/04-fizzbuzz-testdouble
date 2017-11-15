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

        [Fact]
        public void InputFourGetFour()
        {
            string expected = "4";

            string actual = fizzbuzz.GetNumber(4);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void InputFiveGetFive()
        {
            string expected = "Buzz";

            string actual = fizzbuzz.GetNumber(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputSixGetSix()
        {
            string expected = "Fizz";

            string actual = fizzbuzz.GetNumber(6);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputSevenGetSeven()
        {
            string expected = "7";

            string actual = fizzbuzz.GetNumber(7);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputNineGetNine()
        {
            string expected = "Fizz";

            string actual = fizzbuzz.GetNumber(9);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputTenGetTen()
        {
            string expected = "Buzz";

            string actual = fizzbuzz.GetNumber(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputFiveTeenGetFiveTeen()
        {
            string expected = "FizzBuzz";

            string actual = fizzbuzz.GetNumber(15);

            Assert.Equal(expected, actual);
        }
    }
}
