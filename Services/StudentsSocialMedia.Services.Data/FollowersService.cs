using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Web.ViewModels.Followers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class FollowersService : IFollowersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> followersRepository;

        public FollowersService(IDeletableEntityRepository<ApplicationUser> followersRepository)
        {
            this.followersRepository = followersRepository;
        }

        public IEnumerable<FollowerViewModel> GetAllByUsername(string username)
        {
            IEnumerable<FollowerViewModel> followers = this.followersRepository
                .All()
                .Select(f => new FollowerViewModel
                { 
                })
                .ToList();

            return followers;
        }
    }
}
