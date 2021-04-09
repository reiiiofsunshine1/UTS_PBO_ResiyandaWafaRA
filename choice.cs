using System;
using System.Collections.Generic;
using System.Text;

namespace pbobaruuts
{
    class choice
    {
        public void choose()
        {
            Console.WriteLine("Choose \n1) Search Recipe\n2) Upload Recipe");
            int myChoice = Convert.ToInt32(Console.ReadLine());
            if(myChoice == 1)
            {
                SearchParty newsearch = new SearchParty();
                newsearch.choosemenu();
                Console.WriteLine("Do you want to buy the ingredients?\nYes/No");
                string boh = Console.ReadLine();
                if(boh == "yes")
                {
                    paymentMsg newpay = new paymentMsg();
                    newpay.paymethod();
                }
                else
                {
                    sorryPage newcont = new sorryPage();
                    newcont.cont();
                }
            }
            else if (myChoice == 2)
            {
                uploadParty uploadrec = new uploadParty();
                uploadrec.uploadRecipe();
                sorryPage newcont = new sorryPage();
                newcont.cont();
            }
            else
            {
                sorryPage errmsg = new sorryPage();
                errmsg.srrymsg();
                Console.WriteLine("\n------------------\n");
                choose();
            }
        }
    }
}