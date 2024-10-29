
namespace OrderSystem
{
    public class ProductCatalog
    {
        private Dictionary<int, Product> _products;

        public ProductCatalog()
        {
            _products = new Dictionary<int, Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product.Id, product);
        }

        public void RemoveProduct(int productId)
        {
            _products.Remove(productId);
        }

        public Product GetProduct(int productId)
        {
            if (_products.ContainsKey(productId))
            {
                return _products[productId];
            }
            return null;
        }
    }
}