using System.Collections.Generic;
using Xunit;

namespace OzExtensions.Tests.FuckAllTests
{
    public sealed class Floats
    {
        [Theory, MemberData(nameof(IsFuckAllData))]
        public void IsFuckAll(float value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        [Theory, MemberData(nameof(IsFuckAllNullableData))]
        public void IsFuckAllNullable(float? value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        public static IEnumerable<object[]> IsFuckAllData()
        {
            yield return new object[] { 0.000000000, true };
            yield return new object[] { -0.000000001, false };
            yield return new object[] { 0.000000001, false };
        }

        public static IEnumerable<object[]> IsFuckAllNullableData()
        {
            yield return new object[] { null, true };
            yield return new object[] { (float?)0.000000000, true };
            yield return new object[] { (float?)-0.000000001, false };
            yield return new object[] { (float?)0.000000001, false };
        }
    }
}
