using System.Collections.Generic;
using burgershack.Interfaces;
using burgershack.Models;

namespace burgershack
{
    class App
    {
        List<MenuItem> Menu { get; set; }
        private void Initialize()
        {
            Menu.Add(new Burger("Cowboy", 5.78m, "Yeehaw dig in to this delicous bbq and onion ring burger"));
            Menu.Add(new Side("Fries", 1.50m));
            Menu.Add(new Side("Onion Rings", 2.00m));
            Menu.Add(new Drink("Chocolate milkshake", 2.65m, "The best chocolate milkshake this side of the Mississippi"));

        }

        public void Run()
        {
            Initialize();
            //Print Menu
            ///get user input
            MenuItem selection = Menu[2];
            if (selection is ISize)
            {
                //prompt which size do you want
                ISize ISelection = (ISize)selection;
                ISelection.Size = (Size)0;
            }
        }


        public App()
        {
            Menu = new List<MenuItem>();
        }
    }



    public enum Size
    {
        small,
        medium,
        large,
        gallon
    }

    public enum DrinkType
    {
        fountain = 1,
        milkshake = 2,
        spirit = 3
    }
}