using System;
using System.Collections.Generic;
using System.Text;

namespace pbobaruuts
{
    class SearchParty
    {
        public void choosemenu()
        {
            string bahannasgor = "nasi\t\t1 liter\nkecap manis\t1 sendok makan\ngaram\t\tsejumput \nsayur\t\tsesuai selera";
            string bahansoto = "telur\t\t2 buah\nsantan\t\t2 sendok \ndaging\t\t500 gram\nkaldu ayam\t2 sendok teh";

            Console.WriteLine("What recipe would you like to see today?");
            string menupilih = Console.ReadLine();
            if (menupilih == "soto")
            {
                Console.WriteLine("Siapkan:\n{0}", bahansoto); 
            }
            else if (menupilih == "nasigoreng")
            {
                Console.WriteLine("Siapkan:\n{0}", bahannasgor);  
            }
            else
            {
                sorryPage bah = new sorryPage();
                bah.srryrec();
            }
        }
    }
}