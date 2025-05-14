using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Lab_MVC_1_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult FirstViewMethod()
        {
            var vegetables = new List<string> { "Картофель", "Морковь", "Свёкла", "Капуста", "Огурец", "Помидор" };
            return View(vegetables);
        }

        public ActionResult SecondViewMethod()
        {
            var vegetables = new List<string> { "Картофель", "Морковь", "Свёкла", "Капуста", "Огурец", "Помидор" };
            vegetables.Sort();
            return View(vegetables);
        }

        public ActionResult ThirdViewMethod()
        {
            var vegetables = new List<string> { "Картофель", "Морковь", "Свёкла", "Капуста", "Огурец", "Помидор" };
            var grouped = vegetables.GroupBy(v => v[0]).ToDictionary(g => g.Key, g => g.ToList());
            return View(grouped);
        }
    }
}
