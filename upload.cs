using System;
using System.Collections.Generic;
using System.Text;

namespace pbobaruuts
{
    class uploadParty
    {
        public string recipeName;
        public int ingredientNum;
        public static int ingredientIndex = 1;
        public void uploadRecipe()
        {
            Console.WriteLine("What recipe do you want to share today?");
            recipeName = Console.ReadLine();

            Console.WriteLine("How many ingredients are needed?");
            ingredientNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What are the ingredients for this recipe?");

            for (int i = 0; i < ingredientNum; i++)
            {
                ingredientFormat newrecipe = new ingredientFormat()
                {
                    ingName = Console.ReadLine(),
                    ingAmount = Console.ReadLine()
                };
                Console.WriteLine("#{0}.) {1} {2}",
                ingredientIndex, newrecipe.ingAmount, newrecipe.ingName);
                Console.WriteLine("");
                ingredientIndex++;
            }
        }
    }
}