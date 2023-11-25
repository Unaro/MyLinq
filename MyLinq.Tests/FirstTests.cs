using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Tests
{
    public class FirstTests
    {
        [Fact]
        public void NotEmptyCollection_FirstItem_Success()
        {
            var array = new List<int>
            {
                1, 2, 3, 4
            };


            var result = array.First();

            Assert.Equal(1, result);


        }

        [Fact]
        public void NotEmptyCollection_FirstItem_Failure()
        {
            var array = Array.Empty<int>();
            Assert.Throws<InvalidOperationException>(() => array.First());

        }

        [Fact]
        public void EmptyCollection_FirstOrDefault_default()
        {
            var array = Array.Empty<int>();
            var result = array.FirstOrDefault();
            Assert.Equal(0, result);
        }

        [Fact]
        public void EmptyCollection_FirstOrDefault_first()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var result = array.FirstOrDefault((value) => value == 3);
            Assert.Equal(3, result);
        }

        [Fact]
        public void NotEmptyCollection_FirstOrDefaultCriteria_NonMatching_default()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var result = array.FirstOrDefault((value) => value == 33);
            Assert.Equal(0, result);
        }

    }
}
