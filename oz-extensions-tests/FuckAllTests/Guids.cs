using System;
using System.Collections.Generic;
using Xunit;

namespace OzExtensions.Tests.FuckAllTests
{
    public sealed class Guids
    {

        [Theory, MemberData(nameof(IsFuckAllData))]
        public void IsFuckAll(Guid value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }


        [Theory, MemberData(nameof(IsFuckAllNullableData))]
        public void IsFuckAllNullable(Guid? value, bool expectedResult)
        {
            Assert.Equal(expectedResult, value.IsFuckAll());
        }

        public static IEnumerable<object[]> IsFuckAllData()
        {
            yield return new object[] { Guid.Empty, true };
            yield return new object[] { default(Guid), true };
            yield return new object[] { Guid.NewGuid(), false };
        }

        public static IEnumerable<object[]> IsFuckAllNullableData()
        {
            yield return new object[] { null, true };
            yield return new object[] { default(Guid), true };
            yield return new object[] { (Guid?)Guid.Empty, true };
            yield return new object[] { (Guid?)Guid.NewGuid(), false };
        }
    }
}