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
            IOrder<Product> order1 = new Order<Product>(orderItems);

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
            IOrder<InStoreProduct> order2 = new Order<InStoreProduct>(inStoreOrderItems);

            Print(order1);
            IOrder<InStoreProduct> order3 = Create<Order<InStoreProduct>>();

            order3.AddOrderItem(
                new OrderItem<InStoreProduct>
                {
                    Id = 1,
                    Product = new InStoreProduct
                    {
                        ProductId = 5,
                        Category = "Category1",
                        Reference = "Reference5",
                        StoreId = 1
                    },
                    Quantity = 3
                }
            );
            Console.WriteLine();
            Print(order3);
        }

        private static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }

        private static TReturn Create<TReturn>() where TReturn : new()
        {
            return new TReturn();
        }
    }
}
