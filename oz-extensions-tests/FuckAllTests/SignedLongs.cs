using System.Collections.Generic;
using Xunit;

namespace OzExtensions.Tests.FuckAllTests
{
    public sealed class SignedLongs
    {
        [Theory, MemberData(nameof(IsFuckAllData))]
        public void IsFuckAll(long value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        [Theory, MemberData(nameof(IsFuckAllNullableData))]
        public void IsFuckAllNullable(long? value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        public static IEnumerable<object[]> IsFuckAllData()
        {
            yield return new object[] { -1L, false };
            yield return new object[] { 0L, true };
            yield return new object[] { 1L, false };
        }

        public static IEnumerable<object[]> IsFuckAllNullableData()
        {
            yield return new object[] { -1L, false };
            yield return new object[] { null, true };
            yield return new object[] { 0L, true };
            yield return new object[] { 1L, false };
        }
    }
}