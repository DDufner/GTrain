using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using GTrain.ViewModels;
using GTrain.Data;
using GTrain.Models;

namespace GTrain.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string useremail, string password)
        {
            return View();
        }
        readonly private TrainingDbContext context;

        public LoginController(TrainingDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Register()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View();
        }
        
        [HttpPost]
        public IActionResult Register(LoginViewModel loginViewModel)
        {
   
            if (ModelState.IsValid)
            {
                Login login  = new Login

                {
                    UserEmail = loginViewModel.UserEmail,
                    Password = loginViewModel.Password,
                };
                context.Logins.Add(login);
                context.SaveChanges();
                return Redirect("/Login");
            }
            return View();
        }
        
        
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validate integer 
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //clear user inputs 
        private void ClearTexts(string useremail, string password)
        {
            useremail = String.Empty;
            password = String.Empty;
        }

        
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string useremail, string password)
        {

            //check user name empty 
            if (string.IsNullOrEmpty(useremail))
            {
                //MessageBox.Show("Enter the user name!");
                return false;

            }
            //check user name is valid type 
            else if (StringValidator(useremail) == true)
            {
                //MessageBox.Show("Enter only text here");
                ClearTexts(useremail, password);
                return false;
            }
            //check user name is correct 
            else
            {
                if (useremail != useremail)
                {
                   // MessageBox.Show("User name is incorrect!");
                    ClearTexts(useremail, password);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(password))
                    {
                        //MessageBox.Show("Enter the passowrd!");
                        return false;
                    }
                    //check password is valid 
                    else if (IntegerValidator(password) == true)
                    {
                        //MessageBox.Show("Enter only integer here");
                        return false;
                    }
                    //check password is correct 
                    else if (password != password)
                    {
                       // MessageBox.Show("Password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}