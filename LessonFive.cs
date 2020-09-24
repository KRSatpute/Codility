using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonFive
    {
        public static int CountDiv(int A, int B, int K)
        {
            if (A == B)
                return B % K == 0 ? 1 : 0;
            
            if (K == 1)
                return B - A + 1;

            int firstTrueMod = 0;
            int trueModCount = 0;

            for (int i = 0; i <= B; i++)
            {
                if((A + i) % K == 0)
                {
                    firstTrueMod = A + i;
                    trueModCount = 1;
                    break;
                }
            }

            for (int j = firstTrueMod + K; j <= B && j > -1; j += K)
            {
                trueModCount += 1;
            }

            return trueModCount;
        }

        public static int PassingCars(int[] A)
        {
            int passingCars = 0;

            if (A.Length == 1)
                return 0;
            
            int positionOfFirstCarToEast = Array.IndexOf(A, 0);
            int positionOfFirstCarToWest = Array.IndexOf(A, 1);

            if (positionOfFirstCarToEast != -1 && positionOfFirstCarToWest != -1)
            {
                int eastBoundCarCount = 1;

                for (int i = positionOfFirstCarToEast; i < A.Length - 1; i++)
                {
                    if (A[i + 1] == 0)
                        eastBoundCarCount += 1;

                    passingCars += eastBoundCarCount * A[i + 1];

                    if (passingCars > 1000000000)
                    {
                        passingCars = -1;
                        break;
                    }
                }
            }
            
            return passingCars;
        }
    }
}