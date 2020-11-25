using System.Collections.Generic;
using System.Linq;
using SanPellgrino;
using Tests.TestData;
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

        [Fact]
        public void Distinct_should_remove_all_duplicates()
        {
            // arrange
            var examples = new List<ExampleClass>
            {
                new ExampleClass {Name = "Test Name 1", Value = "Test Value 1"},
                new ExampleClass {Name = "Test Name 1", Value = "Test Value 1"},
                new ExampleClass {Name = "Test Name 2", Value = "Test Value 2"},
            };

            var distinctExamples = examples.DistinctBy(x => x.Name);

            // assert
            Assert.Equal(3, examples.Count);
            Assert.Equal(2, distinctExamples.Count());
        }
    }
}