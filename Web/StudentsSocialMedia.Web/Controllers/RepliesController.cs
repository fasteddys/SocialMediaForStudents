using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Data;
using StudentsSocialMedia.Web.ViewModels.Home;
using StudentsSocialMedia.Web.ViewModels.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Web.Controllers
{
    public class RepliesController : Controller
    {
        private readonly IRepliesService repliesService;
        private readonly UserManager<ApplicationUser> userManager;

        public RepliesController(IRepliesService repliesService, UserManager<ApplicationUser> userManager)
        {
            this.repliesService = repliesService;
            this.userManager = userManager;
        }

        public IActionResult AllById(string id)
        {
            AllRepliesListViewModel viewModel = new AllRepliesListViewModel
            {
                Replies = this.repliesService.GetAll<AllRepliesViewModel>(id),
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
        public async Task<IActionResult> Create(string id, CreateReplyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect($"/Replies/Create/{id}");
            }

            ApplicationUser user = await this.userManager.GetUserAsync(this.User);
            input.CommentId = id;
            input.AuthorId = user.Id;
            await this.repliesService.Create(input);

            return this.Redirect("/");
        }
    }
}
