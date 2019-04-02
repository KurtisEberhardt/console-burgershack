using burgershack.Interfaces;

namespace burgershack.Models
{
    class Drink : MenuItem, ISize, IPurchasable
    {
        public string Description { get; set; }
        public Size Size { get; set; }
        public int Stock { get; set; }

        public decimal GetSizePrice(Size s)
        {
            return Price + (((int)s + 1) / 2);
        }

        public Drink(string name, decimal price, string description) : base(name, price)
        {
            Size = Size.large;
            Description = description;
        }

    }


}