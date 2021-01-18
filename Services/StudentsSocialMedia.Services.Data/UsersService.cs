using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Web.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public UsersService(IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public UserViewModel GetByUsername(string username)
        {
            UserViewModel user = this.usersRepository
                .All()
                .Where(u => u.UserName == username)
                .Select(u => new UserViewModel
                {
                    UserName = u.UserName,
                    UserProfileImageUrl = u.Images.FirstOrDefault().RemoteImageUrl != null
                    ? u.Images.FirstOrDefault().RemoteImageUrl : $"/images/users/{u.Images.FirstOrDefault().Id}{u.Images.FirstOrDefault().Extension}",
                    Town = u.Town.Name,
                })
                .FirstOrDefault();

            return user;
        }
    }
}
