using Demo_App_Business.Service;
using Demo_App_Data.Models;
using EF_Core_New.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_New.Controllers
{
    public class UserController : Controller
    {

        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserRegistration()
        {
            return View();
        }

        public IActionResult GetUserList()
        {

            return View();
        }




        [HttpPost]
        public ActionResult Submit(UserModel objUserModel)
        {
            if (objUserModel.Id == 0 )
            {
                _userService.AddUser(objUserModel);
            }
            else
            {
                _userService.UpdateUser(objUserModel);
            }

          //  return Json(new { success = true });
            return RedirectToAction("GetUserList");
        }

       
        [HttpGet]
        public JsonResult GetMyUser()
        {
           var result =  _userService.GetUser();
            
            return new JsonResult(result);
        }

        [HttpGet]
        public ActionResult GetMyUserById(int Id)
        {
            var result = _userService.GetUserById(Id);

            return  Json(result);
        }

        [HttpPost]
        public ActionResult DeleteUser(int Id)
        {
            if (Id != 0)
            {
                _userService.DeleteUser(Id);
               // return RedirectToAction("GetUserList");

            }
            return Json(new { success = true,id=Id, msg="record deleted successfully!!" });

            // return RedirectToAction("GetUserList");
        }



    }
}
