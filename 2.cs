namespace OrderSystem
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _price;

        public Product(int id, string name, decimal price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public decimal Price
        {
            get { return _price; }
        }
    }
}