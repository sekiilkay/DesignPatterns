using DesignPattern.Template.Template;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Template.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlan()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(60);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480px");
            return View();
        }

        public IActionResult StandartPlan()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(3);
            ViewBag.v3 = netflixPlans.Price(80);
            ViewBag.v4 = netflixPlans.Content("Animasyon");
            ViewBag.v5 = netflixPlans.Resolution("720px");
            return View();
        }

        public IActionResult UltraPlan()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(5);
            ViewBag.v3 = netflixPlans.Price(100);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi-Animasyon");
            ViewBag.v5 = netflixPlans.Resolution("1080px");
            return View();
        }
    }
}
