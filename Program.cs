using System;

namespace C_Sharp_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = method1();
            input = method2(input);
            input = method3(input);
            method4(input);

        }

        static string method1()
        {
            Console.WriteLine("Can you enter your name");
            return Console.ReadLine();
        }
        
        static string method2(string input)
        {
            input = input+":)";
            return input;
            
        }

        static string method3(string input)
        {
            input = ":("+input;
            return input;
        }

        static void method4(string input)
        {
            Console.WriteLine(input);
        }

    }
}
