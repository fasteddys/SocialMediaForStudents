using StudentsSocialMedia.Web.ViewModels.Followers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface IFollowersService
    {
        IEnumerable<FollowerViewModel> GetAllByUsername(string username);
    }
}
