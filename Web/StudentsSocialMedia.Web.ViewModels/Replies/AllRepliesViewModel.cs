using AutoMapper;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Replies
{
    public class AllRepliesViewModel : IMapFrom<Reply>, IHaveCustomMappings
    {
        public string Content { get; set; }

        public string AuthorId { get; set; }

        public string AuthorUserName { get; set; }

        public string AuthorImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Reply, AllRepliesViewModel>()
                .ForMember(all => all.AuthorImageUrl, opt => opt.MapFrom(r => r.Author.Images.FirstOrDefault().RemoteImageUrl != null
                    ? r.Author.Images.FirstOrDefault().RemoteImageUrl : $"/images/users/{r.Author.Images.FirstOrDefault().Id}{r.Author.Images.FirstOrDefault().Extension}"));
        }
    }
}
