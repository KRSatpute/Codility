using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonSix
    {
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