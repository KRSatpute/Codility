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

            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 })); //7
            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 })); //1
            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })); //9
            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })); //9
            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 1, 1, 2, 1, 2 })); //3
            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 1000000000 })); //1
            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 })); //7
            Console.WriteLine(LessonSeven.StoneWalls(new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 })); //7
        }
    }
}