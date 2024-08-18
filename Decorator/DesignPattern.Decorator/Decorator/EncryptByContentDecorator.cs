using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class EncryptByContentDecorator : DecoratorMessage
    {
        private readonly ISendMessage _sendMessage;
        AppDbContext context = new AppDbContext();
        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageByEncryptByContent(Message message)
        {
            message.Sender = "İnsan Kaynakları";
            message.Receiver = "Yazılım Ekibi";
            message.Content = "Saat 17.00'da Publish yapılacak";
            message.Subject = "Publish";
            string data = "";
            data = message.Content;
            char[] chars = data.ToCharArray();

            foreach (var item in chars)
            {
                message.Content += Convert.ToChar(item + 3).ToString();
            }

            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptByContent(message);
        }
    }
}
