using System;
using Xunit;

namespace CyclicRotation.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 1, new int[] { 4,1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 2, new int[] { 3,4,1, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 3, new int[] { 2, 3, 4,1 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { }, 4, new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 0, new int[] { 1, 2, 3, 4 })]
        public void solution_RotatesArray_N_Times(int [] a, int k, int [] result)
        {
            Solution sln = new Solution();
            var res = sln.solution(a, k);
            Assert.Equal(result, res);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 1, new int[] { 2, 3,4,1 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 2, new int[] { 3, 4, 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 3, new int[] { 4,1,2,3 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { },4,new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 0, new int[] { 1, 2, 3, 4 })]
        public void CounterClockwise_RotatesArray_N_Times(int[] a, int k, int[] result)
        {
            Solution sln = new Solution();
            var res = sln.CounterClockwise(a, k);
            Assert.Equal(result, res);
        }
    }
}
