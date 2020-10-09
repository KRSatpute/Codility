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
            
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{1000,-999,-998,1,3,4})); // [1,3,4,-998,-999,1000] : (1000,-999,-998) 1
            Console.WriteLine(1000*-999*-998);
            Console.WriteLine("1__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-4,-3,-2,-1,1,3000,4})); // [-1,1,-2,-3,-4,4,3000] : (3000,-4,-3) 2
            Console.WriteLine(3000*-4*-3);
            Console.WriteLine("2__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-1000,-2,-1,1,2,3})); // [-1,1,-2,2,3,-1000] : (-1000,3,-2) 3
            Console.WriteLine(-1000*3*-2);
            Console.WriteLine("3__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-1000,-999,-998,999,1000})); // [-998,-999,999,-1000,1000] : (-1000,1000,-999) 4
            Console.WriteLine(-1000*1000*-999);
            Console.WriteLine("4__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-1000,-999,-998,1,1,1})); // [1,1,1,-998,-999,-1000] : (-1000,-999,1) 5
            Console.WriteLine(-1000*-999*1);
            Console.WriteLine("5__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-5,-5,0,4,5})); // [0,4,-5,-5,5] : (5,-5,-5) 6
            Console.WriteLine(5*-5*-5);
            Console.WriteLine("6__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-700,-1,0,1,3,400})); // [0,-1,1,3,400,-700] : (-700,400,-1) 7
            Console.WriteLine(-700*400*-1);
            Console.WriteLine("7__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-61,32,58,1,1,3,899})); // [1,1,3,32,58,-61,899] : (899,58,32) 8
            Console.WriteLine(899*58*32);
            Console.WriteLine("8__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-1,-9,-8,9,1})); // [-1,1,-8,-9,9] : (9,-9,-8) 9
            Console.WriteLine(9*-9*-8);
            Console.WriteLine("9__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-1,-9,-8,-9,-11})); // [-1,-8,-9,-9,-11] : (-9,-8,1) 10
            Console.WriteLine(-9*-8*-1);
            Console.WriteLine("10__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{1,9,8,9,11})); // [1,8,9,9,11] : (11,9,9) 11
            Console.WriteLine(11*9*9);
            Console.WriteLine("11__________________");
            Console.WriteLine(LessonSix.MaxProductOfThree(new int[]{-3, 1, 2, -2, 5, 6})); // [1,2,-2,-3,5,6] : (6,5,2) 12
            Console.WriteLine(6*5*2);
            Console.WriteLine("12__________________");
        }
    }
}