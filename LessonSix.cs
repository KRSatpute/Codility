using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonSix
    {
        public static int Triangle(int[] A)
        {
            if (A.Length < 3)
                return 0;
            
            Array.Sort(A);

            for (int i=0; i < A.Length - 2; i++)
            {  
                if (A[i] + A[i + 1] > A[i + 2])
                    return 1;

                if (A[i] == A[i + 2] && A[i + 2] == A[i + 1] && A[i] == int.MaxValue)
                    return 1;
            }

            return 0;
        }

        public static int MaxProductOfThree(int[] A)
        {
            if (A.Length == 3)
                return A.Aggregate(1, (a, b) => a * b);

            Array.Sort(A);
            
            if (A[A.Length - 1] <= 0 || A[0] >= 0)
                return A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            
            int[] AbsSorted = A.OrderBy(Math.Abs).Reverse().ToArray();

            int maxProduct = AbsSorted.Max();

            if (AbsSorted[1] < 0 && AbsSorted[0] > 0)
            {
                int temp = AbsSorted[1];
                AbsSorted[1] = AbsSorted[0];
                AbsSorted[0] = temp;
            }

            if (AbsSorted[2] < 0 && AbsSorted[1] > 0 && Math.Abs(AbsSorted[2]) == AbsSorted[1])
            {
                int temp = AbsSorted[2];
                AbsSorted[2] = AbsSorted[1];
                AbsSorted[1] = temp;
            }

            for(int i = 0, j = 1, k = 2; k < AbsSorted.Length; k++)
            {
                int prod = AbsSorted[i] * AbsSorted[j] * AbsSorted[k];

                if (prod > maxProduct)
                    return prod;
            }
            
            return AbsSorted[1] * AbsSorted[2] * AbsSorted[3];
        }

        public static int NumberOfDiscIntersections(int [] A)
        {
            long result = 0;
            Dictionary<long, int> dps = new Dictionary<long, int>();
            Dictionary<long, int> dpe = new Dictionary<long, int>();

            for (int i = 0; i < A.Length; i++)
            {
                Inc(dps, Math.Max(0, i - A[i]));
                Inc(dpe, Math.Min(A.Length - 1, i + A[i]));
            }

            long t = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (dps.TryGetValue(i, out int value))
                {
                    result += t * value;
                    result += value * (value - 1) / 2;
                    t += value;

                    if (result > 10000000)
                        return -1;
                }
                
                dpe.TryGetValue(i, out value);
                t -= value;
            }

            return (int)result;
        }

        private static void Inc(Dictionary<long, int> values, long index)
        {
            values.TryGetValue(index, out int value);
            values[index] = ++value;
        }

        public static int Distinct(int[] A)
        {
            if (A.Length == 0)
                return 0;
            
            HashSet<int> DistinctValues = new HashSet<int>();

            foreach(int num in A)
                DistinctValues.Add(num);
            
            return DistinctValues.Count;
        }
    }
}