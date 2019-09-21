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
        public int Jumps(int X, int Y, int D)
        {
            if (X <= Y) return 1;
            if (X + D >= Y) return 1;
            var d = (Y - X) / D;
            if ((Y - X) % D != 0) return d + 1;
            return d;
        }
        public int Missing(int[] A)
        {
            if (A.Length == 0) return 1;
            int result = 0;
            for (int i = 1; i <= A.Length + 1; i++)
                result ^= i;
            for (int i = 0; i < A.Length; i++)
                result ^= A[i];
            return result;
        }
        public int Equilibrium(int[] A)
        {
            List<int> list = A.Cast<int>().ToList();
            int temp = 0;
            int sum = list.Sum();
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                temp = temp + i;
                result.Add(Math.Abs((sum - temp) - temp));
            }
            return result.Min();
        }
        
    }
}
