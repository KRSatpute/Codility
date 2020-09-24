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

            Console.WriteLine(LessonFive.CountDiv(0, 2000000000, 2000000000));
        }
    }
}