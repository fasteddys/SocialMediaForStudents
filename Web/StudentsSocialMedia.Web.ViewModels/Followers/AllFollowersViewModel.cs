using AutoMapper;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Followers
{
    public class AllFollowersViewModel : IMapFrom<ApplicationUser>, IHaveCustomMappings
    {
        public string UserName { get; set; }

        public string ImageUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ApplicationUser, AllFollowersViewModel>()
                .ForMember(all => all.ImageUrl, opt => opt.MapFrom(au => au.Images.FirstOrDefault().RemoteImageUrl != null
                    ? au.Images.FirstOrDefault().RemoteImageUrl : $"/images/users/{au.Images.FirstOrDefault().Id}{au.Images.FirstOrDefault().Extension}"));
        }
    }
}
