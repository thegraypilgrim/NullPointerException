using Chronos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chronos.Models;

namespace Chronos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            TodoList list = new TodoList {
                Items = new List<string>()
            };
            list.Items.Add("Do this");
            list.Items.Add("Do that");
           
            Calendar userCalaneder = new Calendar();
            return View(list, userCalaneder);
        }
    }
}