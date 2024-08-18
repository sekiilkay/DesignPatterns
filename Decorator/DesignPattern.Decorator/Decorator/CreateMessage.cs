using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class CreateMessage : ISendMessage
    {
        AppDbContext context = new AppDbContext();
        public void SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
    }
}
