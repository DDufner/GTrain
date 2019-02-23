using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GTrain.Models;
using GTrain.ViewModels;
using Microsoft.EntityFrameworkCore;
using GTrain.Data;

namespace GTrain.Controllers
{
    public class LoginController : Controller
    {
        /*
        [HttpGet]
        public IActionResult Register()
        {
        return View();
        }
        [HttpPost]
        public IActionResult Register(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("/Register");
            }
            ///check video 49 at 17:37 
            var user = new User { UserName = vm.UserName, Email = vm.Email, };
            var result = await _useManger.CreateAsyn
            
            if (result.Suceeded)
            {
                return View();
            
            return View(); 
        }
        */
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            ViewData["Title"] = "This is the Administator login page";
            return View();
        }

        public IActionResult Trainer()
        {
            return View();
        }

        public IActionResult Trainee()
        {
            return View();
        }

    }
}