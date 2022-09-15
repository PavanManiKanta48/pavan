using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---This is a Basic Calculator---");    //this is a calculator
            Console.Write("Please Enter  an operator (+, -, *, /) :");     //Takes opearator
            char Op = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter First Number1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());        // takes number

            Console.Write("Enter second  Number2 :");             // takes number
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (Op == '+')                                            //it will add two numbers
            {
                Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
            }
            else if (Op == '-')                                        //It Will subtract two numbers    
            {
                Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
            }
            else if (Op == '/')                                        //It Will Divide two numbers    
            {
                Console.WriteLine("{0}/{1}={2}", num1, num2, num1 / num2);
            }
            else if (Op == '*')                                      //It Will Multiply two numbers    
            {
                Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
            }

            else                                                      // if u do not follow the correct order
            {
                Console.WriteLine("You entered a wrong input. please check it ");
            }
        }
    }
}
