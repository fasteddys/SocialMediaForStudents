using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class CommentsService : ICommentsService
    {
        private readonly IDeletableEntityRepository<Comment> commentsRepository;

        public CommentsService(IDeletableEntityRepository<Comment> commentsRepository)
        {
            this.commentsRepository = commentsRepository;
        }

        public IEnumerable<T> GetAll<T>(string postId)
        {
            IEnumerable<T> comments = this.commentsRepository
                .All()
                .Where(c => c.PostId == postId)
                .OrderByDescending(c => c.CreatedOn)
                .To<T>()
                .ToList();

            return comments;
        }
    }
}
