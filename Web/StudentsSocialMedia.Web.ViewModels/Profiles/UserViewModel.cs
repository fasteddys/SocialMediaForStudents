using AutoMapper;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Profiles
{
    public class UserViewModel : IMapFrom<ApplicationUser>, IHaveCustomMappings
    {
        public string UserProfileImageUrl { get; set; }

        public string UserName { get; set; }

        public string Town { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(u => u.UserProfileImageUrl, opt => opt.MapFrom(au => au.Images.FirstOrDefault().RemoteImageUrl != null
                    ? au.Images.FirstOrDefault().RemoteImageUrl : $"/images/users/{au.Images.FirstOrDefault().Id}{au.Images.FirstOrDefault().Extension}"));
        }
    }
}
