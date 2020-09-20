using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdventureExplore.Controllers
{
    public class RoomController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public string Rooms(string name, int width=5)
        {
            return HtmlEncoder.Default.Encode($"{name} Room, Width is : {width}");
        }
    }
}
