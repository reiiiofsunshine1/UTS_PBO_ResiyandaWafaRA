using System;
using System.Collections.Generic;
using System.Text;

namespace pbobaruuts
{
    class sorryPage
    {
        public void srrymsg()
        {
            Console.WriteLine("Invalid number! Please insert either '1' or '2' to continue.");
        }
        public void srryrec()
        {
            Console.WriteLine("Sorry! The recipe is unavailable yet!");
        }
        public void cont()
        {
            Console.WriteLine("Do you want to continue?\nYes/No?");
            string buh = Console.ReadLine();
            
            if(buh == "yes" || buh == "Yes" || buh == "YES")
            {
                choice newvar = new choice();
                newvar.choose();
            }
            else
            {
                Console.WriteLine("Thankyou for choosing us!");
                return;
            }
        }
    }
}