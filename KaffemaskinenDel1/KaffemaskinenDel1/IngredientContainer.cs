using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffemaskinenDel1
{
    class IngredientContainer
    {
        public enum ingredients { coffee, }

        public string FillIngredients(ingredients ingredient)
        {
            if (ingredient.Equals(ingredients.coffee))
            {
                return "Filling inrgredient container with coffee";
            }
            else
            {
                return "Invalid ingredient inserted";
            }
        }
    }
}
