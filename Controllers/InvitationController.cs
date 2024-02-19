using Exam1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam1.Controllers
{
    public class InvitationController : Controller
    {
        public IActionResult Index()
        {
            var value = DemoDb.Invitations;
            return View(value);
        }

        public IActionResult Join() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Join(Invitation invitation)
        {
            if (DemoDb.Invitations.Any(x=>x.Email.Equals(invitation.Email)))
            {
                ModelState.AddModelError("", "Bu kişi için davet oluşturulmuş.");
            }
            if (ModelState.IsValid)
            {
                DemoDb.Save(invitation);
                //return RedirectToAction("Index");
                return View("FeedBack",invitation);
            }

            

            return View();
        }
    }
}
