using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Images
{
    public class AllImagesViewModel : IMapFrom<Image>
    {
        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        public string UserId { get; set; }
    }
}
