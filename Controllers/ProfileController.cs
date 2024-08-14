using System.Linq;
using System.Web.Mvc;
using thanhtri_2121110007.Context;

namespace thanhtri_2121110007.Controllers
{
    public class ProfileController : Controller
    {
        private WebTriEntities _context;

        public ProfileController()
        {
            _context = new WebTriEntities();
        }

        // GET: Profile/Index
        public ActionResult Index()
        {
            var email = Session["username"] as string;
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Login", "User");
            }

            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                return RedirectToAction("Login", "User");
            }

            return View(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
