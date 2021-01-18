using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Web.ViewModels.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class ImagesService : IImagesService
    {
        private readonly IDeletableEntityRepository<Image> imagesRepository;

        public ImagesService(IDeletableEntityRepository<Image> imagesRepository)
        {
            this.imagesRepository = imagesRepository;
        }

        public IEnumerable<ImageViewModel> GetAllByUsername(string username)
        {
            IEnumerable<ImageViewModel> images = this.imagesRepository
                .All()
                .Where(i => i.User.UserName == username)
                .Select(i => new ImageViewModel
                {
                    Extension = i.Extension,
                    RemoteImageUrl = i.RemoteImageUrl,
                    UserId = i.UserId,
                })
                .ToList();

            return images;
        }
    }
}
