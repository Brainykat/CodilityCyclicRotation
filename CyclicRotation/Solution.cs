using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            if (K <= 0)
                return A;
            if (A.Length == 0) return A;
            var linkedList = new LinkedList<int>(A);
            for (var i = 0; i < K; ++i)
            {
                var node = linkedList.Last;
                linkedList.RemoveLast();
                linkedList.AddFirst(node);
            }
            return linkedList.ToArray();
        }
       public int[] CounterClockwise(int[] A, int K)
        {
            if (K <= 0)
                return A;
            if (A.Length == 0) return A;
            return A.Skip(K) 
             .Concat(A.Take(K)) 
             .ToArray();
        }
    }
}
