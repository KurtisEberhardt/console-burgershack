namespace burgershack.Models
{
    class MenuItem
    {
        public string Name { get; }
        public decimal Price { get; set; }

        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}