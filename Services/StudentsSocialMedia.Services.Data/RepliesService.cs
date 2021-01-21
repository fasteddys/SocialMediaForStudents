using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using StudentsSocialMedia.Web.ViewModels.Home;
using StudentsSocialMedia.Web.ViewModels.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Services.Data
{
    public class RepliesService : IRepliesService
    {
        private readonly IDeletableEntityRepository<Reply> repliesRepository;

        public RepliesService(IDeletableEntityRepository<Reply> repliesRepository)
        {
            this.repliesRepository = repliesRepository;
        }

        public async Task Create(CreateReplyInputModel input)
        {
            Reply reply = new Reply
            {
                Content = input.Content,
                CommentId = input.CommentId,
                AuthorId = input.AuthorId,
            };

            await this.repliesRepository.AddAsync(reply);
            await this.repliesRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(string id)
        {
            IEnumerable<T> replies = this.repliesRepository
                .All()
                .Where(r => r.CommentId == id)
                .To<T>()
                .ToList();

            return replies;
        }
    }
}
