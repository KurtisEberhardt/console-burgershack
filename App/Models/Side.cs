using burgershack.Interfaces;

namespace burgershack.Models
{
    class Side : MenuItem, ISize, IPurchasable
    {
        public Size Size { get; set; }
        public int Stock { get; set; }

        public decimal GetSizePrice(Size s)
        {
            return Price + (int)s;
        }


        public Side(string name, decimal price) : base(name, price)
        {
            Size = Size.large;
        }
    }


}