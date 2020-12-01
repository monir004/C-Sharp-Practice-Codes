using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The collection classes are helpful to maintain the state of the data In-Memory, which is later available for read/write operations
//In the.NET framework, there are several classes available for performing these operations.Some of the classes are as follows:

//List
//Dictionary
//HashSet
//Queue


//In C# programming, collections like ArrayList, List, simply adds values in it without checking any duplication. To avoid such a duplicate data store, .NET provides a collection name set. This is a collection type with distinct items.

//There are two types of sets, SortedSet and HastSet.The SortedSet stores data in sorted order and also eliminates duplication.

//Both the classes store non-duplicate items.However if you want performance and do not care if the items are stored unsorted, then go in for HashSet.However if you want the items to be sorted after insertion but are ready to take a performance hit, chose Sorted

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using HashSet");
            //1. Defining String Array (Note that the string "mahesh" is repeated) 
            string[] names = new string[] {
                "mahesh",
                "vikram",
                "mahesh",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };
            //2. Length of Array and Printing array
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            //3. Defining HashSet by passing an Array of string to it
            HashSet<string> hSet = new HashSet<string>(names);
            //4. Count of Elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();
            //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
