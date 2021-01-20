using StudentsSocialMedia.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public interface ICommentsService
    {
        IEnumerable<T> GetAll<T>(string postId);

        Task CreateAsync(CreateCommentInputModel input);
    }
}
