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