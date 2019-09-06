using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_for_1()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Get(1);

            // Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void Get_Returns_2_for_2()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(2);

            Assert.Equal("2", result);
        }

        [Fact]
        public void Get_Returns_Fizz_for_3()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Get_Returns_Fizz_for_6()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(6);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Get_Returns_Buzz_for_5()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Get_Returns_Buzz_for_10()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(10);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Get_Returns_FizzBuzz_for_15()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var result = fizzBuzz.Get(15);

            // assert
            Assert.Equal("FizzBuzz", result);
        }
    }
}
