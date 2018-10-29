using System;
using SanPellgrino;
using Xunit;

namespace Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Truncate_should_truncate_string()
        {
            Assert.Equal("abcde", "abcdef".Truncate(5));
        }
    }
}