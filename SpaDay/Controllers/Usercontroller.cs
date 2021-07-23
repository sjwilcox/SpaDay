using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
   
    public class Usercontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User 
                { 
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password,
                    VerifyPassword = addUserViewModel.VerifyPassword
                    
                };
                
                return View("Index",user);
            }
            return View(addUserViewModel);
        }
    }
}
