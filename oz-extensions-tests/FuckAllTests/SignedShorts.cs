using System.Collections.Generic;
using Xunit;

namespace OzExtensions.Tests.FuckAllTests
{
    /// <summary>I prefer Billabong myself</summary>
    public sealed class SignedShorts
    {
        [Theory, MemberData(nameof(IsFuckAllData))]
        public void IsFuckAll(short value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        [Theory, MemberData(nameof(IsFuckAllNullableData))]
        public void IsFuckAllNullable(short? value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        public static IEnumerable<object[]> IsFuckAllData()
        {
            yield return new object[] { -1, false };
            yield return new object[] { 0, true };
            yield return new object[] { 1, false };
        }

        public static IEnumerable<object[]> IsFuckAllNullableData()
        {
            yield return new object[] { null, true };
            yield return new object[] { (short?)0, true };
            yield return new object[] { (short?)-1, false };
            yield return new object[] { (short?)1, false };
        }
    }
}
