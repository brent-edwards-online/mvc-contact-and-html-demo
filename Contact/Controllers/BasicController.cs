using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ContactMVC.Entities;
using ContactMVC.Services;

namespace ContactMVC.Controllers
{
    public class BasicController : Controller
    {
        private IContactService _basicService;
        private IEmailService _emailService;
        private IMessageFormatter _messageFormatter;

        public BasicController(IContactService basicService, IEmailService emailService, IMessageFormatter messageFormatter)
        {
            _basicService = basicService;
            _emailService = emailService;
            _messageFormatter = messageFormatter;
        }

        public ActionResult Index()
        {
            return View();
        }
  
        //[HttpPost]
        //public JsonResult BasicAction()
        //{
        //    if (_basicService.BasicFunction() == true) 
        //    {
        //        return Json(new { Result = true, Message = "Email already entered" });
        //    }
        //    else
        //    {
        //        return Json(new { Result = false, Message = "Email unknown" });
        //    }
        //}
    }
}
