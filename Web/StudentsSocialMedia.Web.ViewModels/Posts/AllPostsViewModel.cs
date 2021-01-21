using AutoMapper;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Posts
{
    public class AllPostsViewModel : IMapFrom<Post>
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public string SubjectName { get; set; }

        public string CreatorUserName { get; set; }

        public string CreatorId { get; set; }
    }
}
