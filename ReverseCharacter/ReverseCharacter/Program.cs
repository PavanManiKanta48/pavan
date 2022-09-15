using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            Console.Write("Enter the First letter :");
            a = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the First letter :");
            b = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the First letter :");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", c, b, a);
        }
    }
}
