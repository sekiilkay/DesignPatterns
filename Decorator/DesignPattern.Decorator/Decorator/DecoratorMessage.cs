using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class DecoratorMessage : ISendMessage
    {
        private readonly ISendMessage _sendMessage;
        public DecoratorMessage(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public virtual void SendMessage(Message message)
        {
            message.Receiver = "Everybody";
            message.Sender = "Admin";
            message.Content = "Toplantı mesajıdır.";
            message.Subject = "Toplantı";
            _sendMessage.SendMessage(message);
        }
    }
}
