using System;
using System.Collections.Generic;
using System.Text;

namespace pbobaruuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Hello there! --------");
            customer userinput = new customer();
            userinput.userDet();
            Console.WriteLine("What do you want to do today?");
            choice myNumber = new choice();
            myNumber.choose();
            
        }
    }
}
