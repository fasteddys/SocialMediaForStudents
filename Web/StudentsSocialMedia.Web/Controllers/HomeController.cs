namespace StudentsSocialMedia.Web.Controllers
{
    using System.Diagnostics;

    using StudentsSocialMedia.Web.ViewModels.Home;

    using Microsoft.AspNetCore.Mvc;
    using StudentsSocialMedia.Services.Data;
    using StudentsSocialMedia.Web.ViewModels.Posts;
    using StudentsSocialMedia.Web.ViewModels;
    using System.Collections;
    using StudentsSocialMedia.Web.ViewModels.Comments;
    using System.Collections.Generic;

    public class HomeController : BaseController
    {
        private readonly IPostsService postsService;

        public HomeController(IPostsService postsService)
        {
            this.postsService = postsService;
        }

        public IActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel
            {
                Posts = this.postsService.GetAll(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
