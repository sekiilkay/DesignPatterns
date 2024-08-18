using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class SubjectIdDecorator : DecoratorMessage
    {
        private readonly ISendMessage _sendMessage;
        AppDbContext context = new AppDbContext();
        public SubjectIdDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageIdSubject(Message message)
        {
            if (message.Subject == "1")
            {
                message.Subject = "Toplantı";
            }

            if (message.Subject == "2")
            {
                message.Subject = "Scrum Toplantısı";
            }

            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIdSubject(message);
        }
    }
}
