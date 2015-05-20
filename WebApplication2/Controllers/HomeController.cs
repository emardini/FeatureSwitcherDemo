namespace WebApplication2.Controllers
{
    using System.Web.Mvc;

    using FeatureSwitcher;

    using WebApplication2.Features;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult About()
        {
            if (Feature<AboutMethod>.Is().Disabled)
            {
                return this.HttpNotFound();
            }

            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}