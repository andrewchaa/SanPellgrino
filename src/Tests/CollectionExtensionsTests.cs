using SanPellgrino;
using Xunit;

namespace Tests
{
    public class CollectionExtensionsTests
    {
        [Fact]
        public void IsOneOf_should_work()
        {
            Assert.True(1.IsOneOf(1, 2, 3));
            Assert.True(2.IsOneOf(1, 2, 3));
            Assert.True(3.IsOneOf(1, 2, 3));
            Assert.False(4.IsOneOf(1, 2, 3));
        }
        
        [Fact]
        public void IsNotOneOf_should_work()
        {
            Assert.True(1.IsNotOneOf(2, 3));
            Assert.False(1.IsNotOneOf(1, 2, 3));
        }

    }
}