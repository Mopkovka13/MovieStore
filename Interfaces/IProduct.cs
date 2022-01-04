namespace MovieStore.Interfaces
{
    public interface IProduct
    {
        uint Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        uint Volume { get; set; }
    }
}
