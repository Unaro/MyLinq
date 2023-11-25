using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Tests
{
    public class SelectTests
    {

        [Fact] public void NotEmptyIntCollection_Select_СonvertToString_Success()
        {
            var actual = new List<int>
            {
                1, 2, 3, 4
            };

            string[] expected =
            {
                "1" + "Привет", "2" + "Привет", "3" + "Привет", "4" + "Привет"
            };
            
            var result = actual.Select(item => item.ToString()+"Привет");

            Assert.Equal(result, expected);


        }

        [Fact]
        public void NotEmptyCollection_Select_ItemMultiple2_False()
        {
            var actual = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7,
            };

            var expected = new List<int>
            {
                1*3, 2*3, 3*3, 4*3, 5*3, 6*3, 7*3
            };

            var result = actual.Select(item => item * 2);

            Assert.NotEqual(result, expected);


        }
    }
}
