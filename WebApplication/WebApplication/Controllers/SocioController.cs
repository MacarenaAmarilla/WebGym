using System.Web.Mvc;
using GimnasioWeb.Models;

namespace GimnasioWeb.Controllers
{
    public class SocioController : Controller
    {
        private GimnasioContext db = new GimnasioContext();

        public ActionResult Panel()
        {
            if (Session["socioId"] == null)
                return RedirectToAction("Login", "Home");

            ViewBag.Nombre = Session["socioNombre"];
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(Socio socio)
        {
            if (ModelState.IsValid)
            {
                int edad = System.DateTime.Today.Year - socio.FechaNacimiento.Year;
                if (socio.FechaNacimiento > System.DateTime.Today.AddYears(-edad)) edad--;

                if (edad < 16)
                {
                    ModelState.AddModelError("", "Debés tener al menos 16 años.");
                    return View(socio);
                }

                db.Socios.Add(socio);
                db.SaveChanges();
                return RedirectToAction("Login", "Home");
            }

            return View(socio);
        }
    }
}