using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndLargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num= { 23, 4, 54, 51, 32, 12, 3 };  //array with random numbers                                  
            string name;
            Console.Write("Find Second Largest Element Of an Array :\n");   
            Console.Write("--------------------------------------- \n");
            Array.Sort(num);                                      //Sort the order
            Console.WriteLine(num[num.Length - 2]);               //Logic to find second largest number 

            Console.Write("Array to Find Length and Index position Of the string :\n");
            Console.Write("----------------------------------------------------- \n");
            Console.Write("Enter a name :");          
            name=Console.ReadLine();                         //take a name
            Console.WriteLine("Second character fron the given string is: '{0}'",name[2]);                      //Display 2nd character in given name

                Console.WriteLine(" length of given string: {0}",name.Length);            //To Find length of given string

            Console.ReadLine();
           
        }
    }
}
