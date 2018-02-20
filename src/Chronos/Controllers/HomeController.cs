using Chronos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
           
            Calendar userCalendar = new Calendar();
            GroupContentModel groupContent = new GroupContentModel();
            groupContent.TodoList = list;
            groupContent.Calendar = userCalendar;
            return View(groupContent);
        }
        public ViewResult Login() {
            return View();
        }
    }
}