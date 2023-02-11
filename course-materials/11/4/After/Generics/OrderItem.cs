namespace Generics
{
    internal class OrderItem<T>
    {
        public int Id { get; set; }
        public T Product { get; set; }
        public int Quantity { get; set; }
    }
}