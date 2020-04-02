using System.Collections.Generic;
using Xunit;

namespace OzExtensions.Tests.FuckAllTests
{
    public sealed class SignedBytes
    {
        [Theory, MemberData(nameof(IsFuckAllData))]
        public void IsFuckAll(sbyte value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        [Theory, MemberData(nameof(IsFuckAllNullableData))]
        public void IsFuckAllNullable(sbyte? value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        public static IEnumerable<object[]> IsFuckAllData()
        {
            yield return new object[] { (sbyte)-1, false };
            yield return new object[] { (sbyte)0, true };
            yield return new object[] { (sbyte)1, false };
        }

        public static IEnumerable<object[]> IsFuckAllNullableData()
        {
            yield return new object[] { null, true };
            yield return new object[] { (sbyte?)0, true };
            yield return new object[] { (sbyte?)-1, false };
            yield return new object[] { (sbyte?)1, false };
        }
    }
}