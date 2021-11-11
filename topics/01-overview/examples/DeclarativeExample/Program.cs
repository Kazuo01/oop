/*
Minh họa lập trình khai báo với C#
Sắp xếp dãy số tăng dần 
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

using System;
using System.Collections.Generic;

// Creating a list of numbers
List<int> numbers = new List<int> { 3, 8, 2, 1, 5, 6 };

// Sort the list ascending
numbers.Sort();

// Print the sorted list
Console.WriteLine("Day tang dan:");
Console.WriteLine("{0}", string.Join(", ", numbers));