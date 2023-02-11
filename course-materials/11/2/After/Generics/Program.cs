using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderItems = new List<OrderItem<Product>>
            {
                new OrderItem<Product>
                {
                    Id = 1,
                    Product = new OnlineProduct
                    {
                        ProductId = 1,
                        Category = "Category1",
                        Reference = "Reference1",
                        ShippingOption = "ShippingOption1"
                    },
                    Quantity = 1
                },
                new OrderItem<Product>
                {
                    Id = 2,
                    Product = new InStoreProduct
                    {
                        ProductId = 2,
                        Category = "Category2",
                        Reference = "Reference2",
                        StoreId = 1
                    },
                    Quantity = 1
                }
            };
            var order1 = new Order<Product>(orderItems);

            var inStoreOrderItems = new List<OrderItem<InStoreProduct>>
            {
                new OrderItem<InStoreProduct>
                {
                    Id = 1,
                    Product = new InStoreProduct
                    {
                        ProductId = 3,
                        Category = "Category1",
                        Reference = "Reference3",
                        StoreId = 1
                    },
                    Quantity = 1
                },
                new OrderItem<InStoreProduct>
                {
                    Id = 2,
                    Product = new InStoreProduct
                    {
                        ProductId = 4,
                        Category = "Category1",
                        Reference = "Reference4",
                        StoreId = 1
                    },
                    Quantity = 1
                }
            };
            var order2 = new Order<InStoreProduct>(inStoreOrderItems);
        }
    }
}
