using Xunit;
using MyApp;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Add()
        {
            Assert.Equal(5, Calculator.Add(2,3));
        }
    }
}
