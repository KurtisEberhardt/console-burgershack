namespace burgershack.Interfaces
{
    interface IPurchasable
    {
        decimal Price { get; set; }
        int Stock { get; set; }
    }
}