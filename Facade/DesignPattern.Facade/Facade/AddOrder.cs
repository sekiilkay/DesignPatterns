using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Facade
{
    public class AddOrder
    {
        AppDbContext context = new AppDbContext();
        public void AddNewOrder(Order order)
        {
            order.OrderDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
