using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 54, 677, 34, 778, 5, 343, 6, 899, 55, 66 };
            List<int> numbers = new List<int> { 54, 677, 34, 778, 5, 343, 6, 899, 55, 66 };

            ////int query2 = (from num in numbers
            //              where num == 5
            //              select num).FirstOrDefault();//repeattation allowed
            //Console.WriteLine(query2);


            int query2 = (from num in numbers
                          where num == 5
                          select num).SingleOrDefault();//no repeatation allowed
            //Console.WriteLine(query2);

            //method:
            //IEnumerable<int> list = numbers.ToList();//immediate
            IEnumerable<int> list = numbers.Where(n=>n%2==0).ToList();//immediate


            int data = numbers.FirstOrDefault(n => n == 5);
            //int data=numbers.Where(n=>n==5).FirstOrDefault();
            //Console.WriteLine(data);


            //print all even no from array

            //linq:2 ways:declarative-expressive and method syntax-operator using lambda

            //    IEnumerable<int> query = from num in numbers
            //                             where num % 2 == 0
            //                             select num;

            //    //IEnumerable<int> query = (from num in numbers
            //    //                          where num % 2 == 0
            //    //                          select num).ToList();//Immediate execution

            //    //method syntax:
            //    query = numbers.Where(n => n % 2 == 0)//differed
            //    //query = numbers.Where(n => n % 2 == 0).ToList(); //Immediate execution

            //    foreach(int item in query)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("---------------------");

            //    numbers.Add(2002);
            //    foreach (int item in query)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    //for (int i = 0; i < numbers.Length; i++)
            //    //{
            //    //    //if (numbers[i] % 2 == 0)
            //    //    //{
            //    //    //    Console.WriteLine(numbers[i]);
            //    //    //}


            //    //}
            //}
            ////can you write reusable code
            ////public List<int> EvenNumbers(List<int> numarray)
            ////{
            ////    List<int> returnList = new List<int>;
            ////    for (int i = 0; i < numarray.Count; i++)
            ////    {
            ////        if (numarray[i] % 2 == 0)
            ////        {
            ////            Console.WriteLine(numarray[i]);
            ////        }
            ////    }
            ////    return returnList;
            ////}
            ////public static bool IsEven(int number)
            ////{
            ////    return number % 2 == 0;
            ////}
            string message = "welcome to entity core framwork";
            //findout total words in a string

            
            Console.WriteLine(message.WordCount());

        }
    }
}
