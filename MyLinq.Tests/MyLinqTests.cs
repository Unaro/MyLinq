using System;
using System.Collections.Generic;

namespace MyLinq.Tests
{
    public class WhereTests
    {
        [Fact]
        public void NotEmptyCollection_GetElementsMoreThanFive_Success()
        {
            //Arrange.
            var array = new[] { 1, 2, 3, 5, 6, 12, 5, 22 };

            var expected = new[] { 6, 12, 22 };

            var result = array.Where(x => x > 5);


            Assert.Equal(result, expected);
        }

        [Fact]
        public void NullSource_Throws()
        {
            int[] array1 = null;

            Assert.Throws<InvalidOperationException>(() => array1.Where(x => x > 0));
        }

        [Fact]
        public void NotEmptyCollection_GetNonFeetElement_EmptyResult()
        {
            var array = new List<int> { 1, 2, 3, 5, 6, 12, 5, 22 };

            var result = array.Where(x => x == -5);

            Assert.Empty(result);


        }

        [Fact]
        public void NotEmptyCollection_GradeTen_Single()
        {
            var array = new List<(int Grade, double Salary)>
            {
                (Grade: 5, Salary: 1200),
                (Grade: 10, Salary: 2400)
            };


            var result = array.Where(x => x.Grade == 10);

            Assert.Single(result);


        }
    }
}