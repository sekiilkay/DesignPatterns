using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class MailDecorator : Decorator
    {
        AppDbContext context = new AppDbContext();
        private readonly INotifier _notifier;
        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.Subject = "Günlük Sabah Toplantısı";
            notifier.Creater = "Scrum Master";
            notifier.Channel = "Gmail-Outlook";
            notifier.Type = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotify(notifier);
        }
    }
}
