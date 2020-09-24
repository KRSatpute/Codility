using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonsOneToFour
    {
        public static int PermCheck(int[] A)
        {
            int isPerm = 1;

            Array.Sort(A);

            if (A[0] != 1)
                return 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                int step = A[i + 1] - A[i];

                if (step != 1)
                    isPerm = 0;
            }

            return isPerm;
        }

        public static int MissingInteger(int[] A)
        {
            if (A.Length == 1)
                return A[0] != 1 ? 1 : 2;
            
            Array.Sort(A);

            if (A[^1] < 1)
                return 1;
            
            if (A[0] > 1)
                return 1;
            
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                    A[i] = 0;
            }
            
            int minValue = A[0] + 1;
            int index = 1;

            do
            {
                if (minValue < A[index])
                    break;
                else
                    minValue = A[index] + 1;
                
                index++;
            }while(index < A.Length);

            return minValue < 1 ? 1 : minValue;
        }

        public static int[] MaxCounters(int N, int[] A)
        {
            int[] counters = new int[N];

            int lastUpdatedCounter = 0;
            int maxSetValue = 0;

            foreach (int num in A)
            {
                if (num <= N)
                {
                    if (maxSetValue >= counters[num - 1])
                        counters[num - 1] = maxSetValue + 1;
                    else
                        counters[num - 1] += 1;
                    
                    lastUpdatedCounter = counters[num - 1] > lastUpdatedCounter ? counters[num - 1] : lastUpdatedCounter;
                }
                else
                    maxSetValue = lastUpdatedCounter;
            }

            for (int i = 0; i < counters.Length; i++)
                if (counters[i] < maxSetValue)
                    counters[i] = maxSetValue;

            return counters;
        }

        public static int FrogRiverOne(int X, int[] A)
        {
            SortedSet<int> leaves = new SortedSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                leaves.Add(A[i]);
                if (leaves.Count() == X) return i;
            }
            return -1;
        }

        public static int TapeEquilibrium(int[] A)
        {
            int arraySum = 0;
            
            foreach(int num in A)
                arraySum += num;
            
            int pLeft = A[0];
            int pRight = arraySum - pLeft;

            int minDiff = Math.Abs(pLeft - pRight);
            
            for(int p = 1; p < A.Length; p++)
            {
                if (Math.Abs(pLeft - pRight) < minDiff)
                    minDiff = Math.Abs(pLeft - pRight);
                
                pLeft += A[p];
                pRight -= A[p];
            }

            return minDiff;
        }

        public static int PermMissingElem(int[] A)
        {
            if (A.Length == 0)
                return 1;

            Array.Sort(A);
            
            if (A[0] != 1)
                return 1;

            int missingElem = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] + 1 != A[i + 1])
                {
                    missingElem = A[i] + 1;
                    break;
                }
            }

            return missingElem == 0 ? A[^1] + 1 : missingElem;
        }

        public static int FrogJmp(int X, int Y, int D)
        {
            int remainingDistance = Y - X;

            int quotient = Math.DivRem(remainingDistance, D, out int remainder);

            return remainder > 0 ? quotient + 1 : quotient;
        }

        public static int OddOccurrencesInArray(int[] A)
        {
            Dictionary<int, int> numCounts = new Dictionary<int, int>();
            int oddOccurence = 0;

            foreach(int num in A)
            {
                if (numCounts.ContainsKey(num))
                    numCounts[num]++;
                else
                    numCounts.Add(num, 1);
            };

            foreach(int num in numCounts.Keys)
            {
                if (numCounts[num] % 2 != 0)
                {
                    oddOccurence = num;
                    break;
                }
            }

            return oddOccurence;
        }

        public static int[] CyclicRotation(int[] A, int K)
        {
            if (A.Length == 0)
                return A;

            int[] rotatedArray = new int[A.Length];

            K = K >= A.Length ? K % A.Length : K;

            for(int i = 0; i < A.Length; i++)
            {
                int position = i + K;
                int newPosition = position >= A.Length ? position - A.Length : position;

                rotatedArray[newPosition] = A[i];
            }

            return rotatedArray;
        } 
        
        public static int BinaryGap(int N) 
        {
            Console.WriteLine(Convert.ToString(N, 2));
            char[] binary = Convert.ToString(N, 2).ToCharArray();

            Array.Reverse(binary);

            int gap = 0;
            int gapCount = 0;

            int largestGap = 0;

            foreach(char c in binary)
            { 
                if(c == '1' && gap == 0)
                {
                    gap++;
                    continue;
                }

                if (c == '0' && gap > 0)
                {
                    gapCount++;
                }
                else
                {
                    largestGap = gapCount > largestGap ? gapCount : largestGap;
                    gapCount = 0;
                }
                
            }

            return largestGap;
        }
    }
}