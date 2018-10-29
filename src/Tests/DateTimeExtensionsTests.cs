using System;
using SanPellgrino;
using Xunit;

namespace Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void MinutesTest()
        {
            Assert.Equal(TimeSpan.FromMinutes(7), 7.Minutes());
        }
    }
}