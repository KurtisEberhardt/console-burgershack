namespace burgershack.Interfaces
{
    interface ISize
    {
        Size Size { get; set; }
        decimal GetSizePrice(Size s);
    }
}