using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult procesar(String usuario, String DUI) {
            if (usuario.Equals("William")&& DUI.Equals("12345678")) {
                return Redirect("/Persona/segundavista");
            }
            return Redirect("/Persona/Index");
        }

        public ActionResult segundavista() {
            return View();
        }

        public ActionResult MostrarDatosPrecesados(String nombre, String hrstrab, String antiguedad, String valorH) {
            ViewBag.nombre = nombre;
            ViewBag.hrstrab = hrstrab;
            ViewBag.antiguedad = antiguedad;
            ViewBag.valorh = valorH;

            float total = float.Parse(valorH) * float.Parse(hrstrab) + float.Parse(antiguedad) * 30;
            ViewBag.total = total;

            float totaldescuento = (float)(total * 0.13);
            ViewBag.totalA = totaldescuento;

            float totalcondescuento = total- totaldescuento;
            ViewBag.totalB = totalcondescuento;

            return View();           
        }
    }
}