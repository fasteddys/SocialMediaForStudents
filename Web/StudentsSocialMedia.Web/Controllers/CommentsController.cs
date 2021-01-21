using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Data;
using StudentsSocialMedia.Web.ViewModels.Comments;
using StudentsSocialMedia.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Web.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentsController(ICommentsService commentsService, UserManager<ApplicationUser> userManager)
        {
            this.commentsService = commentsService;
            this.userManager = userManager;
        }

        public IActionResult AllById(string id)
        {
            AllViewModelList viewModel = new AllViewModelList
            {
                Comments = this.commentsService.GetAll<AllViewModel>(id),
            };

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult Create(string id)
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(string id, CreateCommentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/");
            }

            ApplicationUser user = await this.userManager.GetUserAsync(this.User);
            input.PostId = id;
            input.AuthorId = user.Id;
            await this.commentsService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
