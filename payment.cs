using System;
using System.Collections.Generic;
using System.Text;

namespace pbobaruuts
{
    class paymentMsg
    {
        public void paymentcc()
        {
            Console.WriteLine("Sorry!\nThis method is unavalaiable!\nWe will update you if there are improvements made!");
        }
        public void paymentcod()
        {
            Console.WriteLine("Alright!\nPlease prepare your money while we deliver your order!");
        }
        public void paymethod()
        {
            Console.WriteLine("Please select the payment method you wish for:\n1) Cash\n2) Debit\n3) Credit Card");
            int paychoose = Convert.ToInt32(Console.ReadLine());
            if (paychoose == 1)
            {
                paymentcod();
            }
            else
            {
                paymentcc();
            }
        }
    }
}