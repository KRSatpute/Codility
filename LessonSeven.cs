using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    public static class LessonSeven
    {
        public static int Brackets(string S)
        {
            Stack<int> opens = new Stack<int>();

            foreach(char c in S)
            {                    
                switch(c)
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