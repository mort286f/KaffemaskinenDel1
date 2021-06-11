using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffemaskinenDel1
{
    class DrinkMachine : Machine
    {
        public override string Start()
        {
            return "DrinkMachine starting..";
        }
        public override string Stop()
        {
            return "DrinkMachine shutting down..";
        }

        public string MakeXDrinks(int drinkCount)
        {
            return $"Making {drinkCount} drinks";
        }
    }
}
