﻿namespace QueryOperation
{
    internal class Program
    {
      
    static void Main(string[] args)
        {
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           
            var query = from num in numbers
                        where num % 2 == 0
                        select num;

           
            foreach (var num in query)
            {
                Console.WriteLine(num);
            }
        }
    }
}
