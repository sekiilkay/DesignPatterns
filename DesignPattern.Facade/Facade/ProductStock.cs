using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Facade
{
    public class ProductStock
    {
        AppDbContext context = new AppDbContext();
        public void StockDecrease(int id, int amount)
        {
            var value = context.Products.Find(id);
            value.Stock -= amount;
            context.SaveChanges();
        }
    }
}
