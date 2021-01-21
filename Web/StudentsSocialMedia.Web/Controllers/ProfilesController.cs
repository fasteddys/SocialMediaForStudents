using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Data;
using StudentsSocialMedia.Web.ViewModels.Posts;
using StudentsSocialMedia.Web.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Web.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly IPostsService postsService;
        private readonly IImagesService imagesService;
        private readonly IFollowersService followersService;
        private readonly IUsersService usersService;
        private readonly UserManager<ApplicationUser> userManager;

        public ProfilesController(
            IPostsService postsService,
            IImagesService imagesService,
            IFollowersService followersService,
            IUsersService usersService,
            UserManager<ApplicationUser> userManager)
        {
            this.postsService = postsService;
            this.imagesService = imagesService;
            this.followersService = followersService;
            this.usersService = usersService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Profile(string id)
        {
            ProfileViewModel viewModel = new ProfileViewModel
            {
                UserInfo = this.usersService.GetByUsername<UserViewModel>(id),
                Posts = this.postsService.GetAllByUsername<AllPostsViewModel>(id),
                LastPhotos = this.imagesService.GetAllByUsername(id),
                Followers = this.followersService.GetAllByUsername(id),
            };

            return this.View(viewModel);
        }
    }
}
