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
            
            Console.WriteLine(LessonSix.NumberOfDiscIntersections(new int[]{1,5,2,1,4,0}));
        }
    }
}