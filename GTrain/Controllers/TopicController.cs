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

            List<Topic> topics = context.Topics.ToList();
            ViewBag.topics = context.Topics.ToList();
            //IList<Topic> topics = context.Topics.Include(context => c.Category).ToList(); //WARNING: check if catetory 

            return View(topics);
        }


        public IActionResult Test()
        {
            return View();
        }
        
        public IActionResult Add()
        {
            AddTopicViewModel addTopicViewModel = new AddTopicViewModel();
            //AddTopicViewModel addTopicViewModel = new AddTopicViewModel(context.Topics.ToList());
            return View(addTopicViewModel);

        }
        [HttpPost]
        public IActionResult Add(AddTopicViewModel addTopicViewModel)
        {
            if (ModelState.IsValid)
            {
                Topic newTopic = new Topic                
                {
                    Name = addTopicViewModel.Name,
                    Description = addTopicViewModel.Description,
                    ID = addTopicViewModel.ID
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