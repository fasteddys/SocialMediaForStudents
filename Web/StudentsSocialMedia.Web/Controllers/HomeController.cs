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
    using Microsoft.AspNetCore.Authorization;
    using StudentsSocialMedia.Data.Models;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;

    public class HomeController : BaseController
    {
        private readonly IPostsService postsService;
        private readonly IUsersService usersService;
        private readonly ISubjectsService subjectsService;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(
            IPostsService postsService,
            IUsersService usersService,
            ISubjectsService subjectsService,
            UserManager<ApplicationUser> userManager)
        {
            this.postsService = postsService;
            this.usersService = usersService;
            this.subjectsService = subjectsService;
            this.userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            ApplicationUser currentUser = await this.userManager.GetUserAsync(this.User);

            IndexViewModel viewModel = new IndexViewModel
            {
                Posts = this.postsService.GetAll(),
                CurrentUserInfo = this.usersService.GetByUsername(currentUser.UserName),
            };

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult CreatePost()
        {
            CreatePostInputModel input = new CreatePostInputModel
            {
                Subjects = this.subjectsService.GetAll(),
            };

            return this.View(input);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreatePost(CreatePostInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Subjects = this.subjectsService.GetAll();
                return this.View(input);
            }

            ApplicationUser user = await this.userManager.GetUserAsync(this.User);
            input.CreatorId = user.Id;
            await this.postsService.CreateAsync(input);

            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult CreateComment()
        {
            return this.View();
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
