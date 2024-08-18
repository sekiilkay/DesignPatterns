using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class Decorator : INotifier
    {
        private readonly INotifier _notifier;
        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void CreateNotify(Notifier notifier)
        {
            notifier.Creater = "Admin";
            notifier.Subject = "Toplantı";
            notifier.Type = "Public";
            notifier.Channel = "Email";
            _notifier.CreateNotify(notifier);
        }
    }
}
