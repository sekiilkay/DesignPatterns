using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class CreateNotifier : INotifier
    {
        AppDbContext context = new AppDbContext();
        public void CreateNotify(Notifier notifier)
        {
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
    }
}
