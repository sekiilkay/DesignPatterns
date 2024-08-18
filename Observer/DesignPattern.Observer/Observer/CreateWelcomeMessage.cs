using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.Observer
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                FullName = appUser.Name + " " + appUser.Surname,
                Content = "Dergi Bültenimize Kayıt Olduğunuz için Teşekkür Ederiz"
            });
            context.SaveChanges();
        }
    }
}
