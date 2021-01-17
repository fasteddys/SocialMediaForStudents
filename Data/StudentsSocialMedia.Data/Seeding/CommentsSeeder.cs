using StudentsSocialMedia.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Data.Seeding
{
    public class CommentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Comments.Any())
            {
                return;
            }

            ICollection<Comment> comments = new List<Comment>()
            {
                new Comment
                {
                    Content = "I agree",
                    PostId = "416b215f-1196-4289-ab22-916232d822b9",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser1").Id,
                },
                new Comment
                {
                    Content = "I agree",
                    PostId = "416b215f-1196-4289-ab22-916232d822b9",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser1").Id,
                },
                new Comment
                {
                    Content = "I agree",
                    PostId = "416b215f-1196-4289-ab22-916232d822b9",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser2").Id,
                },
                new Comment
                {
                    Content = "I agree",
                    PostId = "416b215f-1196-4289-ab22-916232d822b9",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser2").Id,
                },
                new Comment
                {
                    Content = "I agree",
                    PostId = "37614c91-c118-4e36-8aad-0c5693ab8f01",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser3").Id,
                },
                new Comment
                {
                    Content = "I agree",
                    PostId = "37614c91-c118-4e36-8aad-0c5693ab8f01",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser3").Id,
                },
                new Comment
                {
                    Content = "I agree",
                    PostId = "37614c91-c118-4e36-8aad-0c5693ab8f01",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser2").Id,
                },
                new Comment
                {
                    Content = "I agree",
                    PostId = "37614c91-c118-4e36-8aad-0c5693ab8f01",
                    AuthorId = dbContext.Users.FirstOrDefault(u => u.UserName == "testUser1").Id,
                },
            };

            await dbContext.AddRangeAsync(comments);
            await dbContext.SaveChangesAsync();
        }
    }
}
