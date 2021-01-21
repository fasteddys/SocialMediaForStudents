using StudentsSocialMedia.Web.ViewModels.Home;
using StudentsSocialMedia.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public interface IPostsService
    {
        IEnumerable<T> GetAll<T>();

        IEnumerable<T> GetAllByUsername<T>(string username);

        Task CreateAsync(CreatePostInputModel input);
    }
}
