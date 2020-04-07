using ShoppingApp.Model;
using System.Linq;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    public class PrimjerController : Controller
    {
        private ShoppingDbEntities db = new ShoppingDbEntities();

        public ActionResult Index()
        {
            return View(db.Shoppings.ToList());
        }

        public ActionResult About()
        {
            return View(db.Shoppings.ToList());
        }
    }
}
