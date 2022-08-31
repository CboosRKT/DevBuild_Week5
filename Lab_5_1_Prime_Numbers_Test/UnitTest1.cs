using Lab_5_1_Prime_Numbers;
namespace Lab_5_1_Prime_Numbers_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_GetPrime1()
        {
            int actual = PrimeNumbers.GetPrime(1);
            int expected = 2;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_GetPrime2()
        {
            int actual = PrimeNumbers.GetPrime(2);
            int expected = 3;
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test_GetPrime0()
        {
            int actual = PrimeNumbers.GetPrime(0);
            int expected = -1;
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(10)]
        [InlineData(24)]
        public void is_Prime(int _in)
        { List<int> primelist = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            bool actual = false;
            if (primelist.Contains(PrimeNumbers.GetPrime(_in))){
                actual = true;
            }
            Assert.Equal(true, actual);
               
           
        }


    }
}