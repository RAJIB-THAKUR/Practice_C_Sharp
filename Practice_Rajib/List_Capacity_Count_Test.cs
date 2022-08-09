using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;

/*#region Testing List Size Growing
namespace ListCapacityTesting
{
    public class TestingListSizeGrowing
    {
        public static void Main()
        {
            long i = 0;
            List<int> li = new List<int>();
            li.Add(12);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();

            li.Add(23);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(4);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(7);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(122);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(232);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(422);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(722);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(12);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(12);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(23);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(4);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(7);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(122);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(232);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(422);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(722);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();
            li.Add(12);
            Console.WriteLine("{0} Element inserted", ++i);
            Console.WriteLine("Current count: {0}", li.Count);
            Console.WriteLine("Current capacity: {0}", li.Capacity);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
#endregion*/