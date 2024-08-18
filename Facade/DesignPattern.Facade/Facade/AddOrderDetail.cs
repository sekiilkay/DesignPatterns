using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Facade
{
    public class AddOrderDetail
    {
        AppDbContext context = new AppDbContext();
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }
    }
}
