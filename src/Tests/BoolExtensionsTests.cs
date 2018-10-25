using System;
using SanPellgrino;
using Xunit;

namespace Tests
{
    public class BoolExtensionsTests
    {
        [Fact]
        public void IsFalse_should_return_true_if_false()
        {
            Assert.Equal(true, false.IsFalse());
        }
 
        [Fact]
        public void IsTrue_should_return_true_if_true()
        {
            Assert.Equal(true, true.IsTrue());
        }
    }
}