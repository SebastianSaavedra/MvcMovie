using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //Get: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        //
        //Get: /HelloWorld/Welcome/
        public string Welcome(string name = "redacted", int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, el valor de NumTimes es: {numTimes}");
        }
    }
}
