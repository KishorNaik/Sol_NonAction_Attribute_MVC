using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_NonAction.Models;

namespace Sol_NonAction.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // Run in Browser (It Will Execute)
        //http://localhost:26043/Demo/GetUserData

        [NonAction] // Once the define NonAction Attribute in Action Method it will not execute the action
        public List<UserModel> GetUserData()
        {
            return new List<UserModel>()
            {
                new UserModel()
                {
                    FullName="Kishor"
                },
                new UserModel()
                {
                    FullName="Mahesh"
                }
            };
        }

    }
}