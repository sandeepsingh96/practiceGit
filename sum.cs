using System;
using System.Collections.Generic;
using System.Linq;

// Part 1: declare 2 collections of int elements.
int[] array1 = { 1, 1, 2 };
List<int> list1 = new List<int>() { 1, 1, 2, 3 };

// Part 2: use Sum extension on their elements.
int sum1 = array1.Sum();
int sum2 = list1.Sum();

// Part 3: write results to screen.
Console.WriteLine("SUM: {0}", sum1);
Console.WriteLine("SUM: {0}", sum2);