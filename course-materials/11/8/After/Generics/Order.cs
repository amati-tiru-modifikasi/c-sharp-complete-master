using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    internal class Order<T> : IOrder<T> where T : Product
    {
        private readonly List<OrderItem<T>> _orderItems;
        public List<OrderItem<T>> OrderItems
        {
            get { return _orderItems; }
        }

        public Order()
        {
            _orderItems = new List<OrderItem<T>>();
        }

        public Order(List<OrderItem<T>> orderItems)
        {
            _orderItems = orderItems;
        }

        public void AddOrderItem(OrderItem<T> orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public List<OrderItem<T>> GetOrderItemByProductId(int productId)
        {
            return _orderItems.Where(orderItem => orderItem.Product.ProductId == productId).ToList();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine("Shopping cart details");
            foreach (var orderItem in _orderItems)
            {
                string text = $"Order {orderItem.Id} : {orderItem.Product.Reference} x {orderItem.Quantity}";
                stringBuilder.AppendLine(text);
            }
            return stringBuilder.ToString();
        }
    }
}