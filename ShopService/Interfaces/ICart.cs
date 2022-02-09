namespace ShopService.Interfaces
{
    public interface ICart
    {
        IEnumerable<Product> Items { get; }
        decimal Total { get; }

        void Add(Product product);
        void Remove(Product product);
    }
}