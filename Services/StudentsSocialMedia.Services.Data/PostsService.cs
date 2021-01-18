using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Comments;
using StudentsSocialMedia.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class PostsService : IPostsService
    {
        private readonly IDeletableEntityRepository<Post> postsRepository;

        public PostsService(IDeletableEntityRepository<Post> postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public IEnumerable<PostViewModel> GetAll()
        {
            IEnumerable<PostViewModel> posts = this.postsRepository
                .All()
                .OrderByDescending(p => p.CreatedOn)
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Content = p.Content,
                    CreatedOn = p.CreatedOn,
                    CreatorUserName = p.Creator.UserName,
                    CreatorId = p.CreatorId,
                    SubjectName = p.Subject.Name,
                    Comments = p.Comments
                    .Where(c => c.PostId == p.Id)
                    .OrderByDescending(c => c.CreatedOn)
                    .Select(c => new AllViewModel
                    {
                        AuthorUserName = c.Author.UserName,
                        AuthorImageUrl = c.Author.Images.FirstOrDefault().RemoteImageUrl != null
                        ? c.Author.Images.FirstOrDefault().RemoteImageUrl : $"/images/users/{c.Author.Images.FirstOrDefault().Id}{c.Author.Images.FirstOrDefault().Extension}",
                        Content = c.Content,
                        CreatedOn = c.CreatedOn,
                    })
                    .ToList(),
                })
                .ToList();

            return posts;
        }

        public IEnumerable<PostViewModel> GetAllByUsername(string username)
        {
            IEnumerable<PostViewModel> posts = this.postsRepository
                .All()
                .Where(p => p.Creator.UserName == username)
                .OrderByDescending(p => p.CreatedOn)
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Content = p.Content,
                    CreatedOn = p.CreatedOn,
                    CreatorUserName = p.Creator.UserName,
                    CreatorId = p.CreatorId,
                    SubjectName = p.Subject.Name,
                    Comments = p.Comments
                    .Where(c => c.PostId == p.Id)
                    .OrderByDescending(c => c.CreatedOn)
                    .Select(c => new AllViewModel
                    {
                        AuthorUserName = c.Author.UserName,
                        Content = c.Content,
                        CreatedOn = c.CreatedOn,
                    })
                    .ToList(),
                })
                .ToList();

            return posts;
        }
    }
}
