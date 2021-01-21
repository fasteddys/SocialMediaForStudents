using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Followers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class FollowersService : IFollowersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> followersService;

        public FollowersService(IDeletableEntityRepository<ApplicationUser> followersService)
        {
            this.followersService = followersService;
        }

        public IEnumerable<T> GetAllByUsername<T>(string username)
        {
            IEnumerable<T> followers = this.followersService
                .All()
                .Where(fu => fu.UserName == username)
                .To<T>()
                .ToList();

            return followers;
        }
    }
}
