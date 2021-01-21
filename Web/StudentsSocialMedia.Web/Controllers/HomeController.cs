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
    using StudentsSocialMedia.Web.ViewModels.Profiles;

    public class HomeController : BaseController
    {
        private readonly IPostsService postsService;
        private readonly IUsersService usersService;
        private readonly ISubjectsService subjectsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICommentsService commentsService;

        public HomeController(
            IPostsService postsService,
            IUsersService usersService,
            ISubjectsService subjectsService,
            UserManager<ApplicationUser> userManager,
            ICommentsService commentsService)
        {
            this.postsService = postsService;
            this.usersService = usersService;
            this.subjectsService = subjectsService;
            this.userManager = userManager;
            this.commentsService = commentsService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            ApplicationUser currentUser = await this.userManager.GetUserAsync(this.User);

            IndexViewModel viewModel = new IndexViewModel
            {
                Posts = this.postsService.GetAll<PostViewModel>(),
                CurrentUserInfo = this.usersService.GetByUsername<UserViewModel>(currentUser.UserName),
            };

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult CreateReply(string id)
        {
            return this.View();
        }

        public async Task<IActionResult> CreateReply(string id, CreateReplyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect($"/Home/CreateReply/{id}");
            }

            ApplicationUser user = await this.userManager.GetUserAsync(this.User);

            return this.Redirect("/");
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
