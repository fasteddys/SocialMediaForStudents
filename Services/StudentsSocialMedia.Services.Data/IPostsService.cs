using StudentsSocialMedia.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface IPostsService
    {
        IEnumerable<PostViewModel> GetAll();
    }
}
