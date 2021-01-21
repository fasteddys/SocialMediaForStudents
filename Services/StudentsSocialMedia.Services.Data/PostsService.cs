using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Comments;
using StudentsSocialMedia.Web.ViewModels.Home;
using StudentsSocialMedia.Web.ViewModels.Posts;
using StudentsSocialMedia.Web.ViewModels.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public class PostsService : IPostsService
    {
        private readonly IDeletableEntityRepository<Post> postsRepository;

        public PostsService(IDeletableEntityRepository<Post> postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public async Task CreateAsync(CreatePostInputModel input)
        {
            Post post = new Post
            {
                Content = input.Content,
                SubjectId = input.SubjectId,
                CreatorId = input.CreatorId,
            };

            await this.postsRepository.AddAsync(post);
            await this.postsRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>()
        {
            IEnumerable<T> posts = this.postsRepository
                .All()
                .OrderByDescending(p => p.CreatedOn)
                .To<T>()
                .ToList();

            return posts;
        }

        public IEnumerable<T> GetAllByUsername<T>(string username)
        {
            IEnumerable<T> posts = this.postsRepository
                .All()
                .Where(p => p.Creator.UserName == username)
                .OrderByDescending(p => p.CreatedOn)
                .To<T>()
                .ToList();

            return posts;
        }
    }
}
