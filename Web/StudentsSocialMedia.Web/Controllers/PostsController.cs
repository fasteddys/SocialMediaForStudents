using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Data;
using StudentsSocialMedia.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostsService postsService;
        private readonly ISubjectsService subjectsService;
        private readonly UserManager<ApplicationUser> userManager;

        public PostsController(IPostsService postsService, ISubjectsService subjectsService, UserManager<ApplicationUser> userManager)
        {
            this.postsService = postsService;
            this.subjectsService = subjectsService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            CreatePostInputModel input = new CreatePostInputModel
            {
                Subjects = this.subjectsService.GetAll(),
            };

            return this.View(input);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CreatePostInputModel input)
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
    }
}
