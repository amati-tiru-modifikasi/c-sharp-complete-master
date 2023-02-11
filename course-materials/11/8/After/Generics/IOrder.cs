using System.Collections.Generic;

namespace Generics
{
    internal interface IOrder<T> where T : Product
    {
        public List<OrderItem<T>> OrderItems { get ; }
        public void AddOrderItem(OrderItem<T> orderItem);
        public List<OrderItem<T>> GetOrderItemByProductId(int productId);

    }
}