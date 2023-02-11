namespace Generics
{
    internal class OrderItem<T> where T : Product
    {
        public int Id { get; set; }
        public T Product { get; set; }
        public int Quantity { get; set; }
    }
}