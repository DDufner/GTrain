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
    public class TopicController : Controller
    {
        private TrainingDbContext context;

        public TopicController(TrainingDbContext dbContext)
        {
            context = dbContext;
        }
        
        public IActionResult Index()
        {
            //IList<Topic> topics = context.Topics.Include(context => c.Category).ToList(); //WARNING: check if catetory 
            //is correct ref, since not using category as used in CheeseCategory
            
            return View();
        }


        public IActionResult Test()
        {
            return View();
        }
        
        public IActionResult Add()
        {
            AddTopicViewModel addTopicViewModel = new AddTopicViewModel();
            return View(addTopicViewModel);
            //WARNING: check if catetory 
            //is correct ref, since not using category as used in CheeseCategory
        }
        [HttpPost]
        public IActionResult Add(AddTopicViewModel addTopicViewModel)
        {
            if (ModelState.IsValid)
            {
                //CheeseCategory newCheeseCategory =
                //context.Categories.Single(c => c.ID == addCheeseViewModel.CategoryID);
                // Add the new cheese to my existing cheeses
                Topic newTopic = new Topic
                {
                    Name = addTopicViewModel.Name,
                    Description = addTopicViewModel.Description,
                    //Category = newCheeseCategory //was 'addCheeseViewModel.CategoryID' 
                };
                context.Topics.Add(newTopic);
                context.SaveChanges();
                return Redirect("/Topic");
            }

            return View(addTopicViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Topic";
            ViewBag.topics = context.Topics.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] topicIds)
        {
            foreach (int topicId in topicIds)
            {
                Topic theTopic = context.Topics.Single(c => c.ID == topicId);
                context.Topics.Remove(theTopic);
            }

            context.SaveChanges();

            return Redirect("/");
        }
    }
}