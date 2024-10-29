namespace OrderSystem
{
    public interface IOrderLogistics
    {
        void ProcessOrder(Order order);
        void UpdateProductAvailability(int productId, int quantity);
    }
}