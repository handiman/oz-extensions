using System.Collections.Generic;
using Xunit;

namespace OzExtensions.Tests.FuckAllTests
{
    public sealed class Objects
    {
        [Theory, MemberData(nameof(TestData))]
        public void IsFuckAll(object value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new[] { null as object, true };
            yield return new[] { new object(), false };
        }
    }
}