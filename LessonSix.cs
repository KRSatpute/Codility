using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonSix
    {
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