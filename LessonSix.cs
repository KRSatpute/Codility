using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonSix
    {

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
            if (A.Length == 0)
                return 0;
            
            int distinctIntersections = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    int sumOfRadius;
                    int disctanceBetweenCenters = j - i;
                    try
                    {
                        checked
                        {
                            sumOfRadius = A[i] + A[j];
                        }
                    }
                    catch(OverflowException)
                    {
                        sumOfRadius = int.MaxValue;
                    }

                    if (disctanceBetweenCenters <= sumOfRadius)
                        distinctIntersections += 1;
                    
                    if (distinctIntersections > 1000000000)
                        return -1;
                }
            }

            return distinctIntersections;
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