using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "This is my default action..";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        public string Welcome1(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},NumTimes is : {numTimes}");
        }
        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
