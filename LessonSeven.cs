using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonSeven
    {

        public static int StoneWalls(int[] H)
        {
            if (H.Length == 1)
                return 1;

            Stack<int> activeBlocks = new Stack<int>();
            int minBlocks = 0;

            activeBlocks.Push(H[0]);
            minBlocks += 1;

            for (int i = 1; i < H.Length; i++)
            {
                while (activeBlocks.Count > 0 && H[i] < activeBlocks.Peek())
                    activeBlocks.Pop();

                int topBlock = activeBlocks.Count > 0 ? activeBlocks.Peek() : 0;

                if (topBlock != H[i])
                {
                    activeBlocks.Push(H[i]);
                    minBlocks += 1;
                }
            }

            return minBlocks;
        }

        public static int Nesting(string S)
        {
            Stack<int> opens = new Stack<int>();

            if (S.Length == 0)
                return 1;

            if (S.Length % 2 != 0)
                return 0;

            if (!S.Contains('(') || !S.Contains(')'))
                return 0;

            foreach (char c in S)
            {
                if (c == '(')
                    opens.Push('(');

                if (opens.Count > 0 && c == ')')
                    opens.Pop();
            }

            if (opens.Count > 0)
                return 0;

            return 1;
        }

        public static int Brackets(string S)
        {
            Stack<int> opens = new Stack<int>();

            foreach (char c in S)
            {
                switch (c)
                {
                    case '{':
                        opens.Push(1);
                        break;
                    case '[':
                        opens.Push(2);
                        break;
                    case '(':
                        opens.Push(3);
                        break;
                    case '}':
                        if (opens.Count > 0 && opens.Peek() == 1)
                            opens.Pop();
                        else
                            return 0;
                        break;
                    case ']':
                        if (opens.Count > 0 && opens.Peek() == 2)
                            opens.Pop();
                        else
                            return 0;
                        break;
                    case ')':
                        if (opens.Count > 0 && opens.Peek() == 3)
                            opens.Pop();
                        else
                            return 0;
                        break;
                    default:
                        break;

                }
            }

            if (opens.Count > 0)
                return 0;

            return 1;
        }
    }
}