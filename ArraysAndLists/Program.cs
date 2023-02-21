using System;
using System.Collections.Generic; // Needed for lists

namespace ArraysAndLists // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            int[] nums; // Make array
            int[] nums2 = new int[5]; // Make array with 5 slots
            int[] nums3 = { 32, 12, 43, 43, 23 }; // Make array with values provided

            Console.WriteLine(nums3[2]); // Wries 43 since arrays start from 0 instead of 1
            Console.WriteLine(nums3.Length); // Writes the length of the array











            // Lists
            List<int> numsList = new List<int>(); // Makes a list

            // These add the numbers to the list (lists can be modified while arrays cant be)
            numsList.Add(54); 
            numsList.Add(43);
            numsList.Add(23); // this the one being printed
            numsList.Add(65);
            numsList.Add(34);
            Console.WriteLine(numsList[2]);

            // Removing a specific number from the list
            numsList.Remove(54);
            Console.WriteLine("54 is removed from the list");

            // Removing by index number
            numsList.RemoveAt(2);
            Console.WriteLine("Removed number at index number 2");

            // Soring in ascending order
            numsList.Sort();
            Console.WriteLine(numsList[0]);

            //Reverse the order of the list
            numsList.Reverse();
            Console.WriteLine(numsList[0]);

            // Get list size
            Console.WriteLine($"List size is {numsList.Count}");
        }
    }
}