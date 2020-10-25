﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
                Console.WriteLine("Hello World!");

            Console.WriteLine(LessonSeven.Fish(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 })); // 2
            Console.WriteLine(LessonSeven.Fish(new int[] { 4 }, new int[] { 0 })); // 1
            Console.WriteLine(LessonSeven.Fish(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 0, 0, 0, 0 })); // 1
            Console.WriteLine(LessonSeven.Fish(new int[] { 4, 3, 2, 1, 5 }, new int[] { 1, 0, 1, 0, 1 })); // 3
            Console.WriteLine(LessonSeven.Fish(new int[] { 4, 3, 2, 0, 5 }, new int[] { 0, 1, 0, 0, 0 })); // 2
            Console.WriteLine(LessonSeven.Fish(new int [] { 4, 3, 2, 1, 5 }, new int [] { 0, 1, 0, 0, 0 })); // 2
            Console.WriteLine(LessonSeven.Fish(new int [] { 4, 3, 2, 1, 5 }, new int [] { 0, 1, 1, 0, 0 })); // 2
            Console.WriteLine(LessonSeven.Fish(new int [] { 4, 3, 2, 5, 6 }, new int [] { 1, 0, 1, 0, 1 })); // 2
            Console.WriteLine(LessonSeven.Fish(new int [] { 7, 4, 3, 2, 5, 6 }, new int [] { 0, 1, 1, 1, 0, 1 })); // 3
            Console.WriteLine(LessonSeven.Fish(new int [] { 3, 4, 2, 1, 5 }, new int [] { 1, 0, 0, 0, 0 })); // 4
            Console.WriteLine(LessonSeven.Fish(new int [] { 3 }, new int [] { 1 })); // 1
            Console.WriteLine(LessonSeven.Fish(new int [] { 3 }, new int [] { 0 })); // 1
        }
    }
}