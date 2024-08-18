using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Facade
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();
        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void CompleteOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            orderDetail.CustomerId = customerId;
            orderDetail.ProductId = productId;
            orderDetail.OrderId = orderId;
            orderDetail.ProductCount = productCount;
            decimal totalProductPrice = productCount * productPrice;
            orderDetail.ProductTotalPrice = totalProductPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);
            productStock.StockDecrease(productId, productCount);
        }
        public void CompleteOrder(int customerId)
        {
            order.CustomerId = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
