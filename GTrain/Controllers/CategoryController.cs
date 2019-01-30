//using GTrain.Data;
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
        private readonly TopicDbContext context;

        public CategoryController(TopicDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Add()
        {
            AddCategoryItemViewModel addCategoryViewModel = new AddCategoryItemViewModel();
            return View(addCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryItemViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category newCategory = new Category
                {
                    Name = addCategoryViewModel.Name
                };

                context.Menus.Add(newCategory);
                context.SaveChanges();

                return Redirect("/Category");
                //return Redirect("/Menu/ViewMenu/" + newMenu.ID);
            }

            return View(addCategoryViewModel);
        }
        public IActionResult ViewCategory(int id, ViewCategoryViewModel viewMenuViewModel)
        {
            List<TopicCategory> items = context
                .TopicCategory
                .Include(item => item.Topic)
                .Where(cm => cm.CategoryID == id)
                .ToList();
            Category category = context.Categories.Where(m => m.ID == id).Single();


            viewCategoryViewModel.Items = items;
            viewCategoryViewModel.Category = category;
            return View(viewCategoryViewModel);
        }
        public IActionResult AddItem(int id)
        {
            Category category = context.Categories.Single(m => m.ID == id);
            List<Topic> Topics = context.Topics.ToList();
            return View(new AddCategoryItemViewModel(category, topics));
        }
        [HttpPost]
        public IActionResult AddItem(AddCategoryItemViewModel addCategoryItemViewModel)
        {
            if (ModelState.IsValid)
            {
                var cheeseID = addCategoryItemViewModel.TopicID;
                var menuID = addCategoryItemViewModel.CategoryID;

                IList<TopicCategory> existingItems = context.TopicCategories
                    .Where(cm => cm.TopicID == topicID)
                    .Where(cm => cm.CategoryID == categoryID).ToList();

                if (existingItems.Count == 0)
                {
                    TopicCategory menuItem = new TopicCategory
                    {
                        //CheeseID = addMenuItemViewModel.CheeseID,
                        Topic = context.Topics.Single(c => c.ID == topicID),
                        //MenuID = addMenuItemViewModel.MenuID,
                        Category = context.Categories.Single(m => m.ID == categoryID)
                    };
                    context.TopicCategory.Add(categoryItem);
                    context.SaveChanges();

                };

                return Redirect(string.Format($"/Category/ViewCategory/{categoryID}", addCategoryItemViewModel.Menu));
            }
            return View(addCategoryItemViewModel);
        }
    }
}