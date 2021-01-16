using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Posts
{
    public class PostViewModel : IMapFrom<Post>
    {
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public string SubjectName { get; set; }

        public string CreatorUserName { get; set; }
    }
}
