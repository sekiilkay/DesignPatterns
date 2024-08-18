using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.Decorator;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); ;
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            message.Content = "Bir content mesajı";
            message.Sender = "Admin İK";
            message.Receiver = "Herkes";
            message.Subject = "Deneme Yapıyoruz";
            CreateMessage createMessage = new CreateMessage();
            createMessage.SendMessage(message);
            return View();
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index2(Message message)
        {
            CreateMessage createMessage = new CreateMessage();
            EncryptBySubjectDecorator encryptBySubjectDecorator = new EncryptBySubjectDecorator(createMessage);
            encryptBySubjectDecorator.SendMessageByEncryptBySubject(message);
            return View();
        }

        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index3(Message message)
        {
            CreateMessage createMessage = new CreateMessage();
            SubjectIdDecorator subjectIdDecorator = new SubjectIdDecorator(createMessage);
            subjectIdDecorator.SendMessageIdSubject(message);
            return View();
        }
    }
}
