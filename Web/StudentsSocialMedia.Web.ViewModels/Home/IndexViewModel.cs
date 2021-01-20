using StudentsSocialMedia.Web.ViewModels.Posts;
using StudentsSocialMedia.Web.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<PostViewModel> Posts { get; set; }

        public UserViewModel CurrentUserInfo { get; set; }
    }
}
