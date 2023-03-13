using Discussion.Web.Models.Discussion;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Discussion.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new AddDiscussionViewModel();
            return View(model);
        }
        public IActionResult Edit(Guid id)
        {
            EditDiscussionModel viewModel = new()
            {
                Id = id
            };
            return View(viewModel);
        }
    }
}
