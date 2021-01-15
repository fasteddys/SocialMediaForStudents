using StudentsSocialMedia.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Data.Seeding
{
    public class PostsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Posts.Any())
            {
                return;
            }

            ICollection<Post> posts = new List<Post>()
            {
                new Post
                {
                    Content = "Math is very good subject. Its not only in everything but it is very good for your logical thinking. A brain is like a muscle and Math helps it grow",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Mathematics").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "Personally, I just find mathematics beautiful. The elegance and the smoothness of a perfect theorem. it just feels really nice and warm.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Mathematics").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser2").Id,
                },
                new Post
                {
                    Content = "Math is really important to a certain extent, in many ways its importance isn't to teach you how to understand topics, but how to think.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Mathematics").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser3").Id,
                },
                new Post
                {
                    Content = "I agree it is very important and it includes in many jobs.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "English").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "By far the most important subject IN THE WORLD. ",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "English").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser2").Id,
                },
                new Post
                {
                    Content = "How can English be the most important subject? We should have stopped learning English after high school.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "English").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser3").Id,
                },
                new Post
                {
                    Content = "Science allows us to understand and question the world.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Physics").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "Science is maybe not necessary in the way that it is currently taught, but there are certain things everyone should know about our species, planet, and universe..",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Physics").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "Science is so important. Everything is first discovered with Science, then Math.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Physics").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser3").Id,
                },
                new Post
                {
                    Content = "History is one of the most useless subjects I have no idea why it's ranked so high.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "History").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser3").Id,
                },
                new Post
                {
                    Content = "History is not super important, but it can lead you to make a better decision than that of those before you. ",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "History").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser3").Id,
                },
                new Post
                {
                    Content = "I agree 100%. History allows us to learn from the large scale mistakes that many have made throughout in the past. ",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "History").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser2").Id,
                },
                new Post
                {
                    Content = "Many of the decisions leading to the biggest mistakes of History were made around tables from which a Geographer was missing. ",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Geography").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser2").Id,
                },
                new Post
                {
                    Content = "Geography is our world, and if we don't understand it then we can't prepare for the future, such as avoiding a tsunami.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Geography").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "Affects us everyday.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Geography").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser2").Id,
                },
                new Post
                {
                    Content = "The study and possible explanation of all the properties of all the materials and substances in the world and how they in they interact with each other. ",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Chemistry").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser2").Id,
                },
                new Post
                {
                    Content = "Chemistry is the central science.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Chemistry").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "If you don't know about danger chemical, you might have accident.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "Chemistry").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser3").Id,
                },
                new Post
                {
                    Content = "Computers dominate our daily lives now, from mobiles all the way to supercomputers, Computer Science/Software Engineering is an extremely important, yet clearly under-rated subject that teaches you how to think logically and is commonly used in conjunction with other important subjects such as maths, science and English.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "I.T.").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "The whole future will be based on computer systems.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "I.T.").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
                new Post
                {
                    Content = "This should be within the top 5, somewhere closer to mathematics. It is such an important skill to be able to have for future jobs in IT and Science, and Mathematics.",
                    SubjectId = dbContext.Subjects.FirstOrDefault(s => s.Name == "I.T.").Id,
                    CreatorId = dbContext.Users.FirstOrDefault(u => u.FirstName == "testUser1").Id,
                },
            };

            await dbContext.AddRangeAsync(posts);
            await dbContext.SaveChangesAsync();
        }
    }
}
