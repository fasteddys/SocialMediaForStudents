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
        IEnumerable<AllRepliesViewModel> GetAll();

        Task Create(CreateReplyInputModel input);
    }
}
