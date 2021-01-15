using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class Subject : BaseDeletableModel<string>
    {
        public Subject()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Users = new HashSet<UserSubject>();
            this.Tests = new HashSet<Test>();
            this.Groups = new HashSet<Group>();
            this.Posts = new HashSet<Post>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<UserSubject> Users { get; set; }

        public virtual ICollection<Test> Tests { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
