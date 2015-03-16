using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage("Hello World!"));
        }

        public static string CreateMessage(string message)
        {
            return message;
        }

       
    }
}
