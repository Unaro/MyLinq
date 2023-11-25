using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Tests
{
    public class AnyTests
    {
        [Fact]
        public void EmptyCollection_Any_False()
        {
            var array = Array.Empty<int>();
            var result = array.Any((value) => value == 2);
            Assert.False(result);
        }

        [Fact]
        public void NotEmptyCollection_Any_True()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var result = array.Any((value) => value == 2);
            Assert.True(result);
        }

        [Fact]
        public void NotEmptyCollectionCortage_Any_True()
        {
            var array = new[] { (1, 2), (2, 3), (4, 5), (6, 7) };
            var result = array.Any((value) => value == (2, 3));
            Assert.True(result);
        }
    }
}
