using System.Collections.Generic;
using burgershack.Interfaces;

namespace burgershack.Models
{
    class Burger : MenuItem, IPurchasable
    {
        List<string> Ingredients { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public void AddIngredient(List<string> i)
        {
            Ingredients = i;
        }

        public Burger(string name, decimal price, string description) : base(name, price)
        {
            Ingredients = new List<string>();
            Description = description;
        }
    }
}