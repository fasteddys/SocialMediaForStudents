using StudentsSocialMedia.Web.ViewModels.Home;
using StudentsSocialMedia.Web.ViewModels.Replies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public interface IRepliesService
    {
        IEnumerable<T> GetAll<T>(string id);

        Task Create(CreateReplyInputModel input);
    }
}
