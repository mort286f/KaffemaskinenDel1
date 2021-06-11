using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KaffemaskinenDel1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instances for the program
            DrinkMachine dm = new DrinkMachine();
            IngredientContainer ingContainer = new IngredientContainer();
            LiquidContainer liqContainer = new LiquidContainer();

            Console.WriteLine(dm.Start());
            Thread.Sleep(1000);
            Console.WriteLine("How many drinks do you wish to make?");
            int drinkCount = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine(ingContainer.FillIngredients(IngredientContainer.ingredients.coffee));
            Thread.Sleep(2000);
            Console.WriteLine(liqContainer.PourLiquid(LiquidContainer.liquids.water));
            Console.WriteLine(dm.MakeXDrinks(drinkCount));
            Thread.Sleep(2000);
            Console.WriteLine(dm.Stop());

            Console.Read();
        }
    }
}
