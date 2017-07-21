using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using BasicMVC.Entities;
using BasicMVC.Services;

namespace BasicMVC.Controllers
{
    public class BasicController : Controller
    {
        private IBasicService _basicService;
        private IEmailService _emailService;
        private IMessageFormatter _messageFormatter;

        public BasicController(IBasicService basicService, IEmailService emailService, IMessageFormatter messageFormatter)
        {
            _basicService = basicService;
            _emailService = emailService;
            _messageFormatter = messageFormatter;
        }

        public ActionResult Index()
        {
            return View();
        }
  
        [HttpPost]
        public JsonResult BasicAction()
        {
            if (_basicService.BasicFunction() == true) 
            {
                return Json(new { Result = true, Message = "Email already entered" });
            }
            else
            {
                return Json(new { Result = false, Message = "Email unknown" });
            }
        }
    }
}
