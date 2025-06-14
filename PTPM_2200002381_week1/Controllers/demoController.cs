using Microsoft.AspNetCore.Mvc;

namespace PTPM_2200002381_week1.Controllers
{
    public class demoController : Controller
    {
        public string DemoA()
        {
            return "ngu";
        }
        
        public ViewResult DemoB()
        {
            ViewBag.Message = "Hello from DemoB";
            ViewBag.Mydata = "This is my data form DemoB"; 
            return View("Demo3");
        }


        public ViewResult Demo3()
        {
            ViewBag.Message = "Hello from Demo3";
            ViewBag.Mydata = "This is my data form Demo3"; 
            return View();
        }
    }
}
