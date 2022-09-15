using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");            //Takes Number
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Width :");              //Takes Number
            int Width = Convert.ToInt32(Console.ReadLine());
            int height = Width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(num);

                }
                Console.WriteLine();
                Width--;
            }
        }
    }
}
