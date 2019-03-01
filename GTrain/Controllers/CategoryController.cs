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
            List<Category> categories = context.Categories.ToList();
            return View(categories);
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

        }
        
        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category newCategory = new Category
                {
                    Name = addCategoryViewModel.Name,
                    ID = addCategoryViewModel.ID
                    
                };

                context.Categories.Add(newCategory);
                    context.SaveChanges();
                return Redirect("/Category");
             }
                
            return View(addCategoryViewModel);
        }
//line 60-64 hits an SQL exception, "Invaild column name 'ID'"
//TopicCategory columns are:
        //CategoryID
        //TopicID
        //CategoryTopicID
        //CategoryID1

     //Cheese equivelent topics are
        //MenuID 
        //CheeseID
        public IActionResult ViewCategory (int id, ViewCategoryViewModel viewCategoryViewModel)
            {
            List<TopicCategory> items = context
            .TopicCategories
            .Include(topic => topic.Topic)///check on topic vs items 
            .Where(tc => tc.CategoryID == id)// was 'cm' in cheeseP
            .ToList();
            Category category = context.Categories.Where(c => c.ID == id).Single(); //was 'm' in cheeseP

            viewCategoryViewModel.Topics = items;
            viewCategoryViewModel.Category = category;
            return View(viewCategoryViewModel);
        }
        
        public IActionResult AddItem (int id)
        {
            Category category = context.Categories.Single(c => c.ID == id);
            List<Topic> topics = context.Topics.ToList();
            return View(new AddCategoryItemViewModel(category, topics));
        }
            
        [HttpPost]
        public IActionResult AddItem (AddCategoryItemViewModel addCategoryItemViewModel)
        {   
            if (ModelState.IsValid)
            {
                var ID = addCategoryItemViewModel.ID;
                var categoryID = addCategoryItemViewModel.Category;

                IList<TopicCategory> existingItems = context.TopicCategories
                   .Where(cm => cm.ID == ID)
                   .Where(cm => cm.Category == categoryID).ToList();
                ;
                if (existingItems.Count == 0)
                {
                    TopicCategory categoryItem = new TopicCategory
                    {
                        Topic = context.Topics.Single(t => t.ID == ID),
                        Category = context.Categories.Single(c => c.ID == ID)  //was(c => c.ID == categoryID)
                    };
                    context.TopicCategories.Add(categoryItem);
                    context.SaveChanges();

                };
                
                return Redirect(string.Format($"/Category/ViewCategory/{categoryID}", addCategoryItemViewModel.Category));
            } 
            return View(addCategoryItemViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Category";
            ViewBag.categories = context.Categories.ToList();
            return View();
        }
        
        [HttpPost]
        public IActionResult Remove(int[] categoryIds)
        {
            foreach (int categoryId in categoryIds)
            {
                Category theCategory = context.Categories.Single(c => c.ID == categoryId);
                context.Categories.Remove(theCategory);
            }
            context.SaveChanges();

            return Redirect("/");
        }
    }
}