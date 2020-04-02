using Xunit;

namespace OzExtensions.Tests.FuckAllTests
{
    public sealed class Strings
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("       ", true)]
        [InlineData("fuck all", false)]
        public void String(string value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }
    }
}