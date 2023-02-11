using System.Collections.Generic;

namespace Generics
{
    internal class Order<T> where T : Product
    {
        private readonly List<OrderItem<T>> _orderItems;

        public Order()
        {
            _orderItems = new List<OrderItem<T>>();
        }

        public Order(List<OrderItem<T>> orderItems)
        {
            _orderItems = orderItems;
        }
    }
}