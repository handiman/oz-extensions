using System;
using Xunit;

namespace OzExtensions.Tests
{
    public sealed class NoWayTests
    {
        [Fact]
        public void With_an_exception_instance()
        {
            var exception = Assert.Throws<NoWayTestsException>(() => NoWay.GetFucked.FuckOff(new NoWayTestsException()));
            Assert.Equal("G'day'", exception.Message);
        }

        [Fact]
        public void With_generic_method()
        {
            var exception = Assert.Throws<NoWayTestsException>(NoWay.GetFucked.FuckOff<NoWayTestsException>);
            Assert.Equal("G'day'", exception.Message);
        }

        public sealed class NoWayTestsException : Exception
        {
            public NoWayTestsException() : base("G'day'") { }
        }
    }
}
