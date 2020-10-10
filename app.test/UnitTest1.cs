using Xunit;

namespace app.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1(int num1, int num2)
        {
            Assert.Equal(2+2, 5);
        }
    }
}
