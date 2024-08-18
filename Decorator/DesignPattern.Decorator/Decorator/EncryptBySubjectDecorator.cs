using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class EncryptBySubjectDecorator : DecoratorMessage
    {
        private readonly ISendMessage _sendMessage;
        AppDbContext context = new AppDbContext();
        public EncryptBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageByEncryptBySubject(Message message)
        {
            string data = "";
            data = message.Subject;
            char[] chars = data.ToCharArray();

            foreach (var item in chars)
            {
                message.Subject += Convert.ToChar(item + 3).ToString(); 
            }

            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptBySubject(message);
        }
    }
}
