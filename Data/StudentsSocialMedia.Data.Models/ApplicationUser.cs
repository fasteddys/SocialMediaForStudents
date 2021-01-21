// ReSharper disable VirtualMemberCallInConstructor
namespace StudentsSocialMedia.Data.Models
{
    using System;
    using System.Collections.Generic;

    using StudentsSocialMedia.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;
    using StudentsSocialMedia.Data.Models.Enumerations;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Subjects = new HashSet<UserSubject>();
            this.TestsCreated = new HashSet<Test>();
            this.TestsCompleted = new HashSet<TestParticipant>();
            this.GroupsCreated = new HashSet<Group>();
            this.Groups = new HashSet<MemberGroup>();
            this.Images = new HashSet<Image>();
            this.Followers = new HashSet<ApplicationUser>();
            this.Following = new HashSet<ApplicationUser>();
            this.Likes = new HashSet<Like>();
            this.Comments = new HashSet<Comment>();
            this.Replies = new HashSet<Reply>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string TownId { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<UserSubject> Subjects { get; set; }

        public virtual ICollection<Test> TestsCreated { get; set; }

        public virtual ICollection<TestParticipant> TestsCompleted { get; set; }

        public virtual ICollection<Group> GroupsCreated { get; set; }

        public virtual ICollection<MemberGroup> Groups { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<ApplicationUser> Followers { get; set; }

        public virtual ICollection<ApplicationUser> Following { get; set; }

        public virtual ICollection<Like> Likes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
