using BusinessLogicLayer;
using BusinessObjectsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserSignUp.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserBO objUserBo)
        {
            UserBL objUserBL = new UserBL();
            if(ModelState.IsValid)
            {

                CustomBO objCustomBo = objUserBL.AddUser(objUserBo);
                return View(objUserBo);
            } else
            {
                return View(objUserBo);
            }
        }


        //[HttpPost]
        //public async Task<IActionResult> Enter(SignUpModel model)
        //{
        //    var form = HttpContext.Request.Form;
        //    if (ModelState.IsValid)
        //    {

        //        var fileName = model.ProfilePicture.FileName;
        //        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

        //        using (var stream = System.IO.File.Create(filePath))
        //        {
        //            await model.ProfilePicture.CopyToAsync(stream);
        //        }

        //        return View("Success", model);
        //    }
        //    else
        //    {
        //        return View("SignUp", model);
        //    }
        //}
    }
}