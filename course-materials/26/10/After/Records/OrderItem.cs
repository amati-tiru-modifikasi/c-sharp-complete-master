namespace Records
{
    public record OrderItem(int Id, string ProductCode, int Quantity);
    public record OnlineOrderItem(int Id, string ProductCode, int Quantity, string DeliveryMode) 
        : OrderItem(Id, ProductCode, Quantity);
    public record InStoreOrderItem(int Id, string ProductCode, int Quantity, string Store) 
        : OrderItem(Id, ProductCode, Quantity);
}