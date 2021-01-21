using AutoMapper;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Comments
{
    public class AllViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }

        public string AuthorUserName { get; set; }

        public string AuthorImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Comment, AllViewModel>()
                .ForMember(all => all.AuthorImageUrl, opt => opt.MapFrom(c => c.Author.Images.FirstOrDefault().RemoteImageUrl != null
                    ? c.Author.Images.FirstOrDefault().RemoteImageUrl : $"/images/users/{c.Author.Images.FirstOrDefault().Id}{c.Author.Images.FirstOrDefault().Extension}"));
        }
    }
}
