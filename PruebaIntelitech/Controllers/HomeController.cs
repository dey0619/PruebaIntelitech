using PruebaIntelitech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaIntelitech.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpPost]
        public ActionResult Index(PruebaIntelitech.Models.Empleados loginDataModel)
        {
        
            using (DataBase db = new DataBase())
            {
                var obj = db.Empleados.Where(a => a.Email.Equals(loginDataModel.Email)).FirstOrDefault();

                if (obj != null)
                {
                    Session["UserID"] = obj.Email.ToString();
                    Session["UserName"] = obj.Email.ToString();
                    return RedirectToAction("../Empleados/Index");
                    //return RedirectToAction("Contact");
                }
                else
                {
                    return View(loginDataModel);
                }
            }


        }

        public ActionResult LoginOK()
        {
            // LA VALIDACIÓN DEL USUARIO HA SIDO CORRECTA
            return View();
        }
    }
}