using System;
using SanPellgrino;
using Xunit;

namespace Tests
{
    public class DateTimeTests
    {
        [Fact]
        public void MinutesTest()
        {
            Assert.Equal(TimeSpan.FromMinutes(7), 7.Minutes());
        }
    }
}