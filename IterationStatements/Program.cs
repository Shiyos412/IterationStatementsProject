using System;
using System.Collections.Generic;
using System.Linq;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            

            //DONE - Create a List called "numbers"
            var numbers = new List<int>();
            //DONE -Create a variable of type int with an initializer of 0
            var num = 0;

            string[] arr = new string[10];
            string s = String.Join("", arr);
            // Create a do-while loop
            do
            {

                // DONE - Increment your variable by 1
                num++;
                // DONE - Then add your variable to "numbers"
                numbers.Add(num);

            } while (num < 100);
            // DONE - While your variable is less than 100



            // DONE - Create a while loop
            // DONE - While your variable is less than 200
            while(num < 200)
            {

                // DONE - Increment your variable by 1
                num++;
                // DONE - Then add your variable to "numbers"
                numbers.Add(num);

            }

            Console.WriteLine("Increase:");

            // DONE - Create a foreach loop
            // DONE - Write your variable to the console
            foreach(int a in numbers)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for(int i = 199; i <= numbers.ToArray().Length && i >= 0; i--)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
