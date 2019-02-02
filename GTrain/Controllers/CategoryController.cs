using GTrain.Data;
using GTrain.Models;
using GTrain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GTrain.Controllers
{
    public class CategoryController : Controller
   {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            //IList<CheeseCategory> categories = context.Categories.ToList();
            //return View(categories);
        }
        
        private readonly TrainingDbContext context;

        public CategoryController(TrainingDbContext dbContext)
        {
            context = dbContext;
        }

       public IActionResult Add()
        {
           AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
           return View(addCategoryViewModel);
           //Create an Add action within CategoryController that 
           //creates an AddCategoryViewModel and passes it into the view.
        }
        /*
        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                CheeseCategory newCheeseCategory = new CheeseCategory
                {
                    Name = addCategoryViewModel.Name
                    //ID = addCategoryViewModel.CategoryID, 
                    
                };

                context.Categories.Add(newCheeseCategory);
                    context.SaveChanges();
                return Redirect("/Category");
                 }
                
            return View(addCategoryViewModel);
            

        }*/
    }
}