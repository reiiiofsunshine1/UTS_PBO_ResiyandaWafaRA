using System;
using System.Collections.Generic;
using System.Text;

namespace pbobaruuts
{
    class customer
    {
        public void userDet() 
        {
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("Where is your addresss?");
            string myAddress = Console.ReadLine();
        }
    }
}