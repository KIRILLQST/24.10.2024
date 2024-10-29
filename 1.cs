using System;
using System.Collections.Generic;

namespace OrderSystem
{
    public class Order
    {
        private int _id;
        private string _customerName;
        private List<Product> _products;
        private decimal _totalCost;

        public Order(int id, string customerName)
        {
            _id = id;
            _customerName = customerName;
            _products = new List<Product>();
            _totalCost = 0;
        }

        public int Id
        {
            get { return _id; }
        }

        public string CustomerName
        {
            get { return _customerName; }
        }

        public List<Product> Products
        {
            get { return _products; }
        }

        public decimal TotalCost
        {
            get { return _totalCost; }
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
            _totalCost += product.Price;
        }
    }
}