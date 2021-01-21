using Moq;
using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StudentsSocialMedia.Services.Data.Tests
{
    public class PostsServiceTests
    {
        [Fact]
        public void GetAllShouldReturnCollectionWithCorrectValues()
        {
            
        }

        private IEnumerable<Post> GetTestData()
        {
            IEnumerable<Post> posts = new List<Post>()
            {
                new Post
                {
                    Id = "1",
                    Content = "testContent1",
                    SubjectId = "1",
                    CreatorId = "1",
                    Comments = new List<Comment>()
                    {
                        new Comment
                        {
                            Content = "commentContent1",
                            PostId = "1",
                            AuthorId = "2",
                        },
                    },
                },
                new Post
                {
                    Id = "2",
                    Content = "testContent2",
                    SubjectId = "2",
                    CreatorId = "2",
                    Comments = new List<Comment>()
                    {
                        new Comment
                        {
                            Content = "commentContent2",
                            PostId = "2",
                            AuthorId = "3",
                        },
                    },
                },
                new Post
                {
                    Id = "3",
                    Content = "testContent3",
                    SubjectId = "3",
                    CreatorId = "3",
                    Comments = new List<Comment>()
                    {
                        new Comment
                        {
                            Content = "commentContent3",
                            PostId = "3",
                            AuthorId = "4",
                        },
                    },
                },
            };

            return posts;
        }
    }
}
