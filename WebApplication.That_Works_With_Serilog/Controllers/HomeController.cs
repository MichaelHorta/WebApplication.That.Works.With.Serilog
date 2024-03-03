using Common.Logging;
using System.Web.Mvc;

namespace WebApplication.That_Works_With_Serilog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _logger;
        public HomeController()
        {
            _logger = LogManager.GetLogger<MvcApplication>();
        }

        public ActionResult Index()
        {
            _logger.Info("We enter in Index page!!!");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}